using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EDIHelpers.Dictionary.Composites
{
    public class C001_UOM: CompositeBase
    {
        public C001_UOM() : base('^')
        {
        }

        public string C001_01_UOM { get; set; }
        public double? C001_02_Exponent { get; set; }
        public double? C001_03_Multiplier { get; set; }

        public string C001_04_UOM { get; set; }
        public double? C001_05_Exponent { get; set; }
        public double? C001_06_Multiplier { get; set; }

        public string C001_07_UOM { get; set; }
        public double? C001_08_Exponent { get; set; }
        public double? C001_09_Multiplier { get; set; }

        public string C001_10_UOM { get; set; }
        public double? C001_11_Exponent { get; set; }
        public double? C001_12_Multiplier { get; set; }

        public string C001_13_UOM { get; set; }
        public double? C001_14_Exponent { get; set; }
        public double? C001_15_Multiplier { get; set; }

    }
}
