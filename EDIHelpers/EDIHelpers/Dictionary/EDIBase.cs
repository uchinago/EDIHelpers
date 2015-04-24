using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using EDIHelpers.Acks;
using EDIHelpers.Acks.X12_997;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary.Segments;
using EDIHelpers.Enums;
using EDIHelpers.Helpers;
using EDIHelpers.Transformation;

namespace EDIHelpers.Dictionary
{
    
    public class EDIBase
    {

        private BindingFlags internalFlags = (BindingFlags.Instance | BindingFlags.NonPublic) ;
        private BindingFlags pubFlags = BindingFlags.Public;

        public EDIDelim originalDelims;

        public Ack997 EDI997;


        /// <summary>
        /// THis is the raw generic you should use from your programs
        /// </summary>
        /// <param name="ediFile"></param>
        public void FromEDIFile(string ediFile, bool createAck = false)
        {
            //get the seperators
            //then call the from EDI string....  
            EDIDelim currDelim = ediFile.SafeSubstring(0, 175).GetFileDelimiters();
            originalDelims = currDelim;
            try
            {
                FromEDIString(ediFile, currDelim);
            }
            catch (Exception)
            {
                //Do something for the Ack
                throw;
            }
            if (createAck)
            {
                CreateAcknowledgement(ediFile);

            }

        }



        /// <summary>
        /// one GS per inbound File
        /// one ST per GS of inbound.
        /// Report each inbound ST in an AK2 loop
        /// </summary>
        /// <param name="ediFile"></param>
        internal void CreateAcknowledgement(string ediFile)
        {
            GenericEDI tmp = new GenericEDI();
            tmp.FromEDIFile(ediFile);
            EDI997 = new Ack997();
            EDI997.originalDelims = originalDelims;
            //build the ISA/GS
            EDI997.ISA = tmp.ISA.SwapSenderRcvr();
            EDI997.IEA = tmp.IEA.Clone();
            EDI997.GSLoop = new List<GS997>();

            GS997 tmpGS = new GS997();
            tmpGS.GS = tmp.GSLoop[0].GS.SwapSenderRcvr("FA");
            tmpGS.GE = tmp.GSLoop[0].GE.Clone();
            
            tmpGS.STLoops = new List<ST997>();

            for (int i = 0; i < tmp.GSLoop.Count; i++)
            {
                var g = tmp.GSLoop[i];
                ST997 tmpST = new ST997();
                tmpST.ST = new STSeg("997", (i + 1).ToString().PadLeft(4, '0'), g.STLoops[0].ST.ST03Version);
                tmpST.AK1 = new AK1Seg(tmpGS.GS.GS01GroupID, tmpGS.GS.GS06ControlNumber, tmpGS.GS.GS08Version);

                bool gsCountError = (g.STLoops.Count != g.GE.GE01_TransactionCount);
                tmpST.TransactionReponse = new List<LoopAK2>();
                for (int index = 0; index < g.STLoops.Count; index++)
                {
                    LoopAK2 lAK2 = new LoopAK2();
                    List<string> errors = new List<string>();
                    lAK2.AK2 = new AK2Seg(g.STLoops[index].ST.ST01TransactionID, g.STLoops[index].ST.ST02ControlNumber,
                                          String.IsNullOrWhiteSpace(g.STLoops[index].ST.ST03Version)
                                              ? tmpGS.GS.GS08Version
                                              : g.STLoops[index].ST.ST03Version);

                    //Determine errors
                    if (g.STLoops[index].SE.SE01_SegmentCount != (g.STLoops[index].Segments.Count + 2))
                    {
                        errors.Add("4");
                    }
         


                    lAK2.AK5 = new AK5Seg(errors.Count>0?'R':'A', errors.ToArray());
                    //if GE or SE is null then put an error
                    tmpST.TransactionReponse.Add(lAK2);
                }
                int accpted = tmpST.TransactionReponse.Count(x => x.AK5.AK501_AckCode.Equals('A'));
                int rejected = tmpST.TransactionReponse.Count(x => x.AK5.AK501_AckCode.Equals('R'));
                char ackCode = 'A';
                if (accpted > 0 && rejected > 0)
                    ackCode = 'P';
                if (accpted == 0 && rejected > 0)
                    ackCode = 'R';
                tmpST.AK9 = new AK9Seg(ackCode, tmpST.TransactionReponse.Count, g.STLoops.Count, accpted); 
                

                tmpST.SE = new SESeg();
                tmpST.SE.SE01_SegmentCount = 5;
                tmpST.SE.SE02_ControlNumber = tmpST.ST.ST02ControlNumber;
                tmpGS.STLoops.Add(tmpST);
                tmpST.SE = new SESeg(5,  tmpST.ST.ST02ControlNumber);
                
                EDI997.GSLoop.Add(tmpGS);
            }
            EDI997.SetCounts();
        }




