
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number (1 to 7) to get the corresponding day of the week:");

            int choice;
            bool isValid = int.TryParse(Console.ReadLine(), out choice);

            if (!isValid)
            {
                Console.WriteLine("Invalid input! Please enter a numeric value.");
                return;
            }

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Invalid choice! Please enter a number between 1 and 7.");
                    break;

            }

        }
}
