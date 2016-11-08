using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class Exercise8
    {
        static void Main(string[] args)
        {
            //Write a C# Sharp program that takes radius of a sphere as input and calculate and display 
            //the surface and volume of the sphere.

            Console.Write("8. Input the radius: ");
            double r = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("The sphere's surface is: " + (4 * 3.14 * r * r));
            Console.Write("The sphere's volume is: " + (4 / 3 * 3.14 * r * r * r));

            Console.ReadKey();
        }
    }
}
