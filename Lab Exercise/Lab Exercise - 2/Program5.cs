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
            int num1 = 1;
            int num2 = 2;
            int temp;
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("Swapped Numbers are : " + num1);
            Console.WriteLine("Swapped Numbers are : " + num2);

        }
    }
}
