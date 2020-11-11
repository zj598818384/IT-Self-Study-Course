using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace File类
{
    class Program
    {
        static void Main(string[] args)
        {
            //操作文件
            //复制、剪切、创建、移除

            //创建文件
            //File.Create(@"C:\Users\59881\Desktop\new.txt");
            //Console.WriteLine("创建成功");

            //删除文件
            //File.Delete(@"C:\Users\59881\Desktop\new.txt");
            //Console.WriteLine("删除成功");

            //复制文件
            //File.Copy(@"C:\Users\59881\Desktop\new\练习(查询+增删改）.txt", @"C:\Users\59881\Desktop\new\练习.txt");
            //Console.WriteLine("复制成功");

            //剪切文件
            //File.Move(@"C:\Users\59881\Desktop\new\练习(查询+增删改）.txt", @"C:\Users\59881\Desktop\new\练习01.txt");
            //Console.WriteLine("剪切成功");

            //-------------------------------File类的读取--------------------------------------------
            //使用File类来读取数据
            //byte[] buffer= File.ReadAllBytes(@"C:\Users\59881\Desktop\new\练习01.txt");
            // string str = Encoding.Default.GetString(buffer,0,buffer.Length);
            // //编码(Encoding.Default)：就是把字符串以怎样的形式存储为二进制
            // Console.WriteLine(str);

            //遍历
            //string[] str = File.ReadAllLines(@"C:\Users\59881\Desktop\new\练习01.txt",Encoding.Default);
            //for (int i = 0; i < str.Length; i++)
            //{
            //    Console.WriteLine(str[i]);
            //}

            //读取方法三：
            //string str = File.ReadAllText(@"C:\Users\59881\Desktop\new\练习01.txt",Encoding.Default);
            //Console.WriteLine(str);

            //-------------------------------File类的写入--------------------------------------------
            //方法一：
            //string str = "今天是和二哈在一起的219天";
            //byte[] buffer = Encoding.Default.GetBytes(str);
            //File.WriteAllBytes(@"C:\Users\59881\Desktop\new\练习01.txt",buffer);
            //Console.WriteLine("写入成功");

            //方法二：
            //File.WriteAllLines(@"C:\Users\59881\Desktop\new\练习01.txt",new string[] { "张三","李四","王五","赵六"});
            //Console.WriteLine("写入成功");

            //方法三：
            //File.WriteAllText(@"C:\Users\59881\Desktop\new\练习01.txt","今天还是比较凉快的");
            //Console.WriteLine("写入成功");

            //方法四：
            File.AppendAllText(@"C:\Users\59881\Desktop\new\练习01.txt","没有覆盖哟~");
            Console.WriteLine("追加成功");
        }
    }
}
