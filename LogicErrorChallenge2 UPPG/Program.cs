using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicErrorChallenge2_UPPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 40;

            

            if (age <= 18)
            {
                Console.WriteLine("18 or less");
            }
            
            else if (age >= 18 && age < 30)
            {
                Console.WriteLine("Between 19 and 30");
            }
            else if (age >= 31 && age <99)
            {
                Console.WriteLine("Between 31 and 99");
            }

            Console.ReadLine();
        }
    }
}
