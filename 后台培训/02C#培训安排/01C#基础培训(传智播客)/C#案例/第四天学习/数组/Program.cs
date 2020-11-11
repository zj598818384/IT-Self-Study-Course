using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数组
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] str = new string[10];//初值为null
            bool[] bo = new bool[10];//初值为false
            //数组的声明方式
            int[] nums=new int[10];//初值为0
            int[] numsTwo = { 1,2,3,4,5};
            int[] numsThree = new int[3] { 1,2,3};
            int[] numsFour = new int[] { 1,2,3,1,2,3};
            //通过循环给数组赋值，同样，也通过一个循环对数字进行取值
            for (int i = 0; i < 10; i++)
            {
                nums[i] = i;
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
    }
}
