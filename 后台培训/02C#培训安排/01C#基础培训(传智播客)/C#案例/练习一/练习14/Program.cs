using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 练习14
{
    class Program
    {
        static void Main(string[] args)
        {
            //练习十四：请通过冒泡排序法对整数数组{1,3,5,7,90,2,4,6,8,10}实现升序排序
            int[] nums = { 1, 3, 5, 7, 90, 2, 4, 6, 8, 10 };
            //Array.Sort(nums);//升序排列方法
            //Array.Reverse(nums);//反转方法
            for (int i = 0; i < nums.Length-1; i++)
            {
                for (int j = 0; j < nums.Length-1; j++)
                {
                    if (nums[j]>nums[j+1])
                    {
                        int temp = nums[j];
                        nums[j] = nums[j+1];
                        nums[j + 1] = temp;
                    }
                }
            }

            //遍历输出
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
    }
}
