using System;

namespace variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int x; //declaration
            x = 123; //initiallization

            int y = 321; // declaration + initialization

            int z = x + y;

            int age = 21; //whole integer
            double height = 180.5;

            //double 

            Console.WriteLine("Your age is " + age);
            Console.WriteLine("Your height is " + height + "cm");

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            Console.ReadKey();
        }

    }
}

