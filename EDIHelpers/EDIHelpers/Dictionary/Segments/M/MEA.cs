using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary.Composites;

namespace EDIHelpers.Dictionary.Segments
{
    public class MEASeg: SegmentBase
    {
        public MEASeg() : base("MEA")
        {
        }
        [EDILength(2)]
        public string MEA01_ReferenceID { get; set; }
        public string MEA02_Qualifier { get; set; }
        public double? MEA03_Value { get; set; }
        public C001_UOM MEA04_UOM { get; set; }
        public double? MEA05_MinRange { get; set; }
        public double? MEA06_MaxRange { get; set; }
        [EDILength(2)]
        public string MEA07_SignificanceCode { get; set; }
        [EDILength(2)]
        public string MEA08_Attribute { get; set; }
        [EDILength(2)]
        public string MEA09_SurfaceCode { get; set; }
        public string MEA10_DeviceCode { get; set; }
        public string MEA11_Qualifier { get; set; }
        public string MEA12_Code { get; set; }
    }
}
