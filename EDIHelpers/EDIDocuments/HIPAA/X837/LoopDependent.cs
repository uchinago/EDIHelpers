using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.HIPAA.X837
{
    /// <summary>
    /// HL03 = 23
    /// </summary>
    public class LoopDependent : EDIBase
    {

        public HLSeg HL { get; set; }
        public PATSeg PAT { get; set; }

        [EDILoop("NM1", 1, "", 0, "CLM")]
        public LoopPatient Patient { get; set; }

        //Claim Information goes here...



    }
}