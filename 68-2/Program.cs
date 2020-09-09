using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _68_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //要求
            char Sex = '男';
            int AgeMin = 23;
            int AgeMax = 30;
            //A的信息
            char SexA = '男';
            int AgeA = 25;
            //B的信息
            char SexB = '男';
            int AgeB = 32;

            //A应聘者判断
            if (SexA == Sex && AgeMin <= AgeA && AgeA <= AgeMax )
            {
                Console.WriteLine("A应聘者满足要求");
            }
            else
            {
                Console.WriteLine("A应聘者不满足要求");
            }

            //B应聘者判断
            if (SexB == Sex && AgeMin <= AgeB && AgeB <= AgeMax)
            {
                Console.WriteLine("B应聘者满足要求");
            }
            else
            {
                Console.WriteLine("B应聘者不满足要求");
            }

            Console.ReadLine();
        }
    }
}
