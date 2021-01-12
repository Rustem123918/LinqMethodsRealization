using System;
using System.Collections.Generic;
using MyLinq;

namespace LinqMethodsRealization
{
    sealed class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string>() { "Jora", "Petya", "Pin", "Kesha", "Jam" };
            var y = list.SelectMany(name => name.Select(letter => letter.ToString()+letter.ToString()));
            foreach (var e in y)
                Console.WriteLine(e);
        }
    }
}
