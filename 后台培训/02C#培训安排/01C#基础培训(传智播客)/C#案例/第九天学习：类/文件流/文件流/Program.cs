using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace 文件流
{
    class Program
    {
        static void Main(string[] args)
        {
            //FileStream  StreamReader  StreamWriter

            //读取
            //using (FileStream fsRead = new FileStream(@"C:\Users\59881\Desktop\new\练习.txt", FileMode.OpenOrCreate, FileAccess.Read)) 
            //{
            //    byte[] buffer = new byte[1024*1024*5];
            //    //表示本次读取实际读取到的有效字节数
            //    int r = fsRead.Read(buffer,0,buffer.Length);
            //    string s = Encoding.Default.GetString(buffer,0,r);
            //    Console.WriteLine(s);
            //}
            //Console.WriteLine("读取成功");

            //写入
            using (FileStream fsWrite = new FileStream(@"C:\Users\59881\Desktop\new\练习01.txt", FileMode.Append, FileAccess.Write))
            {
                string s = "今天天气真好";
                byte[] buffer = Encoding.Default.GetBytes(s);
                fsWrite.Write(buffer, 0, buffer.Length);
            }
            Console.WriteLine("写入成功");

            //读取二
            //using (FileStream fsRead=new FileStream(@"C:\Users\59881\Desktop\new\练习01.txt",FileMode.OpenOrCreate,FileAccess.Read))
            //{
            //    using (StreamReader sr = new StreamReader(fsRead,Encoding.Default))
            //    {
            //        while (!sr.EndOfStream)
            //        {
            //            Console.WriteLine(sr.ReadLine());
            //        }
            //    }
            //}

            //写入二
            //byte[] buffer = new byte[1024 * 1024];
            //using (StreamWriter sw =new StreamWriter(@"C:\Users\59881\Desktop\new\练习01.txt", true,Encoding.Default,buffer.Length))
            //{
            //    sw.WriteLine("哈哈哈");
            //}
            //Console.WriteLine("写入成功");
        }
    }
}
