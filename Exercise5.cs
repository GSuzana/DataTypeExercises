using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Exercise5
    {
        static void Main(string[] args)
        {
            //Write a C# Sharp program that takes the radius of a circle as input and calculate the perimeter 
            //and area of the circle.

            const double pi = 3.14;
            Console.Write("5. Input the radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The circle's perimeter is " + (2 * pi * radius));
            Console.WriteLine("The circle's area is " + (pi * radius * radius));

            Console.ReadKey();
        }
    }
}
