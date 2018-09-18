using System;

namespace LearningNullConditional
{
    class Person
    {
        public string Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(); // { Name = "Tim" };

            Console.WriteLine(person?.Name ?? "not available");
        }
    }
}
