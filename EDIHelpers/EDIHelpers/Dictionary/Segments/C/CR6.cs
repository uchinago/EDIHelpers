using System;
using EDIHelpers.Attributes;
using EDIHelpers.Enums;

namespace EDIHelpers.Dictionary.Segments
{
    /// <summary>
    /// Home Health Care Certification
    /// </summary>
    public class CR6Seg:SegmentBase
    {
        public CR6Seg():base("CR6")
        {}
        public char CR601_Prognosis { get; set; }

        [EDIFormat("D8")]
        public DateTime CR602_Date { get; set; }

        public string CR603_Qualifier { get; set; }
        public string CR604_DatePeriod { get; set; }

        [EDIFormat("D8")]
        public DateTime CR605_Date { get; set; }

        public YesNo CR606_ResponseCode { get; set; }
        public YesNo CR607_ResponseCode { get; set; }

        public char CR608_CertificationType { get; set; }

        [EDIFormat("D8")]
        public DateTime CR609_Date { get; set; }

        [EDILength(2)]
        public string CR610_ProductQualifier { get; set; }

        public string CR611_ProductID { get; set; }

        [EDIFormat("D8")]
        public DateTime CR612_Date { get; set; }

        [EDIFormat("D8")]
        public DateTime CR613_Date { get; set; }

        [EDIFormat("D8")]
        public DateTime CR614_Date { get; set; }


        public string CR615_Qualifier { get; set; }
        public string CR616_DatePeriod { get; set; }

        public char CR617_PatientLocation { get; set; }
        [EDIFormat("D8")]
        public DateTime CR618_Date { get; set; }

        [EDIFormat("D8")]
        public DateTime CR619_Date { get; set; }

        [EDIFormat("D8")]
        public DateTime CR620_Date { get; set; }

        [EDIFormat("D8")]
        public DateTime CR621_Date { get; set; }

      


    }
}