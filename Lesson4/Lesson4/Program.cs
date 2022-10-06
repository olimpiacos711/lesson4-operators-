using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int y = Convert.ToInt32(Console.ReadLine());

            if(x < y)
            {
                int z = 0;
                for (int i = x; i <= y; i++)
                    z += i;
                Console.WriteLine("Sum of numbers between " + x + " and " + y + " = " + z);
            }

            if(x > y)
            {
                int z = 0;
                for (int i = y; i <= x; i++)
                    z += i;
                Console.WriteLine("Sum of numbers between " + y + " and " + x + " = " + z);
            }

            if (x == y)
                Console.WriteLine("Numbers are equal = " + x);
        }
    }
}
