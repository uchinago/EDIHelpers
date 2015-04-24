using System.Collections.Generic;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.HIPAA.X837
{
    /// <summary>
    /// HL03 = 22
    /// </summary>
    public class LoopSubscriber : EDIBase
    {

        public HLSeg HL { get; set; }
        public SBRSeg SBR { get; set; }
        /// <summary>
        /// Rarely used
        /// </summary>
        public PATSeg PAT { get; set; }

        [EDILoop("NM1", 1, "", 0, new[] { "NM1", "HL", "CLM" })]
        public LoopPatient Subscriber { get; set; }

        [EDILoop("NM1", 1, "", 0, new[] { "HL", "CLM" })]
        public Loop2010Simple Payer { get; set; }

        //Claim Information goes here...


        [EDILoop("HL", 3, "23")]
        public List<LoopDependent> Dependents { get; set; }

    }
}