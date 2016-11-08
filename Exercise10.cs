using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Exercise10
    {
        static void Main(string[] args)
        {
            //Write a C# Sharp program that takes two numbers as input and returns true or false when both numbers are even or odd. 

            Console.WriteLine("10. enter the first number: ");
            int numb1 = int.Parse(Console.ReadLine());

            Console.Write("enter the second number: ");
            int numb2 = int.Parse(Console.ReadLine());

            bool condition = ((numb1 % 2 == 0 && numb2 % 2 == 0) || (numb1 % 2 == 1 && numb2 % 2 == 1)) ? true : false;
            Console.WriteLine(condition ? "both numbers are even or odd" : "the numbers are different");

            Console.ReadKey();

        }
    }
}
