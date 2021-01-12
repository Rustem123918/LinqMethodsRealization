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
        public static T[] ToArray<T>(this IEnumerable<T> collection)
        {
            var temp = new List<T>();
            foreach (var e in collection)
                temp.Add(e);
            var result = new T[temp.Count];
            for(int i = 0; i<temp.Count; i++)
                result[i] = temp[i];
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
        public static IEnumerable<T> Skip<T>(this IEnumerable<T> collection, int count)
        {
            var i = 0;
            foreach(var e in collection)
            {
                if(i >= count)
                {
                    yield return e;
                }
                i++;
            }
        }
        public static IEnumerable<R> SelectMany<T, R>(this IEnumerable<T> collection, Func<T, IEnumerable<R>> func)
        {
            foreach (var e in collection)
            {
                var temp = func(e);
                foreach (var t in temp)
                    yield return t;
            }
        }
        public static IEnumerable<T> Distinct<T>(this IEnumerable<T> collection)
        {
            var res = new HashSet<T>();
            foreach(var e in collection)
            {
                if (!res.Contains(e))
                {
                    res.Add(e);
                    yield return e;
                }
            }
        }
    }
}
