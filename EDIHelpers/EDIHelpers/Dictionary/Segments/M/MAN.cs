namespace EDIHelpers.Dictionary.Segments
{
    public class MANSeg : SegmentBase
    {
        public MANSeg()
            : base("MAN")
        {

        }
        public string MAN01_Qualifier { get; set; }
        public string MAN02_MarksAndNumber { get; set; }
        public string MAN03_MarksAndNumber { get; set; }
        public string MAN04_QUalifier { get; set; }
        public string MAN05_MarksAndNumber { get; set; }
        public string MAN06_MarksAndNumber { get; set; }
   
    }
}