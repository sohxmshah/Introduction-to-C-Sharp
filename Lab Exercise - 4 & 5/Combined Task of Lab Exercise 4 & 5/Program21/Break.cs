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
           for(int i=1; i<=10; i++)
            {
                Console.WriteLine(i);
                if(i == 5)
                {
                    break;
                }
            }
        }

    }
}
