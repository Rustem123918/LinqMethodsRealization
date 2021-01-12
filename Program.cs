using System;
using System.Collections.Generic;
using MyLinq;

namespace LinqMethodsRealization
{
    sealed class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>(new[] { 1, 2, 5, 3, 2 });
            var res = list.Take(3);
            foreach (var e in res)
                Console.WriteLine(e);
        }
    }
}
