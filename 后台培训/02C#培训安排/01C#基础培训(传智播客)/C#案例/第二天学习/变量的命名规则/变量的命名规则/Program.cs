 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 加号的使用
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "李四";
            Console.WriteLine("你好，"+name);//加号起连接作用

            Console.WriteLine(5+5);//加号起相加作用


            //有个叫卡卡西的人在旅馆登记的时候前台让他填一张表
            //这张表里的内容要存到电脑上，
            //有姓名、年龄、邮箱、家庭住址、工资
            //之后把这些信息显示出来
            string name1 = "卡卡西";
            int age = 30;
            string email = "kakaxi@qq.com";
            string address = "火影村";
            decimal aslary = 5000m;
            Console.WriteLine("我叫：" + name1 + "，我住在：" + address + "，我今年：" + age + "岁了，我的邮箱：" + email + "我的工资是：" + aslary);
          
        }
    }
}
