using System;

namespace LearningNulls
{
    class Program
    {
        static void Main(string[] args)
        {

            int? s = null; // "hello";
            int s2 = s ?? 2;

            Console.WriteLine(s2);
        }
    }
}