        /// <summary>
        /// THis is the recursive function that is called.
        /// </summary>
        /// <param name="ediData"></param>
        /// <param name="seperators"></param>
        internal void FromEDIString(string ediData, EDIDelim seperators)
        {
            string[] strSegments = ediData.Split(new char[] { seperators.Segment }, StringSplitOptions.RemoveEmptyEntries);

            //Hopefully allows us to determine if the segment even belongs in the current object.
            List<string> objSegments = GetAvailableSegments();

            int p = 0;
            //TODO: How do we align the inbound to the object...  

            for (int objPntr = 0; objPntr < GetType().GetProperties().Length; objPntr++)
            {
                PropertyInfo propertyInfo = GetType().GetProperties()[objPntr];
                if (propertyInfo.CanRead)
                {
                    
                    Attribute[] attrs = Attribute.GetCustomAttributes(propertyInfo);
                    bool IsGeneric = false;
                    if (attrs.Any(x => x.GetType() == typeof (EDILoop)))
                    {
                        EDILoop currentLoop = ((EDILoop) attrs.FirstOrDefault(z => z.GetType() == typeof (EDILoop)));

                        currentLoop.AdjustFormat(seperators.Element);
                        //Check to see if the segment starts this way...
                        //string segStart = currentLoop.GetFormat() + seperators.Element;

                        if (strSegments[p].StartsWith(currentLoop.GetFormat()))
                        {
                            //This should be the amount of Segments we need to group together in order to split properly.
                            int es = strSegments.Count() - p - currentLoop.GetEndSkip();
                            //we know that the current loop is at least one we want...
                            //es cannot be less than 1
                            if (es == 0) es = 1;
                            //TODO: Multiple altsegment ending ID's how to handle here...
                            if (currentLoop.GetAltSegmentID().Any())
                            {
                                for (int i = p + 1; i < strSegments.Count(); i++)
                                {
                                    //if (strSegments[i].StartsWith(currentLoop.GetAltSegmentID()))
                                    if (
                                        currentLoop.GetAltSegmentID()
                                                   .Any(alt => strSegments[i].StartsWith(alt + seperators.Element)))
                                    {
                                        es = i - p;
                                        break;
                                    }
                                }
                            }

                            //We need to determine the end point of the alt ending if present.
                            List<string> loopValues =
                                String.Join("" + seperators.Segment, strSegments, p, es)
                                      .TransactionSplit(currentLoop, seperators);

                            //Foreach loop add since it is a list the "FromEDIString"
                            object propertyValue = propertyInfo.GetValue(this, null);
                            //This should always do the later but for testing have it here...
                            if (propertyValue == null)
                            {
                                //How do we put this as the property value
                                ConstructorInfo ctor = propertyInfo.PropertyType.GetConstructor(System.Type.EmptyTypes);
                                object instance = ctor.Invoke(null);

                                propertyInfo.SetValue(this, Convert.ChangeType(instance, propertyInfo.PropertyType),
                                                      null);
                                propertyValue = propertyInfo.GetValue(this, null);
                            }
                            if (IsPropertyACollection(propertyInfo))
                            {
                                MethodInfo Addmethod = propertyValue.GetType().GetMethod("Add");
                                Type t = propertyValue.GetType().GetGenericArguments()[0];
                                //EDIBase call
                                MethodInfo ediMethod = t.GetMethod("FromEDIString", internalFlags);

                                foreach (string lValues in loopValues)
                                {
                                    var tmp = t.GetConstructor(new Type[] {}).Invoke(new object[] {});
                                    //Invoke the EDI string parser
                                    ediMethod.Invoke(tmp, new object[] {lValues, seperators});
                                    //Add the new item to the list.
                                    Addmethod.Invoke(propertyValue, new object[] {tmp});
                                }
                            }
                            else
                            {
                                //This should only be called once... but we shall see...
                                foreach (string lValues in loopValues)
                                {
                                    MethodInfo ediMethod = propertyValue.GetType()
                                                                        .GetMethod("FromEDIString", internalFlags);
                                    ediMethod.Invoke(propertyValue, new object[] {lValues, seperators});
                                }
                            }
                            //p = strSegments.Count() - currentLoop.GetEndSkip();
                            p = p + es;
                        }
                        else
                        {
                            //If EDI file we are reading has an extra segment that is not part of the object
                            //then we need to skip it and go on to the next one, while keeping our place 
                            //in the current file to properly unmarshal the rest of the file
                            if (!IsValidSegment(strSegments[p], objSegments, objPntr))
                            {
                                p++;
                                objPntr--;
                            }

                        }
                    }
                    else
                    {
                        //Handle single and list of simple segments.
                        string segmentID = propertyInfo.PropertyType.Name.Replace("Seg", "");
                        if (segmentID.ToUpper().StartsWith("LIST"))
                        {
                            segmentID = propertyInfo.PropertyType.GetGenericArguments()[0].Name.Replace("Seg", "");

                            if (propertyInfo.PropertyType.GetGenericArguments()[0].Name.StartsWith("Generic"))
                            {
                                IsGeneric = true;
                            }
                        }
                        if (p > strSegments.Count() - 1)
                            break;

                        if (strSegments[p].StartsWith(segmentID) || IsGeneric)
                        {
                            //Actually Grab the class of what we are trying to do
                            object propertyValue = propertyInfo.GetValue(this, null);
                            if (propertyValue == null)
                            {
                                //How do we put this as the property value
                                ConstructorInfo ctor = propertyInfo.PropertyType.GetConstructor(System.Type.EmptyTypes);
                                object instance = ctor.Invoke(null);

                                propertyInfo.SetValue(this, Convert.ChangeType(instance, propertyInfo.PropertyType),
                                                      null);
                                propertyValue = propertyInfo.GetValue(this, null);
                            }
                            //Collection of single objects
                            if (IsPropertyACollection(propertyInfo))
                            {
                                //This is the list of objects and function for the adding

                                MethodInfo Addmethod = propertyValue.GetType().GetMethod("Add");

                                //THis is the type of object and the method we need plus the segment ID
                                Type t = propertyValue.GetType().GetGenericArguments()[0];
                                MethodInfo ediMethod = t.GetMethod("FromEDIString", internalFlags);
                                string segID = t.Name.Replace("Seg", "");

                                //Start looping through the segments
                                while (strSegments[p].StartsWith(segID) || IsGeneric)
                                {
                                    //Create an instance of the list object
                                    var tmp = t.GetConstructor(new Type[] {}).Invoke(new object[] {});
                                    //Invoke the EDI string parser
                                    ediMethod.Invoke(tmp, new object[] {strSegments[p], seperators});
                                    //Add the new item to the list.
                                    Addmethod.Invoke(propertyValue, new object[] {tmp});
                                    p++;
                                    if ((p >= strSegments.Count()) || (IsGeneric && (p >= strSegments.Count() - 1 ))) 
                                        break;
                                }
                            }
                            else
                            {
                                //This didn't work so good....  but we are not loop through the segments of the base type..
                                if (propertyValue.GetType().BaseType == typeof (EDIBase))
                                {
                                    string inputValue = String.Join("" + seperators.Segment, strSegments, p,
                                                                    strSegments.Count() - 1);
                                    MethodInfo ediMethod = propertyValue.GetType()
                                                                        .GetMethod("FromEDIString", internalFlags);
                                    //This should always do the later but for testing have it here...
                                    ediMethod.Invoke(propertyValue, new object[] {inputValue, seperators});
                                    p = (strSegments.Count() - 1);
                                }
                                else
                                {
                                    //Grab the function we are going to use
                                    //                        Type[] paramTypes = _countMethodParams.Select(p => p.GetType()).ToArray();
                                    MethodInfo method = propertyValue.GetType()
                                                                     .GetMethod("FromEDIString", internalFlags);
                                    //Invoke the function of that class on the class
                                    //strSegments.Add(method.Invoke(propertyValue, new object[] { '*' }).ToString());
                                    method.Invoke(propertyValue, new object[] {strSegments[p], seperators});
                                    p++;
                                }
                            }
                        }
                        else
                        {
                            //If EDI file we are reading has an extra segment that is not part of the object
                            //then we need to skip it and go on to the next one, while keeping our place 
                            //in the current file to properly unmarshal the rest of the file
                            if (!IsValidSegment(strSegments[p], objSegments, objPntr))
                            {
                                p++;
                                objPntr--;
                            }
   

                        }
                    }
                }

                if (p > strSegments.Count() - 1)
                    break;
            }
        }


