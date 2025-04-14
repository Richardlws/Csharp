using System;

namespace forloops
{
    class Program
    {
        static void Main(string[] args)
        {
            //for looop = repeats some code a FINITE amount of times
            /*
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            */
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Happy new year!");
        }
    }
}