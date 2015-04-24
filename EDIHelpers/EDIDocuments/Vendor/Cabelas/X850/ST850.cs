using System.Collections.Generic;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.Vendor.Cabelas.X850
{
    public class ST850: EDIBase
    {
        //private const string[] SacTermSeg = new[]
        //    {
        //        "ITD", "DIS", "INC", "DTM", "LIN", "SI", "PID", "MEA", "PWK", "PKG", "TD1", "TD5", "TD3", "TD4", "MAN",
        //        "PCT", "CTB", "TXI", "LDT", "AMT", "N9", "N1", "LM", "SPI", "ADV", "PO1", "CTT", "SE"
        //    };
        public STSeg ST { get; set; }
        public BEGSeg BEG { get; set; }
        public List<REFSeg> REF { get; set; }

        public List<PERSeg> PER { get; set; }
        
        public List<FOBSeg> FOB { get; set; }
        //Normally this is a loop but since we only have to worry about SAC segment in the loop just make it a list
        public List<SACSeg> SAC { get; set; }

        public List<ITDSeg> ITD { get; set; }

        public List<DTMSeg> DTM { get; set; }
        public List<TD5Seg> TD5 { get; set; }

        public List<CTBSeg> CTB { get; set; }

        [EDILoop("N9", 0, "", 1, new[] { "N1", "PO1", "CTT", "SE" })]
        public List<LoopN9> N9 { get; set; }

        [EDILoop("N1", 0, "", 1, new[] { "PO1", "CTT", "SE" })]
        public List<LoopN1> N { get; set; }

        [EDILoop("PO1", 0, "", 1, new[] {"CTT", "SE"})]
        public List<LoopPO1> PO1 { get; set; }

        public CTTSeg CTT { get; set; }

        public AMTSeg AMT { get; set; }
        
        public SESeg SE { get; set; }
    }
}