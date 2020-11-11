using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace 序列化对象
{
    class Program
    {
        static void Main(string[] args)
        {
            //要将序列化对象的类，标记可以被序列化的

            //创建person对象
            //Person p = new Person();
            //p.Name = "张三";
            //p.Age = 15;
            //p.Grade = "男";
            //把person对象序列化成二进制
            //using (FileStream fsWrite = new FileStream(@"C:\Users\59881\Desktop\new\练习01.txt", FileMode.OpenOrCreate, FileAccess.Write))
            //{
            //    BinaryFormatter bf = new BinaryFormatter();
            //    bf.Serialize(fsWrite,p);
            //}
            //Console.WriteLine("序列化成功");

            //反序列化
            //解码成对象
            Person p;
            using (FileStream fsRead = new FileStream(@"C:\Users\59881\Desktop\new\练习01.txt", FileMode.OpenOrCreate, FileAccess.Read))
            {
                BinaryFormatter bf = new BinaryFormatter();
                p=(Person)bf.Deserialize(fsRead);//表示反序列化
            }
            Console.WriteLine(p.Name);
            Console.WriteLine(p.Age);
            Console.WriteLine(p.Grade);
        }
    }
    //表示可以被序列化
    [Serializable]
    public class Person
    {
        public string Name
        {
            get;
            set;
        }

        public int Age
        {
            get;
            set;
        }

        public string Grade
        {
            get;
            set;
        }
    }
}
