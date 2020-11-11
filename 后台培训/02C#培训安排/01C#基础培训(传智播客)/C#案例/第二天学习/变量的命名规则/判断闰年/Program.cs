using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 判断闰年
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个年份：");
            int year=Convert.ToInt32(Console.ReadLine());
            //年份能够被400整除（2000）
            //年份能够被4整除但不能被100整除（2008）
            //不加括号没出错是因为逻辑与的优先级高于逻辑或
            bool a = (year % 400==0 )|| (year % 4 == 0 && year % 100 != 0);
            Console.WriteLine(a);
        }
    }
}
