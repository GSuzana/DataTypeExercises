using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeExercises
{
    class Exercise1
    {
        static void Main(string[] args)
        {
            //Write a C# Sharp program that takes three letters as input and display them in reverse order.

            char c1, c2, c3;

            Console.WriteLine("1. Enter the first letter: ");
            c1 = char.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second letter: ");
            c2 = char.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third letter: ");
            c3 = char.Parse(Console.ReadLine());

            Console.WriteLine("{0} {1} {2}", c3, c2, c1);

            Console.ReadKey();
        }
    }
}
