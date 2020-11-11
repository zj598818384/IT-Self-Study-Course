using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习09
{
    class Program
    {
        static void Main(string[] args)
        {
            //练习九：用方法来实现：计算1~100之间的所有整数的和
            GetSum();
         }
        public static int GetSum()
        {
            int sum = 0;
            int jishu = 0;
            int oshu = 0;
            //所有整数的和
            for (int i = 0; i < 101; i++)
            {
                sum += 1;
            }
            return sum;
            //所有基数的和
            for (int i = 0; i < 101; i+=2)
            {
                jishu += 1;
            }
            return jishu;
            //所有偶数的和
            for (int i = 2; i < 101; i+=2)
            {
                oshu += 1;
            }
            return oshu;
        }
    }
}
