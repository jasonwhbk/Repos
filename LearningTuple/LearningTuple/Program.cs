using System;

namespace LearningTuple
{
    class Program
    {
        static void Main(string[] args)
        {
            Tuple<int, String, bool> myTuple = new Tuple<int, string, bool>(1, "hello", true);
            Console.WriteLine(myTuple.Item3);
        }
    }
}
