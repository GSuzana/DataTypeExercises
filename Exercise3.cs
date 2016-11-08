using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Exercise3
    {
        static void Main(string[] args)
        {
            //Write a C# Sharp program that takes userid and password as input (type string). 
            //After 3 wrong attempts user will be rejected.

            int no = 0;
            string id, pass;
            do
            {
                Console.Write("3. Enter the id: ");
                id = Convert.ToString(Console.ReadLine());
                Console.Write("Enter the password: ");
                pass = Convert.ToString(Console.ReadLine());
                no++;
            } while (id != "123" && pass != "pasword" && no != 3);

            if (no == 3)
            {
                Console.WriteLine("\nPlease try again later!");
            }
            else
            {
                Console.WriteLine("\nYou entered the correct credentials!");
            }
            Console.ReadKey();
        }
    }
}
