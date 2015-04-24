using System;

namespace EDIHelpers.Helpers
{
    public static class StringExt
    {
        /// <summary>
        /// Determines if the string is null and returns a String.Empty 
        /// otherwise it will do a normal Trim() and return that.
        /// </summary>
        /// <param name="original"></param>
        /// <returns></returns>
        public static string SafeTrim(this String original)
        {
            if (original == null || original.Length == 0) return String.Empty;
            return original.Trim();
        }


        /// <summary>
        /// Safely gets the substring depending on the length of original value and requested items
        /// Returns empty string if out of range.
        /// </summary>
        /// <param name="original"></param>
        /// <param name="startIndex"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static string SafeSubstring(this string original, int startIndex, int length)
        {
            if (original.Length >= (startIndex + length))
            {
                return original.Substring(startIndex, length);
            }
            else
            {
                if (original.Length > startIndex)
                {
                    return original.Substring(startIndex);
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        public static EDIHelpers.Enums.EDIDelim GetDefaultDelimiters()
        {
            Enums.EDIDelim rtnVal = new Enums.EDIDelim();
            rtnVal.Element = '*';
            rtnVal.Repitition = '}';
            rtnVal.Segment = '~';
            rtnVal.Subelement = '^';
            return rtnVal;
        }
    }
}