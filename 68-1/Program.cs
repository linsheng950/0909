using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _68_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入账户名");
            string strUser = Console.ReadLine();

            Console.WriteLine("请输入手机号码");
            double Tel = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("请输入电子邮箱");
            string strEmail = Console.ReadLine();

            if((strUser=="明日"&&(Tel == 13600000204||strEmail =="mingrisoft@mingrisoft.com")))
            {
                Console.WriteLine("登录成功");
            }
            else
            {
                Console.WriteLine("登录失败");
            }
            Console.ReadLine();
                

               
        }
    }
}
