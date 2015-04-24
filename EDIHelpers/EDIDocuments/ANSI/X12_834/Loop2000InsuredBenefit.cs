using System.Collections.Generic;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.ANSI.X12_834
{
    public class Loop2000InsuredBenefit: EDIBase
    {

        public INSSeg INS { get; set; }
        public List<REFSeg> REF { get; set; }
        public List<DTPSeg> DTP { get; set; }

        [EDILoop("NM1", 0, "", 0, new[] {"DSB", "HD", "LC", "FSA", "RP", "LS"})]
        public List<Loop2100Name> L2100 { get; set; }
        
        //L2200DiabilityINformation
        [EDILoop("DSB", 0, "", 0, new[] { "HD", "LC", "FSA", "RP", "LS" })]
        public List<Loop2200Disability> L2200 { get; set; }

        [EDILoop("HD", 0, "", 0, new[] { "LC", "FSA", "RP", "LS" })]
        public List<Loop2300HealthCoverage> L2300 { get; set; }
        [EDILoop("LC", 0, "", 0, new[] { "FSA", "RP", "LS" })]
        public List<Loop2400LifeCoverage> L2400 { get; set; }
        [EDILoop("FSA", 0, "", 0, new[] { "RP", "LS" })]
        public List<Loop2500FSA> L2500 { get; set; }
        [EDILoop("RP", 0, "", 0, new[] { "LS" })]
        public List<Loop2600RetirementProduct> L2600 { get; set; }
        [EDILoop("LS", 0)]
        public List<LoopLS834> LS { get; set; } 
    }
}