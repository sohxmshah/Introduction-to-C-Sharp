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
            Console.Write("Enter a number: ");
            int originalNumber = int.Parse(Console.ReadLine());

            int number = originalNumber;
            int reversed = 0;

            // Reverse the number
            while (number > 0)
            {
                int digit = number % 10;
                reversed = (reversed * 10) + digit;
                number /= 10;
            }

            Console.WriteLine($"Reversed Number: {reversed}");

            // Check if original and reversed are the same
            if (originalNumber == reversed)
            {
                Console.WriteLine("The number is a Palindrome.");
            }
            else
            {
                Console.WriteLine("The number is NOT a Palindrome.");
            }
        }
    }
}
