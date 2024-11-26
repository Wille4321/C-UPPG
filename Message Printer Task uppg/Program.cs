using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Message_Printer_Task_uppg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1+2
            Console.WriteLine("Enter the message: C# is fun i am going to code C# tomorrow");
            var message = Console.ReadLine();
            //3
            Console.WriteLine(new string(message.Reverse().ToArray()));

            //4
            foreach (char letter in message)
                Console.WriteLine(letter);

            //5
            
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            
            foreach (char c in message)
                Console.WriteLine(c);
            
            Console.ReadLine();
        }
    }
}
