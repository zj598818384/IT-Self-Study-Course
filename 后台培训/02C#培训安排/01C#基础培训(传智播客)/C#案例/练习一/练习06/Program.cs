using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习06
{
    class Program
    {
        static void Main(string[] args)
        {
            //练习六：声明两个变量：int nl=10;n2=20要求
            //将两个变量交换，最后输出n1为20，n2为10，
            //不使用第三个变量如何交换？

            //不使用函数的情况下
            int n1 = 10;
            int n2 = 20;
            //n1 = n1 - n2;//n1=-10 n2=20
            //n2 = n1 + n2;//n1=-10 n2=10
            //n1 = n2 + n1;
            Change(ref n1,ref n2);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
        }

        public static void Change(ref int n1, ref int n2)
        {
            int temp = n1;
            n1 = n2;
            n2 = temp;
        }
    }
}
