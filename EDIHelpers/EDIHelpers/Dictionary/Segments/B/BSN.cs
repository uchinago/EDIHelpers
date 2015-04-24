using System;
using EDIHelpers.Attributes;

namespace EDIHelpers.Dictionary.Segments
{
    public class BSNSeg : SegmentBase
    {
        public BSNSeg()
            : base("BSN")
        { }

        private string BSN01_PurposeCode;
        private string BSN02_ShipmentID;
        private DateTime BSN03_Date;
        private string BSN05_HierStructure;
        private string BSN06_TransType;
        private string BSN07_StatusCode;

        [EDILength(2)]
        public string BSN01PurposeCode
        {
            get { return BSN01_PurposeCode; }
            set { BSN01_PurposeCode = value; }
        }

        public string BSN02ShipmentID
        {
            get { return BSN02_ShipmentID; }
            set { BSN02_ShipmentID = value; }
        }

        [EDIFormat("D8")]
        public DateTime BSN03Date
        {
            get { return BSN03_Date; }
            set { BSN03_Date = value; }
        }

        [EDIFormat("TMS")]
        public DateTime BSN04Time
        {
            get { return BSN03_Date; }
            set { BSN03_Date = new DateTime(BSN03_Date.Year, BSN03_Date.Month, BSN03_Date.Day, value.Hour, value.Minute, value.Second, value.Millisecond); }
        }
        [EDILength(4)]
        public string BSN05HierStructure
        {
            get { return BSN05_HierStructure; }
            set { BSN05_HierStructure = value; }
        }
        [EDILength(2)]
        public string BSN06TransactionType
        {
            get { return BSN06_TransType; }
            set { BSN06_TransType = value; }
        }
        [EDILength(3)]
        public string BSN07StatusCode
        {
            get { return BSN07_StatusCode; }
            set { BSN07_StatusCode = value; }
        }
    }
}