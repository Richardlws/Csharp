using System;

namespace stringmethons
{
    class Program
    {
        static void Main(string[] args)
        {
           String fullname = "Bro Code" ;
           //String phoneNumber = "123-456-7890";


           //fullname = fullname.ToUpper();
           //fullname = fullname.ToLower();
           //fullname = fullname.ToLower();
           //Console.WriteLine(fullname);

           //phoneNumber = phoneNumber.Replace("-","/");
           //Console.WriteLine(phoneNumber);

           //String userName = fullname.Insert(0,"Mr.");
           //Console.WriteLine(userName);

           //Console.WriteLine(fullname.Length);
           
           //String firstName = fullname.Substring(0,3);
           //Console.WriteLine(firstName);

           String lastName = fullname.Substring(4,4);
           Console.WriteLine(lastName);

            
        }


    }

}