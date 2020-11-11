using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace 文件类练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //案例：对职工工资文件处理，所有人的工资加倍然后输出到新文件
            //文件案例：
            //马大哈|3000
            //宋江|8000s

            string[] str=File.ReadAllLines(@"C:\Users\59881\Desktop\new\工资.txt",Encoding.Default);
            //遍历当前字符串数组
            for (int i = 0; i < str.Length; i++)
            {
                //张三|8000
                string[] strNew=str[i].Split(new char[] { '|'},StringSplitOptions.RemoveEmptyEntries);
                int salary=int.Parse(strNew[1]) * 2;
                str[i] = strNew[0] + salary.ToString();
                //File.WriteAllLines(strNew[0] + salary.ToString());
            }
            File.WriteAllLines(@"C:\Users\59881\Desktop\new\工资.txt",str);
            Console.WriteLine("完成");
        }
    }
}
