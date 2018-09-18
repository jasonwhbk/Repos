using System;

namespace LearningFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("connected to database");

            try
            {
                throw new Exception("error while accessing database resource");
            }
            //catch
            //{
            //    //Console.WriteLine("exception caught");
            //}
            finally
            {
                Console.WriteLine("disconnecting database");
            }
        }
    }
}
