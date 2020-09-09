using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 圆的周长与面积
{
    class Program
    {
        static void Main(string[] args)
        {
            int R = 4;
            float Pi = 3.14F;
            float C = 2*Pi*R;
            float S = Pi * R * R;

            Console.WriteLine("圆的周长为："+ C);
            Console.WriteLine("圆的面积为：" +S);
            Console.ReadLine();

        }
    }
}
