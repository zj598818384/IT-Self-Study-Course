using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法练习01
{
    class Program
    {
        static void Main(string[] args)
        {
            //练习一：读取输入的整数多次调用(如果用户输入的是数字，则返回，否则提示用户重新输入)
            Console.WriteLine("请输入一个数字：");
            string input = Console.ReadLine();
            int number=GetNumber(input);
            Console.WriteLine(number);
        }

        /// <summary>
        /// 这个方法需要判断用户的输入是否是数字
        /// 如果
        /// </summary>
        public static int GetNumber(string s)
        {
                while(true)
                {
                    try
                    {
                        int number = Convert.ToInt32(s);
                        return number;
                    }
                    catch
                    {
                        Console.WriteLine("请重新输入");
                        s = Console.ReadLine();
                    }
                }
        }
    }
}
