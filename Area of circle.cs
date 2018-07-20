using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Radius
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14159;
            // constant declaration find area 
            double r;
            Console.WriteLine("Radius?: ");
            r = Convert.ToDouble(Console.ReadLine());
            double areaCircle = pi * r * r;
            //output
            Console.WriteLine("Radius: {0}, Area: {1}", r, areaCircle);
            Console.ReadLine();
        }
    }
}

