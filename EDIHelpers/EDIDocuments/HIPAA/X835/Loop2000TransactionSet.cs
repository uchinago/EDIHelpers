using System.Collections.Generic;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.HIPAA.X835
{
    public class Loop2000TransactionSet: EDIBase
    {

        public LXSeg LX { get; set; }
        public TS3Seg TS3 { get; set; }
        public TS2Seg TS2 { get; set; }

        [EDILoop("CLP", 0, "", 0, new[] { "PLB", "SE"})]
        public List<Loop2100ClaimData> L2100 { get; set; } 
        
    }

    public class Loop2100ClaimData: EDIBase
    {
        public CLPSeg CLP { get; set; }
        public List<CASSeg> CAS { get; set; }
        public List<NM1Seg> NM1 { get; set; }
        public MIASeg MIA { get; set; }
        public MOASeg MOA { get; set; }
        public List<REFSeg> REF { get; set; }
        public List<DTMSeg> DTM { get; set; }
        public List<PERSeg> PER { get; set; }

        public List<AMTSeg> AMT { get; set; }
        public List<QTYSeg> QTY { get; set; }


        [EDILoop("SVC", 0)]
        public List<Loop2110ServiceInformation> L2110 { get; set; } 

    }
    public class Loop2110ServiceInformation : EDIBase
    {
        public SVCSeg SVC { get; set; }
        public List<DTMSeg> DTM { get; set; }
        public List<CASSeg> CAS { get; set; }
        public List<REFSeg> REF { get; set; }
        public List<AMTSeg> AMT { get; set; }
        public List<QTYSeg> QTY { get; set; }
        public List<LQSeg> LQ { get; set; }
    }
}