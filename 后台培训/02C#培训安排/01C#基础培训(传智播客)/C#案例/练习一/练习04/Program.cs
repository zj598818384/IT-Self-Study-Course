using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习04
{
    class Program
    {
        static void Main(string[] args)
        {
            //练习四：编写一个函数，接收一个字符串，把用户输入的字符串中的第一个字母转换成小写然后返回(命名规范 骆驼命名法)
            //name    s.SubString(0,1);      s.SubString(1);
            string s = "AAbcd";
            string sNew = ProcessStr(s);
            Console.WriteLine(sNew);
        }

        public static string ProcessStr(string str)
        {
            //将字符串的第一个字母转小写
            string s=str.Substring(0, 1).ToLower();
            return s + str.Substring(1);
        }
    }
}
