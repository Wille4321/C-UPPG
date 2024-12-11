using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsTask_UPPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MathOperations mathOps = new MathOperations();

            try
            {
                Console.Write("Enter the first number: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Enter the second number: ");
                int num2 = int.Parse(Console.ReadLine());

                Console.WriteLine($"Addition: {mathOps.Addition(num1, num2)}");
                Console.WriteLine($"Subtraction: {mathOps.Subtraction(num1, num2)}");
                Console.WriteLine($"Multiplication: {mathOps.Multiplication(num1, num2)}");

                try
                {
                    Console.WriteLine($"Division: {mathOps.Division(num1, num2)}");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.WriteLine($"Power: {mathOps.Power(num1, num2)}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter valid integers.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
    class MathOperations
    {
        public int Addition(int a, int b)
        {
            return a + b;
        }

        public int Subtraction(int a, int b)
        {
            return a - b;
        }

        public int Multiplication(int a, int b)
        {
            return a * b;
        }

        public double Division(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Division by zero is not allowed.");
            }
            return (double)a / b;
        }
        public double Power(int baseNumber, int exponent)
        {
            return Math.Pow(baseNumber, exponent);
        }
    }
}
