using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //计算两个整数之间的最大值
            int max=GetMax(10,20);//实参
            Console.WriteLine(max);
        }
        /// <summary>
        /// 计算两个整数之间的最大值，并且返回最大值
        /// </summary>
        /// <param name="n1">第一个数</param>
        /// <param name="n2">第二个数</param>
        /// <returns>返回的最大值</returns>
        public static int GetMax(int n1, int n2)//形参
        {
            int max= n1 > n2 ? n1 : n2;
            //return是返回方法中要返回的值；
            //如果n1大于n2则返回n1
            //如果n2大于n2则返回n2
            return max;
        }
    }
}
