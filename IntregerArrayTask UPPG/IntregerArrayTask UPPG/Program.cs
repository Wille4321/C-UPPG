using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntregerArrayTask_UPPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 0, 1, 2, 3, 4, 5 };

            int sum = SumOfNumbers(numbers);
            Console.WriteLine("Sum of all numbers in the array: " + sum);

            Console.WriteLine("Array length: " + numbers.Length);

            if (numbers.Length > 0)
            {
                if (sum > -1)
                {
                    Console.WriteLine("The total is: " + sum);
                }
                else
                {
                    Console.WriteLine("Cannot add up an array with negative values");
                }
            }
            else
            {
                Console.WriteLine("Cannot add up an empty array");
            }

            Console.ReadKey();
        }

        static int SumOfNumbers(int[] array)
        {
            int sum = 0;
            foreach (int num in array)
            {
                sum += num;
            }
            return sum;
        }

    }
}
