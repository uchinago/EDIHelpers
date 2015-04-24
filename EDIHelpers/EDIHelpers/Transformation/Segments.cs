using System;
using System.Collections.Generic;
using EDIHelpers.Dictionary.Segments;

namespace EDIHelpers.Transformation
{
    public static class Segments
    {
        /// <summary>
        /// THis is when we convert the request to response
        /// </summary>
        /// <param name="original"></param>
        /// <returns></returns>
        public static ISASeg SwapSenderRcvr(this ISASeg original)
        {
            ISASeg rtnVal = original.Clone();
            rtnVal.ISA05SenderQualifier = original.ISA07ReceiverQualifier;
            rtnVal.ISA06SenderID = original.ISA08ReceiverID;
            rtnVal.ISA07ReceiverQualifier = original.ISA05SenderQualifier;
            rtnVal.ISA08ReceiverID = original.ISA06SenderID;
            return rtnVal;
        }

        /// <summary>
        /// THis is when we convert the request to response
        /// </summary>
        /// <param name="original"></param>
        /// <param name="GS01"></param>
        /// <returns></returns>
        public static GSSeg SwapSenderRcvr(this GSSeg original, string GS01 = null)
        {
            GSSeg rtnVal = original.Clone();
            rtnVal.GS02SenderID = original.GS03ReceiverID;
            rtnVal.GS03ReceiverID = original.GS02SenderID;
            if (!String.IsNullOrWhiteSpace(GS01))
                rtnVal.GS01GroupID = GS01;
            return rtnVal;
        }


        /// <summary>
        /// THis is designed to take an input list and change the TRN01 "1" to value "2"
        /// </summary>
        /// <param name="original"></param>
        /// <returns></returns>
        public static List<TRNSeg> ConvertTRN(this List<TRNSeg> original)
        {
            if (original == null)
                return null;
            List<TRNSeg> rtnVal = new List<TRNSeg>();
            foreach (TRNSeg t1 in original)
            {
                rtnVal.Add(t1.Clone());
                rtnVal[rtnVal.Count - 1].TRN01_TraceType = "2";
            }
            return rtnVal;
        }


        /// <summary>
        /// Consolidate the logic to this so it makes a TRN here..
        /// </summary>
        /// <param name="BPID"></param>
        /// <returns></returns>
        public static TRNSeg CreateTRN(this string BPID, string companyID)
        {
            TRNSeg rtnVal = new TRNSeg();
            rtnVal.TRN01_TraceType = "1";
            rtnVal.TRN02_ReferenceID = BPID;
            rtnVal.TRN03_CompanyId = companyID.PadRight(10);
            return rtnVal;
        }
    }
}
