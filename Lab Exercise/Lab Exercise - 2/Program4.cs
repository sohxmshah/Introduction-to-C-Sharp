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
            // Dynamic Inputs
            Console.Write("Enter your age : ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("Eligible for Voting");
            }
            else
            {
                Console.WriteLine("You are not Eligible");
            }
        }
    }
}
