using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 冒泡排序
{
    class Program
    {
        static void Main(string[] args)
        {
            //升序排列
            int[] nums = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            //Array.Sort(nums);//只能升序
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = 0; j < nums.Length - 1-i; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        int temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }

            //降序排列
            int[] nums1 = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            //Array.Reverse(nums1);//只能降序，对数字进行反转
            for (int i = 0; i < nums1.Length - 1; i++)
            {
                for (int j = 0; j < nums1.Length - 1 - i; j++)
                {
                    if (nums1[j] < nums1[j + 1])
                    {
                        int temp = nums1[j];
                        nums1[j] = nums1[j + 1];
                        nums1[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < nums1.Length; i++)
            {
                Console.WriteLine(nums1[i]);
            }
        }
    }
}
