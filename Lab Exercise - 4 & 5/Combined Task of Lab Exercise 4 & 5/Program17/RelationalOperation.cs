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
            Console.Write("Enter a number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a number : ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if(num1==num2)
            {
                Console.WriteLine("Both are equal.");
            }
        }

    }
}
