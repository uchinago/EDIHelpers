using System.Collections.Generic;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.Vendor.Sportsmans.X810
{
    /// <summary>
    /// Based on the 4010Vics implementation guide from BassProShops
    /// </summary>
    public class ST810: EDIBase
    {
        public STSeg ST { get; set; }
        public BIGSeg BIG { get; set; }

        public List<NTESeg> NTE { get; set; }
        public CURSeg CUR { get; set; }

        public List<REFSeg> REF { get; set; }


        [EDILoop("N1", 0, "", 1, new[] { "ITD", "IT1", "SAC", "TDS", "CTT", "SE" })]
        public List<LoopN1> N1 { get; set; }
        

        public List<ITDSeg> ITD { get; set; }

        public List<DTMSeg> DTM { get; set; }

        
        /// <summary>
        /// 
        /// </summary>
        [EDILoop("IT1", 0, "", 1, new[] { "TDS", "TXI", "CAD", "CTT", "SE" })]
        public List<LoopIT1> IT1 { get; set; }

        /// <summary>
        /// THis is mandatory
        /// </summary>
        public TDSSeg TDS { get; set; }

        //public TXISeg TXI { get; set; }

        public CADSeg CAD { get; set; }

        public List<SACSeg> SAC { get; set; }

        public CTTSeg CTT { get; set; }
        
        public SESeg SE { get; set; }
    }
}