        /// <summary>
        /// Try to determine if this segment is coming up anytime soon.
        /// </summary>
        /// <param name="segment"></param>
        /// <param name="pointer"></param>
        /// <returns></returns>
        internal bool IsValidSegment(string segment, List<string> objSegments, int pntr)
        {
            //Does this segmentID exists in the objsegments from the current point.
            for (int i = pntr; i < objSegments.Count; i++)
            {
                if (segment.StartsWith(objSegments[i]))
                    return true;
            }
            return false;
        }

        internal List<String> GetAvailableSegments()
        {
            List<string> rtnVal = new List<string>();
            foreach (PropertyInfo propertyInfo in GetType().GetProperties())
            {
                if (propertyInfo.CanRead)
                {
                    rtnVal.Add(GetSegmentID(propertyInfo));
                }
            }
            return rtnVal;
        }

        internal string GetSegmentID(PropertyInfo pInfo)
        {
            if (pInfo.CanRead)
            {
                Attribute[] attrs = Attribute.GetCustomAttributes(pInfo);
                if (attrs.Any(x => x.GetType() == typeof (EDILoop)))
                {
                    EDILoop currentLoop = ((EDILoop)attrs.FirstOrDefault(z => z.GetType() == typeof(EDILoop)));
                    return currentLoop.GetFormat();
                }
                string segmentID = pInfo.PropertyType.Name.Replace("Seg", "");
                if (segmentID.ToUpper().StartsWith("LIST"))
                {
                    segmentID = pInfo.PropertyType.GetGenericArguments()[0].Name.Replace("Seg", "");
                }
                return segmentID;
            }
            return "";
        }


