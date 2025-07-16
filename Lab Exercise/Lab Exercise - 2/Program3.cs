using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            // User Inputs
            Console.Write("Enter your number : ");
            int num = int.Parse(Console.ReadLine());

            if(num > 0)
            {
                Console.Write("number is postive");
            }
            else
            {
                Console.Write("number is negative");
            }

        }
    }
}
