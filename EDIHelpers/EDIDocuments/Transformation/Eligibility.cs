using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIDocuments.ANSI;
using EDIDocuments.ANSI.X12_270;
using EDIDocuments.ANSI.X12_271;
using EDIDocuments.HIPAA;
using EDIDocuments.HIPAA.X270;
using EDIDocuments.HIPAA.X271;
using EDIHelpers.Dictionary.Segments;
using EDIHelpers.Enums;
using EDIHelpers.Transformation;
using HIPAA2000A = EDIDocuments.HIPAA.X270.Source270;
using Loop2000 = EDIDocuments.ANSI.X12_270.Loop2000;
using Loop2100 = EDIDocuments.ANSI.X12_271.Loop2100;
using Loop2110 = EDIDocuments.ANSI.X12_271.Loop2110;

namespace EDIDocuments.Transformation
{
    public static class Eligibility
    {

        #region HIPAA Conversions 270 to 271

        /// <summary>
        /// THis will convert the 270 document to the 271 for all matching elements
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public static HIPAA271 CreateResponse(this HIPAA270 request)
        {
            HIPAA271 rtnVal = new HIPAA271();
            rtnVal.originalDelims = request.originalDelims; //THis is important. or we can create it to set our own values..
            rtnVal.ISA = request.ISA.SwapSenderRcvr(); //Because we are switching values we must clone instead of reference copy it.
            rtnVal.IEA = request.IEA;
            rtnVal.GSLoop = new List<Group271>();
            for (int g = 0; g < request.GSLoop.Count; g++)
            {
                rtnVal.GSLoop.Add(new Group271());
                //Copy the segment and Modify GS01 appropriately
                rtnVal.GSLoop[g].GS = request.GSLoop[g].GS.SwapSenderRcvr("HB");

                rtnVal.GSLoop[g].GE = request.GSLoop[g].GE;

                //Create the next looping structure
                rtnVal.GSLoop[g].STLoops = new List<Transaction271>();
                for (int s = 0; s < request.GSLoop[g].STLoops.Count; s++)
                {
                    //Add a new one, then set it to old and convert the ST01 to 271
                    rtnVal.GSLoop[g].STLoops.Add(new Transaction271());
                    rtnVal.GSLoop[g].STLoops[s].ST = request.GSLoop[g].STLoops[s].ST.Clone();
                    rtnVal.GSLoop[g].STLoops[s].ST.ST01TransactionID = "271";

                    rtnVal.GSLoop[g].STLoops[s].SE = request.GSLoop[g].STLoops[s].SE;
                    //Explicitly copy the segments
                    rtnVal.GSLoop[g].STLoops[s].BHT = request.GSLoop[g].STLoops[s].BHT.Clone();
                    rtnVal.GSLoop[g].STLoops[s].BHT.Bht02PurposeCode = "11";
                    rtnVal.GSLoop[g].STLoops[s].BHT.Bht06TransType = null;


                    rtnVal.GSLoop[g].STLoops[s].Source = new List<Source271>();
                    for (int a = 0; a < request.GSLoop[g].STLoops[s].Source.Count; a++)
                    {
                        rtnVal.GSLoop[g].STLoops[s].Source.Add(new Source271());
                        rtnVal.GSLoop[g].STLoops[s].Source[a].HL = request.GSLoop[g].STLoops[s].Source[a].HL;
                        rtnVal.GSLoop[g].STLoops[s].Source[a].NM1 = request.GSLoop[g].STLoops[s].Source[a].NM1;



                        rtnVal.GSLoop[g].STLoops[s].Source[a].Receiver = new List<Receiver271>();
                        for (int b = 0; b < request.GSLoop[g].STLoops[s].Source[a].Receiver.Count; b++)
                        {
                            rtnVal.GSLoop[g].STLoops[s].Source[a].Receiver.Add(new Receiver271());
                            rtnVal.GSLoop[g].STLoops[s].Source[a].Receiver[b].HL =
                                request.GSLoop[g].STLoops[s].Source[a].Receiver[b].HL;
                            //TODO: probably want to check for nulls?  but setting to null might be ok.
                            rtnVal.GSLoop[g].STLoops[s].Source[a].Receiver[b].NM1 = request.GSLoop[g].STLoops[s].Source[a].Receiver[b].NM1;
                            rtnVal.GSLoop[g].STLoops[s].Source[a].Receiver[b].N3 = request.GSLoop[g].STLoops[s].Source[a].Receiver[b].N3;
                            rtnVal.GSLoop[g].STLoops[s].Source[a].Receiver[b].N4 = request.GSLoop[g].STLoops[s].Source[a].Receiver[b].N4;
                            rtnVal.GSLoop[g].STLoops[s].Source[a].Receiver[b].PRV = request.GSLoop[g].STLoops[s].Source[a].Receiver[b].PRV;

                            rtnVal.GSLoop[g].STLoops[s].Source[a].Receiver[b].REF =
                                request.GSLoop[g].STLoops[s].Source[a].Receiver[b].REF;

                            rtnVal.GSLoop[g].STLoops[s].Source[a].Receiver[b].Subscribers = new List<Subscriber271>();
                            for (int c = 0; c < request.GSLoop[g].STLoops[s].Source[a].Receiver[b].Subscribers.Count; c++)
                            {
                                rtnVal.GSLoop[g].STLoops[s].Source[a].Receiver[b].Subscribers.Add(request.GSLoop[g].STLoops[s].Source[a].Receiver[b].Subscribers[c].ConvertSubscriber());
                            }
                        }
                    }

                }
            }

            return rtnVal;
        }

