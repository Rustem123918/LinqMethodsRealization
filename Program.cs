using System;
using System.Collections.Generic;
using MyLinq;

namespace LinqMethodsRealization
{
    sealed class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>()
            {
                new Student(){Name = "Petr", Age = 18 },
                new Student() {Name = "Alex", Age = 25 },
                new Student() {Name = "Petr", Age = 18}
            };
            var distinctStudents = students.Distinct().ToList();

            var names = new List<string>() { "Jora", "Petya", "Pin", "Kesha", "Jam" };
            var doubleLetters = names.SelectMany(name => name.Select(letter => letter.ToString() + letter.ToString()));
            foreach (var letter in doubleLetters)
                Console.WriteLine(letter);
        }
    }
}
