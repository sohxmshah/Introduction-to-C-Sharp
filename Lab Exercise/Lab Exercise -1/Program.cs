using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 18;
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
