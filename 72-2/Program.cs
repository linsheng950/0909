using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _72_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入用户名");
            string User = Console.ReadLine();
            Console.WriteLine("请输入密码");
            string Pass = Console.ReadLine();

            bool Sign_In = User == "mr" && Pass == "mrsoft";
            string str = Sign_In ? "登录成功" : "登录失败";
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
