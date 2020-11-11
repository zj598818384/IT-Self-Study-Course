using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 异常捕获
{
    class Program 
    {
        static void Main(string[] args)
        {
            //语法上没有错误，在程序运行的过程当中，
            //由于某些原因程序出现了错误，不能再正常的运行。
            bool bo = true;
            int number=0;//声明了一个变量
            Console.WriteLine("请输入一个数字：");
            try
            {
                number = int.Parse(Console.ReadLine());//赋值
            }
            catch
            {
                Console.WriteLine("输入的内容不能够装换成数字");
                bo = false;
            }
            //我们如果要执行下面这行代码，需要满足某些条件
            //让代码满足某些条件去执行官的话，使用bool类型
            if(bo)
            {
                Console.WriteLine(number * 2);//使用
            }
            Console.ReadLine();
        }
    }
}
