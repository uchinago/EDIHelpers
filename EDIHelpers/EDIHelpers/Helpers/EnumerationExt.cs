using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace EDIHelpers.Helpers
{
    public static class EnumerationExt
    {

        public static T FirstOrEmpty<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            if (source == null)
            {
               return  (T)Activator.CreateInstance(typeof(T));
            }
            return source.FirstOrDefault(predicate);
        }


        public static bool IsAny<T>(this IEnumerable<T> source)
        {
            return ((source != null) && source.Any());
        }

        public static bool IsAny<T>(this IEnumerable<T> source, Func<T, bool> condition)
        {
            if (source == null) return false;
            return source.Any(condition);
        }


        /// <summary>
        /// This will handle the null collections that might be used in a foreach
        ///    foreach(var item in items.OrEmptyListIfNull())
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static IEnumerable<T> OrEmptyListIfNull<T>(this IEnumerable<T> source)
        {
            return source ?? Enumerable.Empty<T>();
        }


        /// <summary>
        /// Easier to read than doing skip().take()
        /// 
        /// Returns a sublist based on indexes.
        /// 
        /// Time: 15 Minutes
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="startIndex"></param>
        /// <param name="endIndex"></param>
        /// <returns></returns>
        public static IEnumerable<T> GetRange<T>(this IEnumerable<T> list, int startIndex, int endIndex)
        {
            return list.Skip(startIndex).Take(endIndex - startIndex + 1);
        }


        /// <summary>
        /// Returns the first index of the list that meet the criteria provided
        /// 
        /// example:
        /// int pntr = strSegments.FindAllIndexOf(a => a.StartsWith("value"));
        /// 
        ///  Time: 15 Minutes
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public static int IndexOf<T>(this IEnumerable<T> list, Predicate<T> condition)
        {
            int i = -1;
            return list.Any(x => { i++; return condition(x); }) ? i : -1;
        }


        /// <summary>
        /// Returns an integer array of indexes for found item
        /// 
        /// example:
        /// int[] pntrs = strSegments.FindAllIndexOf(a => a.StartsWith("value"));
        /// 
        ///  Time: 15 Minutes
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="a"></param>
        /// <param name="match"></param>
        /// <returns></returns>
        public static int[] FindAllIndexOf<T>(this T[] a, Predicate<T> match)
        {
            T[] subArray = Array.FindAll<T>(a, match);
            return (from T item in subArray select Array.IndexOf(a, item)).ToArray();
        }
    }
}
