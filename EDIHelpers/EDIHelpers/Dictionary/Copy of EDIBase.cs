using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using BCI_HelperClasses;
using EDIHelpers.Attributes;
using EDIHelpers.Reflections;
using EDIHelpers.DataTypes;

namespace EDIHelpers.Dictionary
{
    
    public class EDIBase2
    {




        //Works with straight EDIBase and SegmentBase values but is hard coded for seperators...
        public void FromEDIString(string ediData, )
        {
            string[] strSegments = ediData.Split(new char[] { segmentSep }, StringSplitOptions.RemoveEmptyEntries);

            int p = 0;
            //TODO: How do we align the inbound to the object...  

            foreach (PropertyInfo propertyInfo in GetType().GetProperties())
            {

                if (propertyInfo.CanRead)
                {

                    Attribute[] attrs = Attribute.GetCustomAttributes(propertyInfo);

                    if (attrs.Any(x => x.GetType() == typeof(EDILoop)))
                    {

                        EDILoop currentLoop = ((EDILoop) attrs.FirstOrDefault(z => z.GetType() == typeof (EDILoop)));

                        //Check to see if the segment starts this way...
                        if (strSegments[p].StartsWith(currentLoop.GetFormat()))
                        {

                            //This should be the amount of Segments we need to group together in order to split properly.
                            int es = strSegments.Count() - p - currentLoop.GetEndSkip();

                            if (!String.IsNullOrWhiteSpace(currentLoop.GetAltSegmentID()))
                            {
                                for (int i = p + 1; i < strSegments.Count(); i++)
                                {
                                    if (strSegments[i].StartsWith(currentLoop.GetAltSegmentID()))
                                    {
                                        es = i - p;
                                        break;
                                    }
                                }
                            }

                            //We need to determine the end point of the alt ending if present.
                            List<string> loopValues =
                                String.Join("" + segmentSep, strSegments, p, es)
                                      .TransactionSplit(currentLoop, segmentSep);

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
                            MethodInfo Addmethod = propertyValue.GetType().GetMethod("Add");
                            Type t = propertyValue.GetType().GetGenericArguments()[0];
                            MethodInfo ediMethod = t.GetMethod("FromEDIString");

                            foreach (string lValues in loopValues)
                            {
                                var tmp = t.GetConstructor(new Type[] {}).Invoke(new object[] {});
                                //Invoke the EDI string parser
                                ediMethod.Invoke(tmp, new object[] {lValues, segmentSep});
                                //Add the new item to the list.
                                Addmethod.Invoke(propertyValue, new object[] {tmp});
                            }
                            p = strSegments.Count() - currentLoop.GetEndSkip();
                        }
                    }
                    else
                    {
                        //Handle single and list of simple segments.
                        string segmentID = propertyInfo.PropertyType.Name.Replace("Seg", "");
                         if (segmentID.ToUpper().StartsWith("LIST"))
                         {
                             segmentID = propertyInfo.PropertyType.GetGenericArguments()[0].Name.Replace("Seg", "");
                             //segmentID = propertyInfo.PropertyType.generictype[0].Name;

                         }
                        if (strSegments[p].StartsWith(segmentID))
                        {
                            //Actually Grab the class of what we are trying to do
                            object propertyValue = propertyInfo.GetValue(this, null);
                            if (propertyValue == null)
                            {
                                //How do we put this as the property value
                                ConstructorInfo ctor = propertyInfo.PropertyType.GetConstructor(System.Type.EmptyTypes);
                                object instance = ctor.Invoke(null);

                                propertyInfo.SetValue(this, Convert.ChangeType(instance, propertyInfo.PropertyType), null);
                                propertyValue = propertyInfo.GetValue(this, null);
                            }
                            //Collection of single objects
                            if (IsPropertyACollection(propertyInfo))
                            {
                                //This is the list of objects and function for the adding

                                MethodInfo Addmethod = propertyValue.GetType().GetMethod("Add");

                                //THis is the type of object and the method we need plus the segment ID
                                Type t = propertyValue.GetType().GetGenericArguments()[0];
                                MethodInfo ediMethod = t.GetMethod("FromEDIString", new Type[] {typeof (string)});
                                string segID = t.Name.Replace("Seg", "");

                                //Start looping through the segments
                                while (strSegments[p].StartsWith(segID))
                                {
                                    //Create an instance of the list object
                                    var tmp = t.GetConstructor(new Type[] {}).Invoke(new object[] {});
                                    //Invoke the EDI string parser
                                    ediMethod.Invoke(tmp, new object[] {strSegments[p]});
                                    //Add the new item to the list.
                                    Addmethod.Invoke(propertyValue, new object[] {tmp});
                                    p++;
                                    if (p >= strSegments.Count())
                                        break;
                                }

                            }
                            else
                            {

                                //This didn't work so good....  but we are not loop through the segments of the base type..
                                if (propertyValue.GetType().BaseType == typeof (EDIBase))
                                {
                                    string inputValue = String.Join("" + segmentSep, strSegments, p,
                                                                    strSegments.Count() - 1);
                                    MethodInfo ediMethod = propertyValue.GetType().GetMethod("FromEDIString");
                                    //This should always do the later but for testing have it here...
                                    ediMethod.Invoke(propertyValue, new object[] {inputValue, segmentSep});
                                    p = (strSegments.Count() - 1);
                                }
                                else
                                {
                                        //Grab the function we are going to use
                                        //                        Type[] paramTypes = _countMethodParams.Select(p => p.GetType()).ToArray();
                                        MethodInfo method = propertyValue.GetType()
                                                                         .GetMethod("FromEDIString",
                                                                                    new Type[] {typeof (string)});
                                        //Invoke the function of that class on the class
                                        //strSegments.Add(method.Invoke(propertyValue, new object[] { '*' }).ToString());
                                        method.Invoke(propertyValue, new object[] {strSegments[p]});
                                        p++;
                                }


                            }
                        }

                    }
                }

                if (p > strSegments.Count() - 1)
                    break;


            }
        }



