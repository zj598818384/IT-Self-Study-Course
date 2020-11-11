using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 三个练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //1、让用户输入年龄，如果输入的年龄大于等于23岁，
            //则给用户显示你到了结婚的年龄了。
            Console.WriteLine("请输入你的年龄：");
            int age = int.Parse(Console.ReadLine());
            if(age>=23)
            {
                Console.WriteLine("结婚去吧，孩子");
            }
            Console.WriteLine();

            //如果老苏的（Chinese music）语文成绩大于90并且音乐成绩
            //大于80；或者语文成绩等于100并且音乐成绩大于70，
            //则奖励100元。
            Console.WriteLine("请输入你的语文成绩：");
            int chinese = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入你的音乐成绩：");
            int music = int.Parse(Console.ReadLine());
            if((chinese>90&&music>80)||(chinese==100&&music>70))
            {
                Console.WriteLine("考的不错，奖励100元");
            }
            Console.WriteLine();

            //让用户输入用户名和密码，如果用户名为admin，
            //密码为mypass，则提示登录成功。
            Console.WriteLine("请输入你的用户名：");
            string a = Console.ReadLine();
            Console.WriteLine("请输入你的密码：");
            string m = Console.ReadLine();
            if(a=="admin"&&m=="mypass")
            {
                Console.WriteLine("登录成功");
            }
        }
    }
}
