using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIHelpers.Helpers;

namespace EDIDocuments.Transformation
{
    public static class DataScrubbing
    {
        /// <summary>
        /// Limit to 12 in length then remove punctuation
        /// </summary>
        /// <param name="segment"></param>
        /// <param name="delim"></param>
        /// <returns></returns>
        public static string CleanSubscriberID(this string ID)
        {
            return new string(ID.Where(c => !char.IsPunctuation(c)).ToArray()).SafeSubstring(0, 12);
        }
    }
}
