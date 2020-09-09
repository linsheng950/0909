using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _67_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Family_Allow = 2;
            int FamilyA = 2;
            int FamilyB = 4;

            bool A = FamilyA > Family_Allow;
            bool B = FamilyB > Family_Allow;

            string str1 = A ? "A家庭超生" : "";
            string str2 = B ? "B家庭超生" : "";
            Console.WriteLine(str1+str2);
            Console.ReadLine();

        }
    }
}
