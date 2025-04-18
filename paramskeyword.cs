using System;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
namespace paramskeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            //params keyword = a method parameter that takes a variiable number of arguments.
            //                  The parameter type must be a single - dimensional array
            double total = CheckOut(3.99, 5.75, 15);
            
            Console.WriteLine(total);

        }
        static double CheckOut(double a)
        {
            return a;
        }
        static double CheckOut(double a, double b)
        {
            return a + b;
        }
        static double CheckOut(double a, double b, double c)
        {
            return a + b + c;
        }
    }
}