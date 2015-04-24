using System.Collections.Generic;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.HIPAA.X834
{
    public class Loop2400LifeCoverage:EDIBase
    {
        public LCSeg LC { get; set; }
        public List<AMTSeg> AMT { get; set; }
        public List<DTPSeg> DTP { get; set; }
        public List<REFSeg> REF { get; set; } 
        [EDILoop("BEN", 0)]
        public List<Loop2410Beneficiary>  L2410 { get; set; }

    }


    public class Loop2410Beneficiary : EDIBase
    {
        public BENSeg BEN { get; set; }
        public NM1Seg NM1 { get; set; }

        public N2Seg N1 { get; set; }
        public N2Seg N2 { get; set; }
        public N3Seg N3 { get; set; }
        public N4Seg N4 { get; set; }
        public DMGSeg DMG { get; set; }

    }
}