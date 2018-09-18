using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Collections.Concurrent;

namespace LearningDictionaries
{
    class Program
    {

        /* static ConcurrentDictionary<int, int> items = new ConcurrentDictionary<int,int>(); */

        static void Main(string[] args)
        {

            /* Thread thread1 = new Thread(new ThreadStart(AddItem));
             Thread thread2 = new Thread(new ThreadStart(AddItem));

             thread1.Start();
             thread2.Start();


         }

         static void AddItem()
         {
             items.TryAdd(1, 2);
             Console.WriteLine(items.Count);
         } */

            bool[] preload = new bool[3] { true, false, true };

            BitArray enemyGrid = new BitArray(preload);

            foreach (var item in enemyGrid)
            {
                Console.WriteLine(item);
            }
           

        }
        
    }
}
