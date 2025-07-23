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
            Console.WriteLine("Multiples of 17 less than 100:");
            for (int i = 1; i * 17 < 100; i++)
            {
                Console.WriteLine(i * 17);
            }
        }
    }
}
