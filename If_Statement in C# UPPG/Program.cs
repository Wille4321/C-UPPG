using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Statement_in_C__UPPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 18;

            if (age >= 18)
            {
                Console.WriteLine("You can vote");
            }
            else if (age < 18)
            {
                Console.WriteLine("You cannot vote");
            }

            Console.ReadLine();
        }
    }
}
