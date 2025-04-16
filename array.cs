using System;
using System.Runtime.InteropServices;
namespace array
{
    class Program
    {
        static void Main(string[] args)
        {

            //array = a variable that can store multiple values. fixed size

            String[] cars = {"BMW", "Mustang", "Corvette"};

            cars[0]= "Telsa";
            
            Console.WriteLine(cars[0]);
            Console.WriteLine(cars[1]);
            Console.WriteLine(cars[2]);

        }
    }
}