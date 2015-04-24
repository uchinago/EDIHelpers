using System.Collections.Generic;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.HIPAA.X834
{
    public class Loop2600RetirementProduct:EDIBase
    {
        public RPSeg RP { get; set; }
        public List<DTPSeg> DTP { get; set; }
        public List<REFSeg> REF { get; set; }
        public List<INVSeg> INV { get; set; }
        public List<AMTSeg> AMT { get; set; }
        public List<QTYSeg> QTY { get; set; }
        public List<K3Seg> K3 { get; set; }
        public RELSeg REL { get; set; }
        [EDILoop("NM1", 0, "", 0, new[] { "FC", "AIN" })]
        public List<Loop2610Name> L2610 { get; set; }
        [EDILoop("FC", 0, "", 0, new[] { "AIN" })]
        public List<Loop2630FinancialContribution> L2630 { get; set; }
        [EDILoop("AIN", 0)]
        public List<Loop2650Income> L2650 { get; set; }

    }


    public class Loop2610Name : EDIBase
    {
        public NM1Seg NM1 { get; set; }
        public N2Seg N2 { get; set; }
        public DMGSeg DMG { get; set; }
        public BENSeg BEN { get; set; }
        public List<REFSeg> REF { get; set; }
        [EDILoop("NX1", 0)]
        public List<Loop2620Property> L2620 { get; set; }

    }

    public class Loop2620Property : EDIBase
    {
        public NX1Seg NX1 { get; set; }
        public N3Seg N3 { get; set; }
        public N4Seg N4 { get; set; }
        public List<DTPSeg> DTP { get; set; }
    }


    public class Loop2630FinancialContribution : EDIBase
    {
        public FCSeg FC { get; set; }
        public List<DTPSeg> DTP { get; set; }
        [EDILoop("FC", 0)]
        public List<Loop2640InvestVehicle> L2640 { get; set; }

    }

    public class Loop2640InvestVehicle : EDIBase
    {
        public INVSeg INV { get; set; }
        public List<DTPSeg> DTP { get; set; }
        public List<QTYSeg> QTY { get; set; }
        public List<ENTSeg> ENT { get; set; }
        public List<REFSeg> REF { get; set; }
        public List<AMTSeg> AMT { get; set; }
        public List<K3Seg> K3 { get; set; }

    }

    public class Loop2650Income : EDIBase
    {
        public AINSeg AIN { get; set; }
        public List<QTYSeg> QTY { get; set; }
        public List<DTPSeg> DTP { get; set; }
    }


}