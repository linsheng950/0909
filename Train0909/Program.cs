using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train0909
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入第一个数值");
            int Frist = Convert.ToInt32(Console.ReadLine());
         
            Console.WriteLine("请输入第二个数值");
            int Second = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("请输入第三个数值");
            int Third = Convert.ToInt32(Console.ReadLine());

            int Sub = Frist + Second + Third;
            Console.WriteLine("三个数值之和{0}",Sub);
            Console.ReadLine();

        }
    }
}
