using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_uppg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 8;
            int num2 = 5;
            int num3 = 3;
            int num4 = 8;

            bool isTrue = true;

            Console.WriteLine((num1 > num3) && (num2 < num4));
            Console.WriteLine((num1 < num3) || (num2 > num4));

            Console.WriteLine(num1 > num3);
            Console.WriteLine(num2 < num4);
            Console.WriteLine(num1 == num4);
            Console.WriteLine(num2 != num3);

            bool expression1 = true;
            bool expression2 = false;

            //Console.WriteLine(expression1 && expression2);
            Console.WriteLine(expression1);
            Console.WriteLine(expression2);

        }
    }
}
