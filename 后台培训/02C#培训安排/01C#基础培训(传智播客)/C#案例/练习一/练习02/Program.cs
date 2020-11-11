using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习02
{
    class Program
    {
        static void Main(string[] args)
        {
            //练习二：编程输出九九乘法表
            for (int i = 1; i < 9; i++)
            {
                for (int j = 0; j<=9; j++)
                {
                    Console.WriteLine("{0}*{1}={2}\t",i,j,i*j);
                }
            }
        }
    }
}
