using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EDIHelpers.Dictionary.Segments
{
    public class AMTSeg : SegmentBase
    {
        public AMTSeg()
            : base("AMT")
        {
        }

        public AMTSeg(string qualifier, double amount)
            : base("AMT")
        {
            AMT01_Qualifer = qualifier;
            AMT02_Amount = amount;
        }

        public AMTSeg(string qualifier, decimal amount)
            : base("AMT")
        {
            AMT01_Qualifer = qualifier;
            AMT02_Amount = Convert.ToDouble(amount);
        }

        public string AMT01_Qualifer { get; set; }

        public double? AMT02_Amount { get; set; }
        /// <summary>
        /// Valid values when used are C or D
        /// </summary>
        public char AMT03_CreditDebit { get; set; }
    }
}
