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

            int add = num1 + num2;
            Console.WriteLine("Addition of two numbers : " + add);

            int sub = num1 - num2;
            Console.WriteLine("Subtraction of two numbers : " +sub);

            int multiply = num1 * num2;
            Console.WriteLine("Muttiplication of two numbers : " + multiply);

            int div = num1 / num2;
            Console.WriteLine("Division of two numbers : " + div);
        }

    }
}
