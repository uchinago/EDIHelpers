using System;

namespace EDIHelpers.Attributes
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
    public class EDILoop : System.Attribute
    {
        private string loopType;
        private int qualPosition;
        private int endSkip;
        private string _value;
        private string[] altSegmentID;
        private string ignoreStartSegID;
        private string ignoreEndSegID;
        private string splitLoopType;

        public EDILoop(string frmt): this(frmt, 1)
        {

        }

        public EDILoop(string frmt, int endSeg): this(frmt, 0, "", endSeg, "")
        {
            
        }

        public EDILoop(string frmt, int position = 1, string selectionQual = "")
            : this(frmt, position, selectionQual, 1, "")
        {

        }

        public EDILoop(string frmt, int position = 1, string selectionQual = "", int endSeg = 1): this(frmt, position, selectionQual, endSeg, "")
        {
            
        }

        public EDILoop(string frmt, int position = 1, string selectionQual = "", int endSeg = 1, string altEndSegmentID = "", string ignoreStartSeg = "", string ignoreEndSeg = "")
        {
            loopType = frmt;
            qualPosition = position;
            endSkip = endSeg;
            _value = selectionQual;
            if (String.IsNullOrWhiteSpace(altEndSegmentID))
                altSegmentID = new string[] { };
            else
            {
                altSegmentID = new[] { altEndSegmentID };
            }

            ignoreEndSegID = ignoreEndSeg;
            ignoreStartSegID = ignoreStartSeg;

        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="frmt">THis is the segment ID value ie GS, ST, HL, NM1</param>
        /// <param name="position">Element position for the qualifier</param>
        /// <param name="endSeg">number of segments to skip from the end</param>
        /// <param name="selectionQual">this is the HL03 or NM101</param>
        public EDILoop(string frmt, int position = 1, string selectionQual = "", int endSeg = 1, string[] altEndSegmentID = null, string ignoreStartSeg = "", string ignoreEndSeg = "")
        {
            loopType = frmt;
            qualPosition = position;
            endSkip = endSeg;
            _value = selectionQual;
            if (altEndSegmentID == null)
                altSegmentID = new string[]{};
            else
            {
                altSegmentID = altEndSegmentID;
            }
                
            ignoreEndSegID = ignoreEndSeg;
            ignoreStartSegID = ignoreStartSeg;

        }

        internal void AdjustFormat(char elementSep)
        {
            splitLoopType = loopType + elementSep;
        }


        public string GetFormat()
        {
            return loopType;
        }
        public string GetSplitFormat()
        {
            return splitLoopType;
        }

        public int GetPosition()
        {
            return qualPosition;
        }
        public string GetSelectionValue()
        {
            return _value;
        }
        public int GetEndSkip()
        {
            return endSkip;
        }
        public string[] GetAltSegmentID()
        {
            return altSegmentID;
        }
        public string GetIgnoreStartID()
        {
            return ignoreStartSegID;
        }
        public string GetIgnoreEndID()
        {
            return ignoreEndSegID;
        }

    }
}