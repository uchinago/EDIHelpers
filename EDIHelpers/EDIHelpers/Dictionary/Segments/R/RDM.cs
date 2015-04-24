using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIHelpers.Dictionary.Composites;

namespace EDIHelpers.Dictionary.Segments
{
    public class RDMSeg : SegmentBase
    {
        public RDMSeg()
            : base("RDM")
        {

        }
        public string RDM01_TrnasmissionCode { get; set; }
        public string RDM02_Name { get; set; }
        public string RDM03_CommunicationNumber { get; set; }
        public C040_Reference RDM04_ReferenceID { get; set; }
        public C040_Reference RDM05_ReferneceID { get; set; }
    }
}
