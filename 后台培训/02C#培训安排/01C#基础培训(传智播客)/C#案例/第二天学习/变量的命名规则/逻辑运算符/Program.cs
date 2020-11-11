using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 逻辑运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            //让用户输入老苏的语文和数学成绩，输出以下判断是否正确，正确输出true，错误输出false
            //1、老苏的语文和数学成绩都大于90分
            Console.WriteLine("请输入你的语文成绩：");
            //string strChinese = Console.ReadLine();
            int chinese = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入你的数学成绩：");
            int math = Convert.ToInt32(Console.ReadLine());
            bool b = chinese > 90 && math > 90;
            Console.WriteLine(b);
            //2、语文和数学有一门是大于90分
            Console.WriteLine("请输入你的语文成绩：");
            //string strChinese = Console.ReadLine();
            int chinese1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入你的数学成绩：");
            int math1 = Convert.ToInt32(Console.ReadLine());
            bool c = chinese1 > 90 || math1 > 90;
            Console.WriteLine(c);
        } 
    }
}
