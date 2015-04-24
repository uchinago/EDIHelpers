using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIHelpers.Dictionary;
using EDIHelpers.Enums;
using EDIHelpers.Helpers;

namespace EDIHelpers.Splitter
{
    public static class SplitExt
    {


        /// <summary>
        /// Expectation is that a single ISA-IEA come to this function
        /// </summary>
        /// <param name="ediFile"></param>
        /// <returns></returns>
        public static List<String> SplitByGS(string ediFile)
        {
            EDIDelim currDelim = ediFile.SafeSubstring(0, 175).GetFileDelimiters();
            List<string> rtnVal = new List<string>();
            string[] strSegments = ediFile.Split(new char[] { currDelim.Segment }, StringSplitOptions.RemoveEmptyEntries);
            List<String> holder = new List<string>();
            int[] pntrs = strSegments.FindAllIndexOf(a => a.StartsWith("GS"));
            int[] gePntrs = strSegments.FindAllIndexOf(a => a.StartsWith("GE"));

            for (int p = 0; p < pntrs.Length; p++)
            {
                holder.Add(strSegments[0]);
                holder.AddRange(strSegments.GetRange(pntrs[p], gePntrs[p]));
                holder.Add(strSegments[strSegments.Count() - 1]);
                rtnVal.Add(String.Join(("" + currDelim.Segment), holder) + currDelim.Segment);
                holder.Clear();
            }
            return rtnVal;
        }


        /// <summary>
        /// Expectation is that the file comes in with a single ISA/GS looping
        /// </summary>
        /// <param name="ediFile"></param>
        /// <returns></returns>
        public static List<String> SplitByST(string ediFile)
        {
            EDIDelim currDelim = ediFile.SafeSubstring(0, 175).GetFileDelimiters();
            string[] strSegments = ediFile.Split(new char[] { currDelim.Segment }, StringSplitOptions.RemoveEmptyEntries);
            List<string> rtnVal = new List<string>();
            int[] pntrs = strSegments.FindAllIndexOf(a => a.StartsWith("ST"));
            int[] sePntrs = strSegments.FindAllIndexOf(a => a.StartsWith("SE"));
            List<String> holder = new List<string>();
            for (int p = 0; p < pntrs.Length; p++)
            {
                holder.Add(strSegments[0]);
                holder.Add(strSegments[1]);
                holder.AddRange(strSegments.GetRange(pntrs[p], sePntrs[p]));
                holder.Add(strSegments[strSegments.Count() - 2]);
                holder.Add(strSegments[strSegments.Count() - 1]);
                rtnVal.Add(String.Join(("" + currDelim.Segment), holder) + currDelim.Segment);
                holder.Clear();
            }
            return rtnVal;

        }

    }
}
