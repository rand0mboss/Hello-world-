using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversionApplication
{
    class StringConversion
    {
        static void Main(string[] args)
        {
            //Varibles 
            int i = 85;
            float f = 43.005f;
            double d = 28845.7652;
            bool b = true;
            // C# Type Conversion
            Console.WriteLine(i.ToString());
            Console.WriteLine(f.ToString());
            Console.WriteLine(d.ToString());
            Console.WriteLine(b.ToString());
            Console.ReadKey();
        }
    }
}
