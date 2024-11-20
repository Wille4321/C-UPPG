using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputOutput_in_C__UPPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name here: ");
            string name = Console.ReadLine();
            Console.WriteLine("Welcome " + name);
        }
    }
}
