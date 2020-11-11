using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习05
{
    class Program
    {
        static void Main(string[] args)
        {
            //练习五：编写一个函数接收一个字符串把用户输入的字符
            //串中的第一个字母转换成大写然后返回(命名规范 帕斯卡)
            string s = "aAbcd";
            string sNew = ProcessStr(s);
            Console.WriteLine(sNew);
        }
        public static string ProcessStr(string str)
        {
            //将字符串的第一个字母转大写
            string s = str.Substring(0, 1).ToUpper();
            return s + str.Substring(1);
        }
    }
}
