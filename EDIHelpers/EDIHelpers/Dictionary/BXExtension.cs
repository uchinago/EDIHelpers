using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using EDIHelpers.Attributes;
using EDIHelpers.Enums;
using EDIHelpers.Helpers;

namespace EDIHelpers.Dictionary
{
    public static class BXExtension
    {

        /// <summary>
        /// Call this with about the first 175 characters.  ISA contains 106 so the extra is just safety.
        /// </summary>
        /// <param name="original"></param>
        /// <returns></returns>

        public static EDIDelim GetFileDelimiters(this string original)
        {
            EDIDelim rtnVal = new EDIDelim();
            rtnVal.Element = original[3];
            rtnVal.Segment = original[105];
            rtnVal.Subelement = original[104];
            rtnVal.Repitition = original[82];
            return rtnVal;
        }

        public static string ToEDIDTP(this object original, string format = "D8")
        {
            switch (format)
            {
                case "TM":
                    return Convert.ToDateTime(original).ToString("HHmm");
                case "TMS":
                    return Convert.ToDateTime(original).ToString("HHmmfff");
                case "RD8":
                    return Convert.ToDateTime(original).ToString("yyyyMMdd") + "-" + Convert.ToDateTime(original).ToString("yyyyMMdd");
                case "D6":
                    return Convert.ToDateTime(original).ToString("yyMMdd");
                    break;
                default: //D8 is the default
                    return Convert.ToDateTime(original).ToString("yyyyMMdd");
            }
        }

        /// <summary>
        /// Designed for Dates only...  try not to use it on time fields...
        /// </summary>
        /// <param name="original"></param>
        /// <returns></returns>
        public static DateTime FromEDIDate(this string original, bool getFirstDate = true)
        {
            switch (original.SafeTrim().Length)
            {
                case 6:
                    return DateTime.ParseExact(original.SafeTrim(), "yyMMdd", CultureInfo.InvariantCulture);
                case 8:
                    return DateTime.ParseExact(original.SafeTrim(), "yyyyMMdd", CultureInfo.InvariantCulture);
                case 17: return DateTime.ParseExact(getFirstDate ? original.SafeSubstring(0,8) : original.SafeSubstring(9 , 8), "yyyyMMdd", CultureInfo.InvariantCulture);
                default: return DateTime.ParseExact(original.SafeSubstring(0, 8), "yyyyMMdd", CultureInfo.InvariantCulture);
            }
        }


        public static Type GetEnumeratedType<T>(this IEnumerable<T> _)
        {
            return typeof(T);
        }

        public static T GetNewObject<T>()
        {
            try
            {
                return (T)typeof(T).GetConstructor(new Type[] { }).Invoke(new object[] { });
            }
            catch
            {
                return default(T);
            }
        }



        public static List<string> TransactionSplit(this string edi, EDILoop loopInfo, EDIDelim delims)
        {

            if (String.IsNullOrWhiteSpace(loopInfo.GetSelectionValue()))
            {
                if (String.IsNullOrWhiteSpace(loopInfo.GetIgnoreStartID()))
                    return edi.TransactionSplit(loopInfo.GetSplitFormat(), delims.Segment);
                return edi.DoTransactionSplit(loopInfo, delims);
            }
            return edi.LoopSplit(loopInfo, delims);
        }



        public static List<string> DoTransactionSplit(this string edi, EDILoop loopInfo, EDIDelim seperators)
        {
            List<string> rtnVal = new List<string>();
            
            string[] segments = edi.Split(seperators.Segment);

            List<string> tmp = new List<string>();

            bool doCheck = true;
            int startSeg = 0;
            int endSeg = 0;

            //assumption is that this will be called when the first segment meets the initial criteria
            tmp.Add(segments[0]);
            for (int i = 1; i < segments.Count(); i++)
            {
                if (segments[i].StartsWith(loopInfo.GetFormat()) && doCheck)
                {
                    rtnVal.Add(string.Join("" + seperators.Segment, tmp)); 
                    tmp.Clear();
                }
                if (segments[i].StartsWith(loopInfo.GetIgnoreStartID()))
                {
                    doCheck = false;
                }
                if (segments[i].StartsWith(loopInfo.GetIgnoreEndID()))
                {
                    doCheck = true;
                }
                tmp.Add(segments[i]);
            }
            if (tmp.Count > 0)
                rtnVal.Add(string.Join("" + seperators.Segment, tmp)); 
            return rtnVal;
        }




        /// <summary>
        /// This will split to variouse things like
        /// split to ALL 
        ///    ST-SE loops
        ///    GS-GE Loops
        /// </summary>
        /// <param name="edi"></param>
        /// <param name="transactionID"></param>
        /// <param name="segmentSep"></param>
        /// <returns></returns>
        public static List<string> TransactionSplit(this string edi, string transactionID, char segmentSep)
        {
            List<string> rtnVal = new List<string>();
            int x = -1;
            int y = 0;
            do
            {
                //Need to look at adding the element seperator to avoid splitting ST* and STC*
                x = edi.IndexOf(segmentSep + transactionID, y);
                if (x > -1)
                {
                    rtnVal.Add(edi.Substring(y, (x - y + 1)));
                    y = x + 1;
                }

            } while ((x >= 0));
            rtnVal.Add(edi.Substring(y));

            return rtnVal;
        }


        /// <summary>
        /// THis is to split the HL loops appropriately
        /// </summary>
        /// <param name="edi"></param>
        /// <param name="loopID"></param>
        /// <param name="position"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static List<String> LoopSplit(this string edi, EDILoop loopInfo, EDIDelim  seperator)
        {
            string[] segments = edi.Split(seperator.Segment);
            bool inLoop = false;
            List<string> loops = new List<string>();
            List<string> tmp = new List<string>();

            foreach (string segment in segments)
            {
                if (segment.StartsWith(loopInfo.GetFormat()))
                {
                    string[] elements = segment.Split(seperator.Element);
                    if (elements[loopInfo.GetPosition()].Equals(loopInfo.GetSelectionValue()))
                    {
                        if (tmp.Count > 0)
                        {
                            loops.Add(String.Join("" + seperator.Segment, tmp));
                            tmp.Clear();
                        }
                        inLoop = true;
                    }
                }
                if (inLoop)
                    tmp.Add(segment);
            }
            if (tmp.Count > 0)
                loops.Add(String.Join("" + seperator.Segment, tmp));
            return loops;
        }





        public static string DTMFormat(this string original)
        {
            switch (original.ToUpper())
            {
                case "YMM":
                    return "yyyyMMM-MMM";
                case "D6":
                    return "yyMMdd";
                case "D8":
                    return "yyyyMMdd";
                case "TM":
                    return "HHmm";
                case "TS":
                    return "HHmmss";
                case "TMS":
                    return "HHmmfff";
                default:
                    return "yyyyMMdd";
            }
        }
    }
}
