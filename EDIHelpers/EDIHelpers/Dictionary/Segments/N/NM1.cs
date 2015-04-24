using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EDIHelpers.Dictionary.Segments
{
    public class NM1Seg: SegmentBase
    {
        public NM1Seg() : base("NM1")
        {
        }

        public NM1Seg(string nm101, string nm102, string nm103, string nm104=null, string nm105=null, string nm108=null, string nm109 = null)
            : base("NM1")
        {
            NM101_EntityType = nm101;
            NM102_EntityQualifier = nm102;
            NM103_LastorOrganization = nm103;
            NM104_First = nm104;
            NM105_Middle = nm105;
            NM108_IDQualifier = nm108;
            NM109_ID = nm109;
        }


        private string NM101_EntityType;
        private string NM102_EntityQualifier;
        private string NM103_LastorOrganization;
        private string NM104_First;
        private string NM105_Middle;
        private string NM106_Prefix;
        private string NM107_Suffix;
        private string NM108_IDQualifier;
        private string NM109_ID;
        private string NM110_RelationCode;
        private string NM111_EntityType;
        private string NM112_LastorOrganization;


        public string Nm101EntityType
        {
            get { return NM101_EntityType; }
            set { NM101_EntityType = value; }
        }

        public string Nm102EntityQualifier
        {
            get { return NM102_EntityQualifier; }
            set { NM102_EntityQualifier = value; }
        }

        public string Nm103LastorOrganization
        {
            get { return NM103_LastorOrganization; }
            set { NM103_LastorOrganization = value; }
        }

        public string Nm104First
        {
            get { return NM104_First; }
            set { NM104_First = value; }
        }

        public string Nm105Middle
        {
            get { return NM105_Middle; }
            set { NM105_Middle = value; }
        }

        public string Nm106Prefix
        {
            get { return NM106_Prefix; }
            set { NM106_Prefix = value; }
        }

        public string Nm107Suffix
        {
            get { return NM107_Suffix; }
            set { NM107_Suffix = value; }
        }

        public string Nm108IDQualifier
        {
            get { return NM108_IDQualifier; }
            set { NM108_IDQualifier = value; }
        }

        public string Nm109ID
        {
            get { return NM109_ID; }
            set { NM109_ID = value; }
        }

        public string Nm110RelationCode
        {
            get { return NM110_RelationCode; }
            set { NM110_RelationCode = value; }
        }

        public string Nm111EntityType
        {
            get { return NM111_EntityType; }
            set { NM111_EntityType = value; }
        }

        public string Nm112LastorOrganization
        {
            get { return NM112_LastorOrganization; }
            set { NM112_LastorOrganization = value; }
        }
    }
}
