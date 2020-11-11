using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directory类
{
    class Program
    {
        static void Main(string[] args)
        {
            //File   Path  FlieStream  StreamReader  StreamWriter
            //Directory 文件夹 目录

            //创建文件夹
            //Directory.CreateDirectory(@"C:\Users\59881\Desktop\a");
            //Console.WriteLine("创建成功");
            //Console.ReadKey();

            //删除文件夹
            //Directory.Delete(@"C:\Users\59881\Desktop\a",true);
            //Console.WriteLine("删除成功");
            //Console.ReadKey();

            //剪切文件夹
            //Directory.Move(@"C:\Users\59881\Desktop\a", @"C:\Users\59881\Desktop\new");
            //Console.WriteLine("剪切成功");
            //Console.ReadLine();

            //获得指定文件夹下所有的文件的全路径
            //"*.txt"筛选该类型的文件
            //string[] path=Directory.GetFiles(@"C:\Users\59881\Desktop\new","*.txt");
            //for (int i = 0; i < path.Length; i++)
            //{
            //    Console.WriteLine(path[i]);
            //}
            //Console.ReadKey();

            //获得指定目录下所有文件夹的全路径
            //string[] path=Directory.GetDirectories(@"C: \Users\59881\Desktop\a");
            //for (int i = 0; i < path.Length; i++)
            //{
            //    Console.WriteLine(path[i]);
            //}
            //Console.ReadKey();

            //判断指定的文件夹是否存在
            //if (Directory.Exists(@"C: \Users\59881\Desktop\a\b"))
            //{
            //    for (int i = 0; i < 100; i++)
            //    {
            //        Directory.CreateDirectory(@"C: \Users\59881\Desktop\a\b"+i);
            //    }
            //}
            //Console.WriteLine("OK");
            //Console.ReadKey();

            Directory.Delete(@"C: \Users\59881\Desktop\a\1", true);
            Console.ReadKey();
        }
    }
}
