using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _67_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 8;

            bool Height = a > b;

            string str = Height ? "第一个球比第二个球重" : "第二个球比第一个球重";
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
