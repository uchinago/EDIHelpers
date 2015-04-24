using EDIHelpers.Attributes;
using EDIHelpers.Enums;

namespace EDIHelpers.Dictionary.Segments
{
    public class CR4Seg: SegmentBase
    {
        public CR4Seg() : base("CR4")
        {
        }
        public YesNo CR401_ResponseCode { get; set; }
        public char CR402_CertificationType { get; set; }
        [EDILength(2)]
        public string CR403_UOM { get; set; }

        public double? CR404_Quantity { get; set; }
        [EDILength(2)]
        public string CR405_UOM { get; set; }
        public double? CR406_Quantity { get; set; }
        public char CR407_NonVisitCode { get; set; }

        [EDILength(2)]
        public string CR408_UOM { get; set; }
        public double? CR409_Quantity { get; set; }
        [EDILength(2)]
        public string CR410_UOM { get; set; }
        public double? CR411_Height { get; set; }
        [EDILength(2)]
        public string CR412_UOM { get; set; }

        public double? CR413_Weight { get; set; }


        public double? CR414_Quantity { get; set; }

        public string CR415_Description { get; set; }

        public char CR416_NutrientAdminMethod { get; set; }
        public char CR417_NutrientAdminTechnique { get; set; }

        public double? CR418_Quantity { get; set; }
        public double? CR419_Quantity { get; set; }
        public string CR420_Description { get; set; }
        public double? CR421_Quantity { get; set; }
        public double? CR422_Percentage { get; set; }
        public double? CR423_Quantity { get; set; }
        public double? CR424_Quantity { get; set; }
        public double? CR425_Percentage { get; set; }
        public double? CR426_Quantity { get; set; }
        public double? CR427_Percentage { get; set; }

        public double? CR428_Quantity { get; set; }
        public string CR429_Description { get; set; }
    }
}