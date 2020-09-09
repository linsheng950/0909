using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _62_2
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 21.8F;
            float b = 2.0F;
            float c = 7.0F;
            float d = 8.0F;
            float e = 28.0F;
            float f = 62.0F;
            float x;
            float y;

            x = (e * d - b * f) / (a * d - b * c);
            y = (a * f - e * c) / (a * d - b * c);

            Console.WriteLine("X:"+x );
            Console.WriteLine("Y:"+y );
            Console.ReadLine();

        }
    }
}
