using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数据类型的转换
{
    class Program
    {
        static void Main(string[] args)
        {
            //显示类型转换、自动类型转换
            //int--double   double--int

            string s = "123";
            //将字符串转换成int或者double类型
            double d = Convert.ToInt32(s);
            int n = Convert.ToInt32(s);
            Console.WriteLine(n);
            Console.WriteLine(d);
        }
    }
}
