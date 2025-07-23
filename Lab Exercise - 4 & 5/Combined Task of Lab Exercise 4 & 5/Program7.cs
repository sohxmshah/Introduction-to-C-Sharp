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
            int sum = 0,product=1;
            for (int i= 1; i<= 10; i++)
            {
                sum += i;
                product *= i;

            }
            // Sum of 1 to 10 numbers
            Console.WriteLine("Sum of 1 to 10 is : " + sum);

            // Product of 1 to 10 numbers
            Console.WriteLine("Product of 1 to 10 is : " + product);
        }
    }
}
