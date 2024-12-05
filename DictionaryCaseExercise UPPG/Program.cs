using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryCaseExercise_UPPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> subjects = new Dictionary<string, string>();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Enter subject: ");
                Console.WriteLine("2. Remove a subject");
                Console.WriteLine("3. Display all subject");
                Console.WriteLine("4. Exit");
                Console.Write("Choose option between 1 and 4: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter the subject name: ");
                        string subject = Console.ReadLine();
                        Console.Write("Enter the teachers name: ");
                        string teacher = Console.ReadLine();

                        if (!subjects.ContainsKey(subject))
                        {
                            subjects[subject] = teacher;
                            Console.WriteLine($"{subject}' was added with the teacher being: '{teacher}'.");
                        }
                        else
                        {
                            Console.WriteLine($"Subject '{subject}' already exists.");
                        }
                        break;

                    case "2":
                        Console.Write("What subject do you want to remove: ");
                        string subjectToRemove = Console.ReadLine();

                        if (subjects.Remove(subjectToRemove))
                        {
                            Console.WriteLine($"Subject '{subjectToRemove}' removed.");
                        }
                        else
                        {
                            Console.WriteLine($"Subject '{subjectToRemove}' not found.");
                        }
                        break;

                    case "3":
                        Console.WriteLine("\nSubjects and their teachers:");
                        if (subjects.Count > 0)
                        {
                            foreach (var item in subjects)
                            {
                                Console.WriteLine($"Subject: {item.Key}, Teacher: {item.Value}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No subjects found.");
                        }
                        break;

                    case "4":
                        exit = true;
                        Console.WriteLine("See you later alligator :)");

                        Console.ReadLine();
                        break;

                }
                Console.ReadLine();
            }
        }
    }
} 