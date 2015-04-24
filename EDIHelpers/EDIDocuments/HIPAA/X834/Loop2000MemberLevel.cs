using System.Collections.Generic;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.HIPAA.X834
{
    public class Loop2000MemberLevel: EDIBase
    {

        public INSSeg INS { get; set; }
        public List<REFSeg> REF { get; set; }
        public List<DTPSeg> DTP { get; set; }


        //how do we filter for 2 qualifiers?  make it an array???
        [EDILoop("NM1", 1, "IL", 0, new[] { "NM1", "DSB", "HD", "LC", "FSA", "RP", "LS" })]
        public Loop2100AMemberName MemberName { get; set; }


        //how do we filter for 2 qualifiers?  make it an array???
        [EDILoop("NM1", 1, "70", 0, new[] { "NM1", "DSB", "HD", "LC", "FSA", "RP", "LS" })]
        public Loop2100BMemberName IncorrectMemberName { get; set; }

        //how do we filter for 2 qualifiers?  make it an array???
        [EDILoop("NM1", 1, "31", 0, new[] { "NM1", "DSB", "HD", "LC", "FSA", "RP", "LS" })]
        public Loop2100CMailingAddress MemberMailingAddress { get; set; }


        //how do we filter for 2 qualifiers?  make it an array???
        [EDILoop("NM1", 1, "36", 0, new[] { "NM1", "DSB", "HD", "LC", "FSA", "RP", "LS" })]
        public List<Loop2100MemberExtra> MemberEmployer { get; set; }

        //how do we filter for 2 qualifiers?  make it an array???
        [EDILoop("NM1", 1, "M8", 0, new[] { "NM1", "DSB", "HD", "LC", "FSA", "RP", "LS" })]
        public List<Loop2100MemberExtra> MemberSchool { get; set; }

        //how do we filter for 2 qualifiers?  make it an array???
        [EDILoop("NM1", 1, "S3", 0, new[] { "NM1", "DSB", "HD", "LC", "FSA", "RP", "LS" })]
        public Loop2100MemberExtra CustodialParent { get; set; }

        //how do we filter for 2 qualifiers?  make it an array???
        [EDILoop("NM1", 1, "M8", 0, new[] { "NM1", "DSB", "HD", "LC", "FSA", "RP", "LS" })]
        public List<Loop2100MemberExtra> ResponsiblePerson { get; set; }


        //DropOffLocation
        //DisablitityInformation

        //Health Coverages

        [EDILoop("HD", 0, "", 0, new[] { "LC", "FSA", "RP", "LS" })]
        public List<Loop2300HealthCoverage> L2300 { get; set; }

        //LS


        //[EDILoop("NM1", 0, "", 0, new[] {"DSB", "HD", "LC", "FSA", "RP", "LS"})]
        //public List<Loop2100Name> L2100 { get; set; }
        
        ////L2200DiabilityINformation
        //[EDILoop("DSB", 0, "", 0, new[] { "HD", "LC", "FSA", "RP", "LS" })]
        //public List<Loop2200Disability> L2200 { get; set; }

        //[EDILoop("HD", 0, "", 0, new[] { "LC", "FSA", "RP", "LS" })]
        //public List<Loop2300HealthCoverage> L2300 { get; set; }
        //[EDILoop("LC", 0, "", 0, new[] { "FSA", "RP", "LS" })]
        //public List<Loop2400LifeCoverage> L2400 { get; set; }
        //[EDILoop("FSA", 0, "", 0, new[] { "RP", "LS" })]
        //public List<Loop2500FSA> L2500 { get; set; }
        //[EDILoop("RP", 0, "", 0, new[] { "LS" })]
        //public List<Loop2600RetirementProduct> L2600 { get; set; }
        //[EDILoop("LS", 0)]
        //public List<LoopLS834> LS { get; set; } 
    }


    public class Loop2100AMemberName : EDIBase
    {
        public NM1Seg NM1 { get; set; }
        public PERSeg PER { get; set; }
        public N3Seg N3 { get; set; }
        public N4Seg N4 { get; set; }
        public DMGSeg DMG { get; set; }

        public List<ECSeg> EC { get; set; }
        public ICMSeg ICM { get; set; }

        public List<AMTSeg> AMT { get; set; }

        public HLHSeg HLH { get; set; }
        public List<LUISeg> LUI { get; set; }
    }


    public class Loop2100BMemberName : EDIBase
    {
        public NM1Seg NM1 { get; set; }
        public DMGSeg DMG { get; set; }
    }

    public class Loop2100CMailingAddress : EDIBase
    {
        public NM1Seg NM1 { get; set; }
        public N3Seg N3 { get; set; }
        public N4Seg N4 { get; set; }
    }


    public class Loop2100MemberExtra : EDIBase
    {
        public NM1Seg NM1 { get; set; }
        public PERSeg PER { get; set; }
        public N3Seg N3 { get; set; }
        public N4Seg N4 { get; set; }
    }

}