using System;

namespace EDIHelpers.Enums
{
    public static class EnumHelper
    {

        #region YesNo Enum
        public static string FromYesNo(this YesNo original)
        {
            switch (original)
            {
                case YesNo.No: return "N";
                case YesNo.Yes: return "Y";
                case YesNo.NotApplicable: return "W";
                case YesNo.Unknown: return "U";
                default: return "";
            }
        }


        public static YesNo ToYesNo(this string original)
        {

            if (String.IsNullOrWhiteSpace(original))
                return YesNo.Blank;
            switch (original[0])
            {
                case 'Y':
                case 'y': return YesNo.Yes;
                case 'N':
                case 'n': return YesNo.No;
                case 'W':
                case 'w': return YesNo.NotApplicable;
                case 'U':
                case 'u': return YesNo.Unknown;
            }
            return YesNo.Blank;

           
        }
        #endregion

        #region Gender Enum

        public static string FromGender(this Gender original)
        {
            switch (original)
            {
                case Gender.Female:
                    return "F";
                case Gender.Male:
                    return "M";
                case Gender.NonSexed:
                    return "N";
                case Gender.NotApplicable:
                    return "B";
                case Gender.NotProvided:
                    return "A";
                case Gender.Unsexable:
                    return "X";
                case Gender.Unknown:
                    return "U";
                default:
                    return "";
            }
        }

        public static Gender ToGender(this string original)
        {
            if (string.IsNullOrWhiteSpace(original))
                return Gender.Blank;
            switch (original.ToUpper()[0])
            {
                case 'A': return Gender.NotProvided;
                case 'B': return Gender.NotApplicable;
                case 'F': return Gender.Female;
                case 'M': return Gender.Male;
                case 'N': return Gender.NonSexed;
                case 'U': return Gender.Unknown;
                case 'X': return Gender.Unsexable;
                default: return Gender.Unknown;
            }

        }

        #endregion

    }
}