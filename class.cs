using System;

namespace Myprogram
{
    /*class Program
    {
        static void Main(string[] args)
        {
            //class = A bundle of related code.
            //          Can be used as a bluepring to create objeces(oop)


            

        }
    }*/
    class Messages
    {
        public static void Hello()
        {
            Console.WriteLine("Hello! Welcome to the program");
        }
        public static void Waiting()
        {
            Console.WriteLine("I am waiting for something");
        }
        public static void Bye()
        {
            Console.WriteLine("Bye! Thanks for visiting");
        }
    
        static void Main(string[] args)
            {
                //class = A bundle of related code.
                //          Can be used as a bluepring to create objeces(oop)

                Messages.Hello();
                Messages.Bye();
                Messages.Waiting();

            }
    }
}