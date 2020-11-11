using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习08
{
    class Program
    {
        static void Main(string[] args)
        {
            //练习八：用方法来实现：计算两个数的最大值
            //思考：方法的参数？返回值？
            //计算任意多个数间的最大值(提示：params)
            //Console.WriteLine("请输入第一个数字：");
            //int n1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("请输入第二个数字：");
            //int n2 = int.Parse(Console.ReadLine());
            //int max = GetMax(n1, n2);
            //Console.WriteLine(max);
            int[] nums = { 1,2,3,4,5,6};
            int max = GetMax(nums);//可以放元素也可以放数组
            Console.WriteLine(max);
        }
        public static int GetMax(int n1,int n2)
        {
            return n1 > n2 ? n1 : n2;
        }

        //使用数组的方法
        public static int GetMax(params int[] nums)
        {
            int max = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i]>max)
                {
                    max = nums[i];
                }
            }
            return max;
        }
    }
}
