using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 关系运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            //大象的重量(1500)>老鼠的重量(1)
            //关系表达式的结果是bool类型
            bool b = 1500 > 1;
            Console.WriteLine(b);

            //兔子的寿命(3)>乌龟的寿命(1000)
            bool a = 3 > 5000;
            Console.WriteLine(a);
            //39<18
            bool c = 39<18;
            Console.WriteLine(c);
            //我的年龄(20)==你的年龄(20)
            bool d = 20 == 20;
            Console.WriteLine(d);
        }
    }
}