        /// <summary>
        /// Converts inbound type to correlated outboundtype
        /// You must adjust data that does not convert based on implementation guide.
        /// </summary>
        /// <param name="original"></param>
        /// <returns></returns>
        public static Dependent271 ConvertDependent(this Dependent270 original)
        {
            if (original == null)
                return null;
            Dependent271 rtnVal = new Dependent271();
            rtnVal.HL = original.HL;
            rtnVal.TRN = original.TRN.ConvertTRN();
            rtnVal.NM1 = original.NM1;
            //rtnVal.REF = original.REF;
            rtnVal.N3 = original.N3;
            rtnVal.N4 = original.N4;
            //rtnVal.PRV = original.PRV;
            rtnVal.DMG = original.DMG;
            //rtnVal.DTP = original.DTP;
            //rtnVal.HI = original.HI;
            //rtnVal.INS = original.INS;
            if (original.EQ != null && original.EQ.Any())
            {
                rtnVal.EB = new List<Benefits271>();
            }
            return rtnVal;
        }
        /// <summary>
        /// Converts inbound type to correlated outboundtype
        /// You must adjust data that does not convert based on implementation guide.
        /// </summary>
        /// <param name="original"></param>
        /// <returns></returns>
        public static Subscriber271 ConvertSubscriber(this Subscriber270 original)
        {
            if (original == null)
                return null;
            Subscriber271 rtnVal = new Subscriber271();
            rtnVal.HL = original.HL;
            rtnVal.TRN = original.TRN.ConvertTRN();
            
            rtnVal.NM1 = original.NM1;
            //rtnVal.REF = original.REF;
            rtnVal.N3 = original.N3;
            rtnVal.N4 = original.N4;
            //rtnVal.PRV = original.PRV;
            rtnVal.DMG = original.DMG;
            //rtnVal.DTP = original.DTP;
            //rtnVal.HI = original.HI;
            //rtnVal.INS = original.INS;
            //When do we need this or not.

            //if we have a question then create the benefits loop
            if (original.EQ != null && original.EQ.Any())
            {
                rtnVal.EB = new List<Benefits271>();
            }

            if (original.Dependents != null && original.Dependents.Any())
            {
                rtnVal.Dependents = new List<Dependent271>();
                for (int i = 0; i < original.Dependents.Count; i++)
                {
                    rtnVal.Dependents.Add(original.Dependents[i].ConvertDependent());
                }
            }

            return rtnVal;
        }

