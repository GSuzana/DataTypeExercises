using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11
{
    class Exercise11
    {
        static void Main(string[] args)
        {
            //Write a C# Sharp program that takes a decimal number as input and displays its equivalent in binary form.

            int mod, mod1 = 0, mod2 = 0;

            Console.WriteLine("11. Input the number: ");
            int nrdec = int.Parse(Console.ReadLine());
            int aux = nrdec;
            do
            {
                mod = nrdec % 2;
                mod1 = mod1 * 10 + mod;
                nrdec = nrdec / 2;
            } while (nrdec != 0);

            while (mod1 != 0)
            {
                mod2 = mod2 * 10 + mod1 % 10;
                mod1 = mod1 / 10;
            }
            Console.WriteLine("{0} converted to base 2 is {1}",aux, mod2);

            Console.ReadKey();
        }
    }
}
