using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 练习19
{
    class Program
    {
        static void Main(string[] args)
        {
            //练习十九：请将字符串数组("中国","美国","巴西","澳大利亚","加拿大")
            //中国的内容反转。然后输出反转后的数组。不能用数组的reverse()方法
            string[] name = { "中国", "美国", "巴西", "澳大利亚", "加拿大" };
            for (int i = 0; i < name.Length/2; i++)
            {
                string temp = name[i];
                name[i] = name[name.Length - 1 - i];
                name[name.Length - 1 - i] = temp;
            }

            foreach (var item in name)
            {
                Console.WriteLine(item);
            }
        }
    }
}
