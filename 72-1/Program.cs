using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _72_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请出入年份");
            int year = Convert.ToInt32(Console.ReadLine());

            bool isyear = year % 4 == 0 && year%100 != 0;

            string str = isyear ? "是闰年" : "不是闰年";
            Console.WriteLine(str);
            Console.ReadLine();

        }
    }
}
