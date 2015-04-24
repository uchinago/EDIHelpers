using System.Collections.Generic;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.HIPAA.X837
{
    /// <summary>
    /// Can we use this for all of them??
    /// </summary>
    public class LoopPatient : EDIBase
    {


        public NM1Seg NM1 { get; set; }

        public N3Seg N3 { get; set; }
        public N4Seg N4 { get; set; }

        //Not 
        public DMGSeg DMG { get; set; }

        public List<REFSeg> REF { get; set; }

        public PERSeg PER { get; set; }
    }
}