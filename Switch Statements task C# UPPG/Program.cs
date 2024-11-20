using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Statements_task_C__UPPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int grade = 5;
            switch (grade)
            {
                case 5:
                    Console.WriteLine("Excellent");
                    break;
                case 4:
                    Console.WriteLine("Good");
                    break;
                case 3:
                    Console.WriteLine("Satisfactory");
                    break;
                case 2:
                    Console.WriteLine("Ok");
                    break;
                case 1:
                    Console.WriteLine("Needs Improvement");
                    break;
                case 0:
                    Console.WriteLine("Fail");
                    break;
            }
        }
    }
}