        #endregion





        #region ANSI 270 -> 271 conversions


        /// <summary>
        /// THis will convert the 270 document to the 271 for all matching elements
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public static EDI271 CreateResponse(this EDI270 request)
        {
            EDI271 rtnVal = new EDI271();
            rtnVal.originalDelims = request.originalDelims; //THis is important. or we can create it to set our own values..
            rtnVal.ISA = request.ISA.SwapSenderRcvr();

            rtnVal.IEA = request.IEA;

            rtnVal.GSLoop = new List<GS271>();
            for (int g = 0; g < request.GSLoop.Count; g++)
            {
                rtnVal.GSLoop.Add(new GS271());
                rtnVal.GSLoop[g].GS = request.GSLoop[g].GS.SwapSenderRcvr("HB");

                rtnVal.GSLoop[g].GE = request.GSLoop[g].GE;


                rtnVal.GSLoop[g].STLoops = new List<ST271>();
                for (int i = 0; i < request.GSLoop[g].STLoops.Count; i++)
                {
                    rtnVal.GSLoop[g].STLoops.Add(new ST271());
                    rtnVal.GSLoop[g].STLoops[i].ST = request.GSLoop[g].STLoops[i].ST;
                    rtnVal.GSLoop[g].STLoops[i].ST.ST01TransactionID = "271";
                    rtnVal.GSLoop[g].STLoops[i].SE = request.GSLoop[g].STLoops[i].SE;

                    rtnVal.GSLoop[g].STLoops[i].BHT = request.GSLoop[g].STLoops[i].BHT;

                    rtnVal.GSLoop[g].STLoops[i].BHT.Bht02PurposeCode = "11";
                    //TODO: Do we need to change BHT06 for non hipaa transactions

                    rtnVal.GSLoop[g].STLoops[i].HL = new List<ANSI.X12_271.Loop2000>();
                    foreach (Loop2000 l2000 in request.GSLoop[g].STLoops[i].HL)
                    {
                        rtnVal.GSLoop[g].STLoops[i].HL.Add(l2000.ConvetHLLoop());
                    }
                }
            }
            return rtnVal;
        }

        /// <summary>
        /// This converts the 2000 Loop from 270 request to a 271 response
        /// </summary>
        /// <param name="original"></param>
        /// <returns></returns>
        public static ANSI.X12_271.Loop2000 ConvetHLLoop(this ANSI.X12_270.Loop2000 original)
        {
            ANSI.X12_271.Loop2000 rtnVal = new ANSI.X12_271.Loop2000();
            rtnVal.HL = original.HL;
            rtnVal.TRN = original.TRN;
            if (original.IndOrgName != null && original.IndOrgName.Any())
            {
                rtnVal.IndOrgName = new List<Loop2100>();
                foreach (ANSI.X12_270.Loop2100 oLoop2100 in original.IndOrgName)
                {
                    rtnVal.IndOrgName.Add(oLoop2100.ConvertL2100());
                }
            }
            return rtnVal;
        }
        /// <summary>
        /// Converts inbound type to correlated outboundtype
        /// You must adjust data that does not convert based on implementation guide.
        /// </summary>
        /// <param name="original"></param>
        /// <returns></returns>
        public static ANSI.X12_271.Loop2100 ConvertL2100(this ANSI.X12_270.Loop2100 original)
        {
            ANSI.X12_271.Loop2100 rtnVal = new ANSI.X12_271.Loop2100();
            rtnVal.NM1 = original.NM1;
            rtnVal.REF = original.REF;
            rtnVal.N3 = original.N3;
            rtnVal.N4 = original.N4;
            rtnVal.DMG = original.DMG;
            rtnVal.PRV = original.PRV;
            rtnVal.L2110 = new List<Loop2110>();
            return rtnVal;
        }

        #endregion
    }
}
