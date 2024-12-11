using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParseTask_UPPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "abc";
            int number;

            try
            {
                number = Convert.ToInt32(input);
                Console.WriteLine("Conversion succeeded. Number: " + number);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred: " + ex.Message);
            }

            bool isParsed = TryParseCustom(input, out number);

            if (isParsed)
            {
                Console.WriteLine("Custom Parse succeeded. Number: " + number);
            }
            else
            {
                Console.WriteLine("Custom Parse failed.");
            }
        }

        static bool TryParseCustom(string input, out int result)
        {
            result = 0;
            try
            {
                result = Convert.ToInt32(input);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
