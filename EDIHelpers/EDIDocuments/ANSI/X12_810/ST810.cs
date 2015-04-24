using System.Collections.Generic;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.ANSI.X12_810
{
    public class ST810: EDIBase
    {
        //private const string[] SacTermSeg = new[]
        //    {
        //        "ITD", "DIS", "INC", "DTM", "LIN", "SI", "PID", "MEA", "PWK", "PKG", "TD1", "TD5", "TD3", "TD4", "MAN",
        //        "PCT", "CTB", "TXI", "LDT", "AMT", "N9", "N1", "LM", "SPI", "ADV", "PO1", "CTT", "SE"
        //    };
        public STSeg ST { get; set; }
        public BIGSeg BIG { get; set; }
        //Not Used
        public List<NTESeg> NTE { get; set; } 
        //Not Used
        public CURSeg CUR { get; set; }
        public List<REFSeg> REF { get; set; }
        //Not used by Bass Pro Shops
        //YNQSeg
        public List<PERSeg> PER { get; set; }
        //public List<TAXSeg> TAX { get; set; }
        
        public List<FOBSeg> FOB { get; set; }
        //public List<CTPSeg> CTP { get; set; }
        //public List<PAMSeg> PAM { get; set; }
        //public List<CSHSeg> CSH { get; set; }
        //public List<TC2Seg> TC2 { get; set; }
        public List<SACSeg> SAC { get; set; }

        public List<ITDSeg> ITD { get; set; }
        public List<DTMSeg> DTM { get; set; }
        public List<TD5Seg> TD5 { get; set; }

        [EDILoop("N9", 0, "", 1, new[] {"N1", "PO1", "CTT", "SE" })]
        public List<LoopN9> N9 { get; set; }

        [EDILoop("N1", 0, "", 1, new[] { "PO1", "CTT", "SE" })]
        public List<LoopN1> N { get; set; }

        [EDILoop("PO1", 0, "", 1, new[] {"CTT", "SE"})]
        public List<LoopPO1> PO1 { get; set; }

        public CTTSeg CTT { get; set; }
        
        public SESeg SE { get; set; }
    }
}

//deader
//ST
//BIG
//REF
//LoopN1
  //N1
  //ITD

//detail
//LoopIT1
  //IT1
  //PO4

//Summary
//TDS
//LoopSAC
  //SAC
//CTT
//SE
