using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.HIPAA.X271
{
    public class Group271: EDIBase
    {
        public Group271()
        {

        }

        public GSSeg GS { get; set; }
        [EDILoop("ST")]
        public List<Transaction271> STLoops { get; set; }
        public GESeg GE { get; set; }

        internal void SetCount()
        {
            if (GE != null)
                GE.GE01_TransactionCount = STLoops.Count;
        }

    }
}
