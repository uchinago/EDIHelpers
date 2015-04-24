using System.Collections.Generic;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.ANSI.X12_834
{
    public class Loop2300HealthCoverage: EDIBase
    {
        public HDSeg HD { get; set; }
        public List<DTPSeg> DTP { get; set; }
        public List<AMTSeg> AMT { get; set; }
        public List<REFSeg> REF { get; set; }
        public List<IDCSeg> IDC { get; set; }

        [EDILoop("LX", 0, "", 0, "COB")]
        public List<Loop2310Transaction> L2310 { get; set; }

        [EDILoop("COB", 0)]
        public List<Loop2320COB> L2320 { get; set; } 
    }


    public class Loop2310Transaction : EDIBase
    {
        public LXSeg LX { get; set; }

        public NM1Seg NM1 { get; set; }

        public List<N1Seg> N1 { get; set; }

        public N2Seg N2 { get; set; }
        public List<N3Seg> N3 { get; set; }
        public List<N4Seg> N4 { get; set; }

        public List<PERSeg> PER { get; set; }
        public PRVSeg PRV { get; set; }
        public List<DTPSeg> DTP { get; set; }
        public PLASeg PLA { get; set; }

    }


    public class Loop2320COB : EDIBase
    {
        public COBSeg COB { get; set; }
        public List<REFSeg> REF { get; set; }
        public List<DTPSeg> DTP { get; set; }
        [EDILoop("NM1", 0)]
        public List<Loop2330> L2330 { get; set; }
    }

    public class Loop2330 : EDIBase
    {
        public NM1Seg NM1 { get; set; }

        public N2Seg N2 { get; set; }
        public List<N3Seg> N3 { get; set; }
        public N4Seg N4 { get; set; }
        public PERSeg PER { get; set; }

    }

}