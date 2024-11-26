using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Password_Checker_Task_UPPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter pasword here: ");
            string password = Console.ReadLine();

            Console.WriteLine("Enter pasword again: ");
            string password2 = Console.ReadLine();

            if (password == null || password2 == "")
            {
                Console.WriteLine("Please enter a password!");
            }

            if (password2 == null || password == "")
            {
                Console.WriteLine("Please enter a password!");
            }


            if (password.Length <= 5)
            {
                Console.WriteLine("please enter a number higher or equal to 6");
            }

            if (password2.Length <= 5)
            {
                Console.WriteLine("please enter a number higher or equal to 6");
            }




            if (password == password2)
            {
                Console.WriteLine("Password match");
            }
            else
            {
                Console.WriteLine("Paswords do not match");
            }

            Console.ReadLine();
        }
    }
}
