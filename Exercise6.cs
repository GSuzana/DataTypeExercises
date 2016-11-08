using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Exercise6
    {
        static void Main(string[] args)
        {
            //Write a C# Sharp program to display certain values of the function x = y2 + 2y + 1
            //(using integer numbers for y , ranging from -5 to +5)

            for (int y = -5; y <= 5; y++)
            {
                Console.WriteLine("x = ({0})² - 2*({0}) + 1 => x = {1} ", y, (y * y + 2 * y + 1));
            }
            Console.ReadKey();
        }
    }
}
