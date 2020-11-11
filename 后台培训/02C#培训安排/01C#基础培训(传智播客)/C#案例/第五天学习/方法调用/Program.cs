using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法调用
{
    class Program
    {
        public static int _number = 10;//静态字段，全局字段，写在类中
        static void Main(string[] args)
        {
            int b = 10;
            int a = 3;
            int res=Test(a);//传递参数
            Console.WriteLine(res);
        }
        public static int Test(int a)
        {
            a = a + 5;
            return a;
        }
    }
}
