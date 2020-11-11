using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习13
{
    class Program
    {
        static void Main(string[] args)
        {
            //练习十三：用方法来实现：请计算一个整型数组的平均值
            //{ 1,3,5,7,93,33,4,4,6,8,10}。要求：计算结果具有小数，
            //则显示小数点后两位(四舍五入)

            int[] numbers = { 1, 3, 5, 7, 93, 33, 4, 4, 6, 8, 10 };
            double avg = GetAvg(numbers);
            avg=Convert.ToDouble(avg.ToString("0.00")) ;
            Console.WriteLine(avg);
            //只改变输出的，不改变原数值
            //Console.WriteLine("{0:0.00}",avg);
        }
        public static double GetAvg(int[] nums)
        {
            double sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            return sum / nums.Length;
        }
    }
}
