using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习11
{
    class Program
    {
        static void Main(string[] args)
        {
            //练习十一：用方法来实现：计算1~100之间的所有质数(常数)的和
            int sum = GetPrimeSum();
            Console.WriteLine(sum);

        }
        public static int GetPrimeSum()
        {
            int sum = 0;
            for (int i = 2; i <= 100; i++)
            {
                bool b = true;
                //判断循环数是不是质数
                for (int j  = 2; j < i; j++)
                {
                    if (i%j==0)
                    {
                        b = false;
                        break;
                    }
                }
                if (b)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}
