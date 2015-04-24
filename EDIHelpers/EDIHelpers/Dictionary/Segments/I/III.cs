using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIHelpers.Dictionary.Composites;

namespace EDIHelpers.Dictionary.Segments
{
    public class IIISeg: SegmentBase
    {
        public IIISeg() : base("III")
        {
        }

        public string III01_Qualifier{ get; set; }
        public string III02_IndustryCode{ get; set; }
        public string III03_CategoryCode{ get; set; }
        public string III04_Text{ get; set; }
        public double III05_Quantity{ get; set; }
        public C001_UOM III06_UOM{ get; set; }
        public string III07_LayerPosition{ get; set; }
        public string III08_LayerPosition{ get; set; }
        public string III09_LayerPosition{ get; set; }


    }
}
