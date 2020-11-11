using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习10
{
    class Program
    {
        static void Main(string[] args)
        {
            //练习十：用方法来实现：判断一个给点的整数是否为质数
            Console.WriteLine("请输入一个数字：");
            int n = int.Parse(Console.ReadLine());
            bool b = IsPrime(n);
            Console.WriteLine(b);
        }
        public static bool IsPrime(int n)
        {
            if (n<2)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    if (n%i==0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
