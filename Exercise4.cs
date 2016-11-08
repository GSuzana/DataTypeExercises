using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Exercise4
    {
        static void Main(string[] args)
        {
            //Write a C# Sharp program that takes two numbers as input and 
            //perform an operation (+,-,*,x,/) on them and displays the result of that operation. 

            Console.Write("4. Input the first number: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Input operation: ");
            string op = Convert.ToString(Console.ReadLine());

            Console.Write("Input the second number: ");
            int n2 = int.Parse(Console.ReadLine());

            if (op == "+")
            {
                Console.Write("{0}+{1}={2}", n1, n2, (n1 + n2));
            }
            else if (op == "-")
            {
                Console.Write("{0}-{1}={2}", n1, n2, (n1 - n2));
            }
            else if (op == "*")
            {
                Console.Write("{0}*{1}={2}", n1, n2, (n1 * n2));
            }
            else if (op == "/")
            {
                Console.Write("{0}/{1}={2}", n1, n2, (n1 / n2));
            }
            else
            {
                Console.Write("This is not a valid operation!");
            }
            Console.ReadKey();
        }
    }
}
