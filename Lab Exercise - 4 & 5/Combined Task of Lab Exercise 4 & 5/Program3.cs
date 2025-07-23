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
            Console.WriteLine("Enter a number 1 : ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a number 2 : ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a number 3 : ");
            int number3 = Convert.ToInt32(Console.ReadLine());

            if(number1>number2 && number1 > number3)
            {
                Console.WriteLine("Number One is greater than number two & number three");
            }
            else if(number2> number1 && number2 > number3)
            {
                Console.WriteLine("Number Two is greater than number one & number three");

            }
            else
            {
                Console.WriteLine("Number Three is greater than number one & number two");

            }

        }
    }
}
