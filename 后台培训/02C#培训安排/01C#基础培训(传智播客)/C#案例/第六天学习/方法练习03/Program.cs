using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法练习03
{
    class Program
    {
        static void Main(string[] args)
        {
            //练习一：
            //计算任意多个数间的最大值(提示:params)
            int sum=GetSum(1,2,3,4,5,6,7);
            Console.WriteLine(sum);

            //练习二：
            //请通过冒泡排序法对整数数组{1,3,5,7,90,2,4,6,8,10}实现升序排序
            int[] nums = { 1, 3, 5, 7, 90, 2, 4, 6, 8, 10 };
            Change(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }

            //练习三：
            //将一个字符串输出为|分割的形式，比如"梅西|卡卡|郑大师"(用方法)
            string[] names = { "梅西","卡卡","郑大师"};
            string str = ProcessString(names);
            Console.WriteLine(str);

        }

        //练习一
        public static int GetSum(params int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum+=nums[i];
            }
            return sum;
        }

        //练习二
        public static void Change(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length-1-i; j++)
                {
                    if (nums[j]>nums[j+1])
                    {
                        int temp=nums[j];
                        nums[j]=nums[j+1];
                        nums[j + 1] = temp;
                    }
                }
            }
        }

        //练习三
        public static string ProcessString(string[] names)
        {
            string str = null;
            for (int i = 0; i < names.Length-1; i++)
            {
                str += names[i] +"|";
            }
            return str + names[names.Length - 1];
        }
    }
}
