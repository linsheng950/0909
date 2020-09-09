using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _107653转换
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = 107653;
            int day = time / (3600 * 24);
            int HourA = time% (3600 * 24);
            int Hour = HourA / 3600;
            int MinA = HourA % 3600;
            int Min = MinA / 60;
            int Second = MinA % 60;

            Console.WriteLine("107653秒是：\n{0}天{1}时{2}分{3}秒",day, Hour,Min,Second);
            Console.ReadLine();
        }
    }
}
