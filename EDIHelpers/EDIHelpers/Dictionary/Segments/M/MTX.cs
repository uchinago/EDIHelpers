using EDIHelpers.Attributes;

namespace EDIHelpers.Dictionary.Segments
{
    public class MTXSeg : SegmentBase
    {
        public MTXSeg()
            : base("MTX")
        {

        }
        [EDILength(3)]
        public string MTX01_NoteCode { get; set; }

        public string MTX02_MSG { get; set; }
        public string MTX03_MSG { get; set; }
        /// <summary>
        /// AA = Advance the specified # of lines before print
        /// AT = Advance 3 lines before print
        /// DS = Advance 2 lines before print
        /// LC = Line Continuation
        /// NP = Advance next page before print
        /// NS = no advance
        /// SS = Advance to new line before print
        /// </summary>
        [EDILength(2)]
        public string MTX04_CarriageControlCode { get; set; }
        public int? MTX05_AdvanceLines { get; set; }
        public string MTX06_LanguageCode { get; set; }

    }
}