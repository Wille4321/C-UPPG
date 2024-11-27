using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeVerificationAndControlFlow_UPPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age here: ");
            string age1 = Console.ReadLine();
            int age = int.Parse(age1);

            int legalAge = 18;

            
            if (age >= 18)
            {
                Console.WriteLine("yor are an adult.");
            }
            else
            {
                Console.WriteLine("You are under the legal age.");
            }

            int counter = 1;
            while (counter <= 5)
            {
                Console.WriteLine($"Counter: {counter}");
                counter++;
            }

            switch (counter)
            {
                case 0:
                    Console.WriteLine("One");
                    break;
                
                case 1:
                    Console.WriteLine("Two");
                    break;
                
                case 2:
                    Console.WriteLine("Three");
                    break;
                
                case 3:
                    Console.WriteLine("Four");
                    break;
                
                case 4:
                    Console.WriteLine("Five");
                    break;

                default:
                    
                    break;
                
            }


            var name = "Welcome John";
            Console.WriteLine(name);
            
            Console.ReadLine();
        }
    }
}
