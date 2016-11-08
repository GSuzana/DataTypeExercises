using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Exercise9
    {
        static void Main(string[] args)
        {
            //Write a C# Sharp program that takes a character as input and check the input 
            //(lowercase) is vowel, a digit, or any other symbol.

            Console.Write("9. Input a symbol: ");
            char symbol = Convert.ToChar(Console.ReadLine());

            if ((symbol == 'a') || (symbol == 'e') || (symbol == 'i') || (symbol == 'o') || (symbol == 'u'))
                Console.WriteLine("It's a lowercase vowel.");
            else if ((symbol >= '0') && (symbol <= '9'))
                Console.WriteLine("It's a digit.");
            else
                Console.Write("It's another symbol.");

            Console.ReadKey();
        }
    }
}
