using System;

namespace LearningProperties
{

    class Player
    {
        public bool IsAlive
        {
            get { return Health > 0; }
        }
        //int health = 100;

        //public indexer Health
        //{
        //    get { return health; }
        //}

        public int Health { get; private set } = 100;

        public void Hit()
        {
            Random r = new Random();
            Health -= r.Next(5, 50);
        }

        //public void CheckDeath()
        //{
        //    if (health <= 0)
        //        isAlive = false;
        //}
    }



    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            for (int i = 0; i < 20; i++)
            {
                player.Hit();
                Console.WriteLine(value: "Is player alive: " + player.IsAlive);
            }
            
        }
    }
}
