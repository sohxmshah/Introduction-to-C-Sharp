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
            Console.WriteLine("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            int original = number;

            while (number != 0)
            {
                int digit = number % 10; 
                sum += digit;            
                number /= 10;            
            }
            Console.WriteLine($"Sum of digits of {original} is: {sum}");
        }

    }
}
