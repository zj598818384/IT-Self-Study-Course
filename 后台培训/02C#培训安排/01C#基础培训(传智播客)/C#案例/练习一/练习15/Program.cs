using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 练习15
{
    class Program
    {
        static void Main(string[] args)
        {
            //练习十五：为教师编写一个程序，改程序使用一个数组存储30个学生的
            //考试成绩，并给各个数组元素指定一个1~100的随机数，然后计算平均值
            int[] nums = new int[30];
            //随机数
            Random r = new Random();
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = r.Next(1,101);
            }

            double sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            double avg = sum / nums.Length;
            //保留两位小数
            avg=Convert.ToDouble(avg.ToString("0.00"));
            Console.WriteLine(avg);
        }
    }
}