        //TODO: Determine how to pass delimiters easily.
        public string ToEDIFileString()
        {
            List<string> strSegments = new List<string>();
            foreach (PropertyInfo propertyInfo in GetType().GetProperties())
            {
                if (propertyInfo.CanRead)
                {

                    //Foreach loop add since it is a list the "FromEDIString"
                    object propertyValue = propertyInfo.GetValue(this, null);

                    if (propertyValue != null)
                    {
                        //Works for simple segments...

                        if (IsPropertyACollection(propertyInfo))
                        {
                            //loop through it.
                            var collection = (IEnumerable) propertyInfo.GetValue(this, null);
                            foreach (var item in collection)
                            {
                                if (item.GetType().BaseType == typeof (EDIBase))
                                {
                                    MethodInfo method = item.GetType().GetMethod("ToEDIFileString");
                                    strSegments.Add(method.Invoke(item, new object[] {}).ToString());
                                }
                                else
                                {
                                    //This is for segments
                                    MethodInfo method = item.GetType().GetMethod("ToEDIString");
                                    //Invoke the function of that class on the class
                                    strSegments.Add(method.Invoke(item, new object[] {'*'}).ToString());

                                }
                            }
                        }
                        else
                        {
                            //Grab the function we are going to use
                            MethodInfo method = propertyValue.GetType().GetMethod("ToEDIString");
                            //Invoke the function of that class on the class
                            strSegments.Add(method.Invoke(propertyValue, new object[] {'*'}).ToString());
                        }
                    }
                }
            }

            return String.Join("~", strSegments);
        }
        public bool IsPropertyACollection(PropertyInfo property)
        {
            return property.PropertyType.GetInterface(typeof(IEnumerable<>).FullName) != null;
        } 
    }
}

