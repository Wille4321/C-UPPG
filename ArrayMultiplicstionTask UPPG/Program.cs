using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMultiplicstionTask_UPPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Num = 7;
            int Length = 5;

            int[] array = new int[Length];

            Console.WriteLine($"Multiplication table for {Num} is: ");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"{Num} x {1} x {Num * i}");
            }


        }
    }
}
