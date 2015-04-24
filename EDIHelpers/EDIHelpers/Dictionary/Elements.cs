using System;
using System.Collections.Generic;
using System.Linq;

namespace EDIHelpers.Dictionary.Helpers
{
    public static class Elements
    {


        public static string SwapElements(this string original, char delim, int position1, int position2)
        {
            string[] elements = original.Split(delim);
            //Do we have elements for each position?  
            //If not return original
            if (!(elements.Count() > position1) || !(elements.Count() > position2))
            {
                return original;
            }
            string pos1 = elements[position1];
            string pos2 = elements[position2];
            elements[position1] = pos2;
            elements[position2] = pos1;
            return String.Join("" + delim, elements);
        }




        public static string SetElement(string segment, char delim, Dictionary<int, string> values)
        {
            string[] elements = segment.Split(delim);
            foreach (KeyValuePair<int, string> item in values)
            {
                if (item.Key < elements.Count())
                    elements[item.Key] = item.Value;
            }
            return String.Join("" + delim, elements);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="segment"></param>
        /// <param name="delim"></param>
        /// <param name="position">zero based</param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string SetElement(string segment, char delim, int position, string value)
        {
            string[] elements = segment.Split(delim);
            if (position >= elements.Count())
                return segment;
            elements[position] = value;
            return String.Join("" + delim, elements);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="segment"></param>
        /// <param name="delim"></param>
        /// <param name="position">zero based</param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetElement(string segment, char delim, int position)
        {
            string[] elements = segment.Split(delim);
            if (position >= elements.Count())
                return "";

            return elements[position];
        }

        /// <summary>
        /// Returns the elements in order provided.
        /// </summary>
        /// <param name="segment"></param>
        /// <param name="delim"></param>
        /// <param name="position"></param>
        /// <returns></returns>
        public static List<string> GetElement(string segment, char delim, int[] position)
        {
            List<string> rtnVal = new List<string>();
            string[] elements = segment.Split(delim);
            foreach (var pos in position)
            {
                if (pos >= elements.Count())
                    rtnVal.Add(elements[pos]);
                else
                {
                    //Holder for the position
                    rtnVal.Add("");
                }
            }
            return rtnVal;
        }
    }
}
