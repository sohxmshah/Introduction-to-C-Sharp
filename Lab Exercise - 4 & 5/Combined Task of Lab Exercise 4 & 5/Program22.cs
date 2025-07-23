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
            Console.Write("Enter a number between 1 and 5: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num < 1 || num > 5)
            {
                goto InvalidInput;
            }

            Console.WriteLine("You entered: " + num);
            goto End;

            InvalidInput:
                Console.WriteLine("Invalid input! Number should be between 1 and 5.");

            End:
                Console.WriteLine("Program has ended.");

        }

    }
}
