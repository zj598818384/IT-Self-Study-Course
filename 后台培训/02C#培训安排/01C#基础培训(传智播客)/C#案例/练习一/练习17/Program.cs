using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 练习17
{
    class Program
    {
        static void Main(string[] args)
        {
            //练习十七：将字符串"hello       world,你  好   世界   !"两端空格去掉，
            //并且将其中的所有其他空格都替换成一个空格，输出结果为:
            //"hello world,你 好 世界 !"
            string s = "hello       world,你  好   世界   !";
            s=s.Trim();//去掉两端的空格
            //分割空格
            string[] sNew=s.Split(new char[] { ' '},StringSplitOptions.RemoveEmptyEntries);
            //添加一个空格
            string strNew=string.Join(" ",sNew);
            Console.WriteLine(strNew);
        }
    }
}
