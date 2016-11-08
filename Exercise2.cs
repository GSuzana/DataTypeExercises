using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Exercise2
    {
        static void Main(string[] args)
        {
            //Write a C# Sharp program that takes a number and a width also a number,
            //as input and then displays a triangle of that width, using that number.

            int nr, width;
            Console.WriteLine("2. Enter a number: ");
            nr = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the desired width: ");
            width = Convert.ToInt32(Console.ReadLine());

            int height = width;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(nr);
                }

                Console.WriteLine();
                width--;
            }
            Console.ReadKey();
        }
    }
}