        /// <summary>
        /// called by outside members
        /// </summary>
        /// <returns></returns>
        public string ToEDIFile()
        {
            return ToEDIString(originalDelims) + originalDelims.Segment;
        }

        public string ToEDIFile(char segment, char element, char subelement, char repitition)
        {
            EDIDelim currDelim;
            currDelim.Element = element;
            currDelim.Segment = segment;
            currDelim.Subelement = subelement;
            currDelim.Repitition = repitition;

            return ToEDIString(currDelim) + currDelim.Segment;

        }


        //TODO: Determine how to pass delimiters easily.
        internal string ToEDIString(EDIDelim seperators)
        {
            //Always set these values so that we ensure file is consistent.
            SetISADelimiters(seperators.Repitition, seperators.Subelement);
            List<string> strSegments = new List<string>();
            foreach (PropertyInfo propertyInfo in GetType().GetProperties())
            {
                if (propertyInfo.CanRead)
                {

                    //Foreach loop add since it is a list the "FromEDIString"
                    object propertyValue = propertyInfo.GetValue(this, null);

                    if (propertyValue != null)
                    {
                        if (IsPropertyACollection(propertyInfo))
                        {
                            //loop through it.
                            var collection = (IEnumerable)propertyInfo.GetValue(this, null);
                            foreach (var item in collection)
                            {
                                MethodInfo method = item.GetType().GetMethod("ToEDIString", internalFlags);
                                //Invoke the function of that class on the class
                                strSegments.Add(method.Invoke(item, new object[] { seperators }).ToString());
                            }
                        }
                        else
                        {
                            //Grab the function we are going to use
                            MethodInfo method = propertyValue.GetType().GetMethod("ToEDIString", internalFlags);
                            //Invoke the function of that class on the class
                            strSegments.Add(method.Invoke(propertyValue, new object[] { seperators }).ToString());
                        }
                    }
                }
            }

            return String.Join(("" + seperators.Segment), strSegments);
        }


