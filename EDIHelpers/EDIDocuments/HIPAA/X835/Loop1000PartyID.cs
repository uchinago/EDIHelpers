using System.Collections.Generic;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.HIPAA.X835
{
    public class Loop1000PartyID: EDIBase
    {
        public N1Seg N1 { get; set; }
        public List<N2Seg> N2 { get; set; }
        public List<N3Seg> N3 { get; set; }
        public N4Seg N4 { get; set; }
        public List<REFSeg> REF { get; set; }
        public List<PERSeg> PER { get; set; }
        public RDMSeg RDM { get; set; }
        public DTMSeg DTM { get; set; }
    }
}