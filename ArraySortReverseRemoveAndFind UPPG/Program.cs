using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySortReverseRemoveAndFind_UPPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 45, 12, 78, 34, 89, 23 };


            
            foreach (int number in numbers)
            {
                Console.Write(number);
            }
            
            Array.Sort(numbers);

            foreach (int num in numbers)
            {
                Console.Write($" {num} ");
            }


            Array.Reverse(numbers);

            foreach (var item in numbers)
            {
                Console.Write($"{item} ");
            }
            
            
            int numToRemove = 78;
            int numIndex = Array.IndexOf(numbers, numToRemove);
            numbers = numbers.Where((val, idx) => idx != numIndex).ToArray();
            
            foreach (int number in numbers)
                {
                    Console.Write(number);
                }

            //int index = Array.IndexOf(34);

            int index = Array.IndexOf( numbers, 34);
            Console.Write(index);

            Console.ReadLine();
        }
    }
}
