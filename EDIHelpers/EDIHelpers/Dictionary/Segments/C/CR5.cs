namespace EDIHelpers.Dictionary.Segments
{

    /// <summary>
    /// Oxygen Therapy Certification
    /// </summary>
    public class CR5Seg: SegmentBase
    {
        public CR5Seg() : base("CR5")
        {
        }
        public char CR501_CertificationType { get; set; }
        public double? CR502_ { get; set; }
        public char CR503_EquipmentType { get; set; }
        public char CR504_EquipmentType { get; set; }
        public string CR505_Description { get; set; }
        public double? CR506_Quantity { get; set; }
        public double? CR507_Quantity { get; set; }
        public double? CR508_Quantity { get; set; }
        public string CR509_Description { get; set; }
        public double? CR510_Quantity { get; set; }
        public double? CR511_Quantity { get; set; }
        public char CR512_TestCondition { get; set; }
        public char CR513_TestFindins { get; set; }
        public char CR514_TestFindins { get; set; }
        public char CR515_TestFindins { get; set; }

        public double? CR516_Quantity { get; set; }
        public char CR517_DeliverySystem { get; set; }
        public char CR518_EquipmentType { get; set; }
    }
}