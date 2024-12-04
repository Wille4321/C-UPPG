using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleAreaTask_UPPG
{
    class Circle
    {
        public double Radius { get; private set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(1.5);

            double area = circle.CalculateArea();
            Console.WriteLine("Area of the circle is: " + area);
        }
    }
}