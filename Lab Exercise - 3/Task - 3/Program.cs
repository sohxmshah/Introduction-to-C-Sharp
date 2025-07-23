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
            int number = Convert.ToInt32(Console.ReadLine());

            if (number %2 == 0)
            {
                Console.WriteLine("Number entered is even");
            }
            else
            {
                Console.WriteLine("Number entered is odd");
            }
        }
    }
}
