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
            Console.WriteLine("Enter number : ");
            int num1=Convert.ToInt32(Console.Readline());

            Console.WriteLine("Enter number : ");
            int num2=Convert.ToInt32(Console.Readline());

            Console.WriteLine("1.Addition");
            Console.WriteLine("2.Subtraction");
            Console.WriteLine("3.Multiplication");
            Console.WriteLine("4.Division");
            Console.WriteLine("5.Exit");
            Console.WriteLine("Enter choice : ");
            int ch=Convert.ToInt32(Console.ReadLine());
          
            switch (ch)
            {
                case 1: int sum = num1 + num2;
                        Console.WriteLine($"Sum of {num1} & {num2} is : " +sum); 
                        break;

                case 2: int diff = num1 - num2;
                        Console.WriteLine($"Difference of {num1} & {num2} is : " + diff); 
                        break;

                case 3: int multiply = num1 * num2;
                        Console.WriteLine($"Multiplication of {num1} & {num2} is : " +multiply); 
                        break;

                case 4: int div = num1 / num2;
                        Console.WriteLine($"Division of {num1} & {num2} is : " + div); 
                        break;

                case 5: Console.WriteLine("Invalid choice");
                        break;

            }
        }

    }
}
