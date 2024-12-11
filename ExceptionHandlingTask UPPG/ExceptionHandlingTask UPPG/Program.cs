using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingTask_UPPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            try
            {
                Console.Write("Enter the first integer: ");
                string input1 = Console.ReadLine();
                int num1 = calculator.ParseInput(input1);

                Console.Write("Enter the second integer: ");
                string input2 = Console.ReadLine();
                int num2 = calculator.ParseInput(input2);

                if (num1 == -1 || num2 == -1)
                {
                    Console.WriteLine("Invalid inputs provided. Unable to perform division.");
                }
                else
                {
                    double result = calculator.Divide(num1, num2);
                    Console.WriteLine($"Result: {result}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }
    }
    class Calculator
    {
        public double Divide(int numerator, int denominator)
        {
            try
            {
                return (double)numerator / denominator;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                return 0.0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                return 0.0;
            }
        }
        public int ParseInput(string input)
        {
            try
            {
                return int.Parse(input);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Input is not a valid integer.");
                return -1;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                return -1;
            }
        }
    }
}
