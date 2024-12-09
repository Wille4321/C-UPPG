using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops_in_C__UPPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("How many times do you want to loop: ");
            int loopCounter = Convert.ToInt32(Console.ReadLine());
            if (loopCounter <= 0)
            {
                Console.WriteLine("Please enter a value above 0");
            }
            else
            {
                for (int i = 0; i < loopCounter; i++)
                {
                    Console.WriteLine("Loop: " + i);
                }
            }
            
        }
    }
}
