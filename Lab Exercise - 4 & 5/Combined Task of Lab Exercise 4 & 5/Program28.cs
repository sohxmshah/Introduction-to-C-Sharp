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
            int a = 4;
            try
            {
                int div = a / 0;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("An error occurred: " + ex);
            }
        }
    }
}
