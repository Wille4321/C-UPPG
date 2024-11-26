using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 4;
            int num2 = 2;
            int num3 = 6;
            int num4 = 8;
            int num5 = 12;
            int num6 = 10;

            Console.WriteLine(num1 + num2);
            Console.WriteLine(num3 * num4);
            Console.WriteLine(num5 / num6);

            Console.WriteLine(++num6);
            Console.WriteLine(--num6);


            Console.WriteLine(num5 += 5);
            Console.WriteLine(num5 -= 5);
            Console.WriteLine(num5 *= 5);
            Console.WriteLine(num5 /= 5);
            Console.WriteLine(num5 %= 5);

            Console.ReadLine();



        }
    }
}
