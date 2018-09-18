using System;

namespace LearningUsing
{
    class Program
    {
        class MyResource : IDisposable
        {
            public void Dispose()
            {
                Console.WriteLine("Disposing rsrc");
            }
        }
        static void Main(string[] args)
        {

            using (var resource = new MyResource())
            {
                Console.WriteLine("Using rsrc");
            }

            Console.WriteLine("Finished!");

        }
    }
}
