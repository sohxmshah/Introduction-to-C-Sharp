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
            Console.WriteLine("Enter marks of subject : ");
            int m1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter marks of subject : ");
            int m2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter marks of subject : ");
            int m3 = Convert.ToInt32(Console.ReadLine());

            int total = m1 + m2 + m3;
            float percentage = (total/300f) * 100;
            Console.WriteLine("Total Marks obtained : " + total);
            Console.WriteLine("Percentage obtained : " + percentage);

            if(percentage>=90)
            {
                Console.WriteLine("Congrats!,you achieved 1st rank");
            }
            else if(percentage>=70 && percentage<90)
            {
                Console.WriteLine("Congrats!,you achieved 2nd rank");

            }
            else if(percentage>=60 && percentage<70)
            {
                Console.WriteLine("Congrats!,you achieved 3rd rank");

            }
            else if (percentage >= 40 && percentage < 60)
            {
                Console.WriteLine("Can do better,you are passed");

            }
            else
            {
                Console.WriteLine("Fail");
            }

        }
    }
}
