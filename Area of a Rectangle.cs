using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_class_CSharp_basic_syntax
{
    class Rectangle
    {
        // variables Length, With 
        double length;
        double width;
        public void Acceptdetails()
            // Change this to find area
        {
            length = 53.5;
            width = 853.5;
        }
         // Under the hood Stuff.
        public double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }
    // Details
    class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.Acceptdetails();
            r.Display();
            Console.ReadLine();
        }
    }
}