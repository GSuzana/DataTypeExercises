using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Exercise7
    {
        static void Main(string[] args)
        {
            //Write a C# Sharp program that takes distance and time as input and display the speed 
            //in kilometers per hour and miles per hour.

            Console.WriteLine("7. Input the distance: ");
            float dist = float.Parse(Console.ReadLine());

            Console.WriteLine("Input the seconds: ");
            float sec = float.Parse(Console.ReadLine());

            Console.WriteLine("Input the minutes: ");
            float min = float.Parse(Console.ReadLine());

            Console.WriteLine("Input the hours: ");
            float hour = float.Parse(Console.ReadLine());

            float timeSec = (hour * 3600) + (min * 60) + sec;
            float mps = dist / timeSec;
            float kph = (dist / 1000.0f) / (timeSec / 3600.0f);
            float mph = kph / 1.609f;

            Console.WriteLine("Your speed in meters/sec is {0}", mps);
            Console.WriteLine("Your speed in km/h is {0}", kph);
            Console.WriteLine("Your speed in miles/h is {0}", mph);
            Console.ReadKey();
        }
    }
}
