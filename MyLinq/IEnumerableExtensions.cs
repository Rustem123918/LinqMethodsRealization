using System;
using System.Collections.Generic;

namespace MyLinq
{
    public static class IEnumerableExtensions
    {
        public static IEnumerable<T> Where<T>(this IEnumerable<T> collection, Predicate<T> predicate)
        {
            foreach (var e in collection)
                if (predicate(e))
                    yield return e;
        }
        public static IEnumerable<Tout> Select<Tin, Tout>(this IEnumerable<Tin> collection, Func<Tin, Tout> selector)
        {
            foreach (var e in collection)
                yield return selector(e);
        }
        public static List<T> ToList<T>(this IEnumerable<T> collection)
        {
            var result = new List<T>();
            foreach (var e in collection)
                result.Add(e);
            return result;
        }
        public static T FirstOrDefault<T>(this IEnumerable<T> collection, Func<T, bool> filter)
        {
            foreach (var e in collection)
                if (filter(e)) return e;
            return default(T);
        }
        public static IEnumerable<T> Take<T>(this IEnumerable<T> collection, int count)
        {
            var i = 0;
            foreach(var e in collection)
            {
                if (i >= count)
                    break;
                yield return e;
                i++;
            }
        }
    }
}
