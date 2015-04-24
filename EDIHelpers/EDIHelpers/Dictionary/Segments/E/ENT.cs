namespace EDIHelpers.Dictionary.Segments
{
    public class ENTSeg : SegmentBase
    {
        public ENTSeg()
            : base("ENT")
        {

        }
        public int? ENT01_AssignedNumber { get; set; }
        public string ENT02_EntityID { get; set; }
        public string ENT03_CodeQualifier { get; set; }
        public string ENT04_Code { get; set; }
        public string ENT05_EntityID { get; set; }
        public string ENT06_IDQualifier { get; set; }
        public string ENT07_Identifier { get; set; }
        public string ENT08_ReferenceQual { get; set; }
        public string ENT09_Reference { get; set; }
    }
}