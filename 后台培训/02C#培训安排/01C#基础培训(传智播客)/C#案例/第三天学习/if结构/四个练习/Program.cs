using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 四个练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //比较3个数字的大小，不考虑相等。
            Console.Write("请输入第一个数：");
            int a = int.Parse(Console.ReadLine());
            Console.Write("请输入第二个数：");
            int b = int.Parse(Console.ReadLine());
            Console.Write("请输入第三个数：");
            int c = int.Parse(Console.ReadLine());
            if(a>b&&a>c)
            {
                Console.WriteLine("三个数中{0}最大",a);
            }
            if (b > c)
            {
                Console.WriteLine("三个数中{0}最大", b);
            }
            else
            {
                Console.WriteLine("三个数中{0}最大",c);
            }

            //提示用户输入密码，如果密码是"888888"则提示正确，否则提示错误。
            Console.WriteLine("请输入密码：");
            string pass = Console.ReadLine();
            if (pass == "888888")
            {
                Console.WriteLine("密码输入正确");
            }
            else
            {
                Console.WriteLine("密码输入错误");
            }

            //提示用户数入用户名，然后再提示输入密码，
            //如果用户名为"admin"时并且密码是"88888"，则提示正确，
            //否则，如果用户名不是"admin"还提示用户名不存在，
            //如果用户名时admin则提示密码错误
            Console.WriteLine("请输入你的用户名：");
            string name = Console.ReadLine();
            Console.WriteLine("请输入你的密码：");
            string mypass = Console.ReadLine();
            if(name=="admin"&&mypass=="88888")
            {
                Console.WriteLine("登录成功");
            }
            if(name!="admin"&&mypass=="88888")
            {
                Console.WriteLine("你所输入的用户名不存在，请重新输入");
            }
            if(name=="admin"&&mypass!="88888")
            {
                Console.WriteLine("你所输入的密码错误，请重新输入");
            }

            //提示用户输入年龄，如果大于等于18，则告知用户可以进行查看，
            //如果小于10岁，则告知不允许查看，
            //如果大于等于10岁并且小于18，则提示用户是否继续查看（yes，no），
            //如果输入的是yes则提示用户请查看，否则提示"退出，你以放弃查看"。
            Console.WriteLine("请输入你的年龄：");
            int age = int.Parse(Console.ReadLine());
            if(age>=18)
            {
                Console.WriteLine("可以进行查看");
            }
            if(age<10)
            {
                Console.WriteLine("不可以进行查看");
            }
            if(age>=10&&age<18)
            {
                Console.WriteLine("请问你是否继续进行查看，是请输入(yes)，否请输入(no)");
                string g = Console.ReadLine();
                if(g=="yes")
                {
                    Console.WriteLine("请进行查看");
                }
                else
                {
                    Console.WriteLine("退出，你以放弃查看");
                }
            }
        }
    }
}
