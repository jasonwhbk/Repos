using System;
using System.Collections.Generic;

namespace LearningStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> pancakes = new Stack<string>();
            pancakes.Push("first");
            pancakes.Push("second");
            pancakes.Push("third");

            //foreach (var pancake in pancakes)
            //{
            //    Console.WriteLine(pancake);
            //}

            Console.WriteLine(pancakes.Pop());
            Console.WriteLine(pancakes.Peek());
            Console.WriteLine(pancakes.Pop());
            Console.WriteLine(pancakes.Peek());
        }
    }
}
