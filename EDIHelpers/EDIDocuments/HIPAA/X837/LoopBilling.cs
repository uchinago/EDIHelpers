using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.HIPAA.X837
{

    /// <summary>
    /// HL03 = 20
    /// </summary>
    public class LoopBilling : EDIBase
    {

        public HLSeg HL { get; set; }
        public PRVSeg PRV { get; set; }
        public CURSeg CUR { get; set; }

        /// <summary>
        /// NM101 = 85
        /// </summary>
        [EDILoop("NM1", 1, "", 0, new[] { "NM1", "HL" })]
        public Loop2010AA BillingName { get; set; }


        /// <summary>
        /// NM101 = 87
        /// Do not include the REF segments
        /// </summary>
        [EDILoop("NM1", 1, "", 0, new[] { "NM1", "HL" })]
        public Loop2010Simple PayToAddress { get; set; }

        /// <summary>
        /// NM101 = PE
        /// </summary>
        [EDILoop("NM1", 1, "", 0, new[] { "NM1", "HL" })]
        public Loop2010Simple PayToPlan { get; set; }


        [EDILoop("HL", 3, "22")]
        public List<LoopSubscriber> Subscribers { get; set; }


    }

    /// <summary>
    /// Can we use this for all of them??
    /// </summary>
    public class Loop2010AA : EDIBase
    {
    

        public NM1Seg NM1 { get; set; }

        public N3Seg N3 { get; set; }
        public N4Seg N4 { get; set; }

        public List<REFSeg> REF { get; set; }

        public List<PERSeg> PER { get; set; }
    }


   


}
