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
            Console.WriteLine("Enter year : ");
            int yr = Convert.ToInt32(Console.ReadLine());

            if(yr % 100 != 0 && yr % 4 == 0)
            {
                Console.WriteLine("Its a leap year");
            }
            else
            {
                Console.WriteLine("Its not leap year");
            }

        }
    }
}
