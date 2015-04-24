using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIDocuments.HIPAA;
using EDIDocuments.HIPAA.X276;
using EDIDocuments.HIPAA.X277;
using EDIHelpers.Dictionary.Segments;
using EDIHelpers.Transformation;
using LoopClaimStatusTracking = EDIDocuments.HIPAA.X277.LoopClaimStatusTracking;
using LoopServiceProvider = EDIDocuments.HIPAA.X277.LoopServiceProvider;

namespace EDIDocuments.Transformation
{
    public static class ClaimStatus
    {

        /// <summary>
        /// Convert an inbound 276 document to a outbound 277.
        /// You will then need to populate as needed.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public static HIPAA277 CreateResponse(this HIPAA276 request)
        {
            HIPAA277 rtnVal = new HIPAA277();
            rtnVal.originalDelims = request.originalDelims;
            rtnVal.ISA = request.ISA.SwapSenderRcvr(); //Because we are switching values we must clone instead of reference copy it.
            rtnVal.IEA = request.IEA;

            rtnVal.GSLoop = new List<Group277>();
            for (int g = 0; g < request.GSLoop.Count; g++)
            {
                rtnVal.GSLoop.Add(new Group277());
                //Copy the segment and Modify GS01 appropriately
                rtnVal.GSLoop[g].GS = request.GSLoop[g].GS.SwapSenderRcvr("HN");
                rtnVal.GSLoop[g].GE = request.GSLoop[g].GE;
                rtnVal.GSLoop[g].STLoops = new List<Transaction277>();

                for (int s = 0; s < request.GSLoop[g].STLoops.Count; s++)
                {
                    rtnVal.GSLoop[g].STLoops.Add(new Transaction277());
                    rtnVal.GSLoop[g].STLoops[s].ST = request.GSLoop[g].STLoops[s].ST.Clone();
                    rtnVal.GSLoop[g].STLoops[s].ST.ST01TransactionID = "277";

                    rtnVal.GSLoop[g].STLoops[s].SE = request.GSLoop[g].STLoops[s].SE;
                    //Explicitly copy the segments
                    rtnVal.GSLoop[g].STLoops[s].BHT = request.GSLoop[g].STLoops[s].BHT.Clone();
                    rtnVal.GSLoop[g].STLoops[s].BHT.Bht02PurposeCode = "08";
                    rtnVal.GSLoop[g].STLoops[s].BHT.Bht06TransType = "DG";

                    rtnVal.GSLoop[g].STLoops[s].Source = new List<LoopInfoSource277>();
                    for (int a = 0; a < request.GSLoop[g].STLoops[s].Source.Count; a++)
                    {
                        rtnVal.GSLoop[g].STLoops[s].Source.Add(new LoopInfoSource277());
                        rtnVal.GSLoop[g].STLoops[s].Source[a].HL = request.GSLoop[g].STLoops[s].Source[a].HL;
                        rtnVal.GSLoop[g].STLoops[s].Source[a].NM1 = request.GSLoop[g].STLoops[s].Source[a].NM1;



                        rtnVal.GSLoop[g].STLoops[s].Source[a].Receiver = new List<LoopInfoReceiver277>();
                        for (int b = 0; b < request.GSLoop[g].STLoops[s].Source[a].Receiver.Count; b++)
                        {
                            rtnVal.GSLoop[g].STLoops[s].Source[a].Receiver.Add(new LoopInfoReceiver277());
                            rtnVal.GSLoop[g].STLoops[s].Source[a].Receiver[b].HL =
                                request.GSLoop[g].STLoops[s].Source[a].Receiver[b].HL;
                            //TODO: probably want to check for nulls?  but setting to null might be ok.
                            rtnVal.GSLoop[g].STLoops[s].Source[a].Receiver[b].NM1 = request.GSLoop[g].STLoops[s].Source[a].Receiver[b].NM1;

                            rtnVal.GSLoop[g].STLoops[s].Source[a].Receiver[b].ServiceProvider = new List<LoopServiceProvider>();
                            for (int c = 0; c < request.GSLoop[g].STLoops[s].Source[a].Receiver[b].ServiceProvider.Count; c++)
                            {
                                rtnVal.GSLoop[g].STLoops[s].Source[a].Receiver[b].ServiceProvider.Add(new LoopServiceProvider());
                                rtnVal.GSLoop[g].STLoops[s].Source[a].Receiver[b].ServiceProvider[c].HL =
                                    request.GSLoop[g].STLoops[s].Source[a].Receiver[b].ServiceProvider[c].HL;

                                rtnVal.GSLoop[g].STLoops[s].Source[a].Receiver[b].ServiceProvider[c].NM1 =
                                    request.GSLoop[g].STLoops[s].Source[a].Receiver[b].ServiceProvider[c].NM1;

                                rtnVal.GSLoop[g].STLoops[s].Source[a].Receiver[b].ServiceProvider[c].Subscriber = new List<Subscriber277>();
                                for (int sp = 0; sp < request.GSLoop[g].STLoops[s].Source[a].Receiver[b].ServiceProvider[c].Subscriber.Count; sp++)
                                {
                                    rtnVal.GSLoop[g].STLoops[s].Source[a].Receiver[b].ServiceProvider[c].Subscriber.Add(request.GSLoop[g].STLoops[s].Source[a].Receiver[b].ServiceProvider[c].Subscriber[sp].ConvertSubscriber());    
                                }

                                
                            }
                        }
                    }




                }
            }


            return rtnVal;
        }

        /// <summary>
        /// Convert an inbound 276 subsciber loop to an outbound 277
        /// You must add the data differences depending on your implementation guide.
        /// </summary>
        /// <param name="original"></param>
        /// <returns></returns>
        public static Subscriber277 ConvertSubscriber(this Subscriber276 original)
        {
            if (original == null)
                return null;
            Subscriber277 rtnVal = new Subscriber277();
            rtnVal.HL = original.HL;
            rtnVal.NM1 = original.NM1;
            //Do not copy the TRN as this will be gotten with the request query data

            if (original.Dependent != null && original.Dependent.Any())
            {
                rtnVal.Dependent = new List<Dependent277>();
                for (int d = 0; d < original.Dependent.Count; d++)
                {
                    rtnVal.Dependent.Add(original.Dependent[d].ConvertDependent());
                }
            }

            return rtnVal;
        }
        /// <summary>
        /// Convert the inbound 276 dependent loop to and outbound 277
        /// You must add the data differences depending on your implementation guide.
        /// </summary>
        /// <param name="original"></param>
        /// <returns></returns>
        public static Dependent277 ConvertDependent(this Dependent276 original)
        {
            if (original == null)
                return null;
            Dependent277 rtnVal = new Dependent277();
            rtnVal.HL = original.HL;
            rtnVal.NM1 = original.NM1;
            return rtnVal;
        }
    }
}