        internal void SetISADelimiters(char repitition, char subelement)
        {
            foreach (PropertyInfo propertyInfo in GetType().GetProperties())
            {
                if (propertyInfo.CanRead)
                {

                    if (propertyInfo.PropertyType == typeof(ISASeg))
                    {
                        object isaValue = propertyInfo.GetValue(this, null);

                        PropertyInfo _propertyInfo = isaValue.GetType().GetProperty("ISA11RepetitionDelim");
                        _propertyInfo.SetValue(isaValue, repitition, null);
                        _propertyInfo = isaValue.GetType().GetProperty("ISA16SubElementDelim");
                        _propertyInfo.SetValue(isaValue, subelement, null);
                        break;
                    }
                }
            }



        }


        /// <summary>
        /// This will get segment count for SE
        /// </summary>
        /// <returns></returns>
        public int GetSegmentCount()
        {
            int rtnVal = 0;
            foreach (PropertyInfo propertyInfo in GetType().GetProperties())
            {

                if (propertyInfo.CanRead)
                {
                    object propertyValue = propertyInfo.GetValue(this, null);
                    if (propertyValue != null)
                    {

                        //System.Diagnostics.Debug.WriteLine(propertyInfo.Name);
                       // string s = propertyInfo.Name;
                        if (IsPropertyACollection(propertyInfo))
                        {
                            //This is simple collection
                            var collection = (IEnumerable<object>)propertyInfo.GetValue(this, null);
                            //if base is EDIBase then 
                            bool recursiveCount = false;
                            if (collection.Count() > 0)
                            {
                                recursiveCount = collection.FirstOrDefault().GetType().BaseType == typeof(EDIBase);

                                if (recursiveCount)
                                {
                                    foreach (var item in collection)
                                    {
                                        MethodInfo method = item.GetType().GetMethod("GetSegmentCount");
                                        //Invoke the function of that class on the class
                                        rtnVal += (int)method.Invoke(item, new object[] { });
                                       // System.Diagnostics.Debug.WriteLine(propertyInfo.Name + " (from recursive) + " + rtnVal);
                                    }
                                }
                                else
                                {
                                    //if base is segmentbase
                                    rtnVal += collection.Count();
                                    //System.Diagnostics.Debug.WriteLine(propertyInfo.Name + " + " + collection.Count());
                                }


                            }

                        }
                        else
                        {
                            if (propertyInfo.PropertyType.BaseType == typeof(SegmentBase))
                            {
                                //System.Diagnostics.Debug.WriteLine(propertyInfo.Name + " + 1");
                                rtnVal++;
                            }
                            //This will catch the EDILoop that we do as a single instance
                            // for HIPAA readability.
                            if (propertyInfo.PropertyType.BaseType == typeof(EDIBase))
                            {
                                var baseValues = propertyInfo.GetValue(this, null);
                                MethodInfo method = baseValues.GetType().GetMethod("GetSegmentCount");
                                //Invoke the function of that class on the class
                                rtnVal += (int)method.Invoke(baseValues, new object[] { });
                              //  System.Diagnostics.Debug.WriteLine(propertyInfo.Name + " (from EDIBase) + " + rtnVal);

                            }

                            //System.Diagnostics.Debug.WriteLine(propertyInfo.Name + " end");
                        }
                    }

                }
            }
            return rtnVal;
        }


        public bool IsPropertyACollection(PropertyInfo property)
        {
            //Exclude string type as they are really char[]
            if (property.PropertyType == typeof(String))
                return false;
            return property.PropertyType.GetInterface(typeof(IEnumerable<>).FullName) != null;
        } 
    }
}


