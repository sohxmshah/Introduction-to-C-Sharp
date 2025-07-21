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
            Console.WriteLine("Enter a number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int temp = number1;
            number1 = number2;
            number2 = temp;

            Console.WriteLine("After Swapping : ");
            Console.WriteLine("Number 1 : " + number1);
            Console.WriteLine("Number 2 : " + number2);
        }
    }
}
