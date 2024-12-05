using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculationTask_UPPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the width of the triangle:");
            double baseWidth = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the height of the triangle:");
            double height = Convert.ToDouble(Console.ReadLine());

            double area = baseWidth * height / 2;

            Console.WriteLine($"The area of the triangle is: {area}");


            Console.ReadKey(); 
        }
    }
}
