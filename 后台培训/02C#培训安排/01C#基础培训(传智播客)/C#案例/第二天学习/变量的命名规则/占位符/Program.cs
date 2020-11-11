using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 占位符
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 10;
            int n2 = 20;
            int n3 = 30;
            Console.WriteLine("第一个数字：{0}，第二个数字：{1}，第三个数字：{2}",n1,n2,n3);
            //Console.WriteLine("第一个数字是："+n1+"第二个数字是："+n2+"第三个数字是："+n3);
            string name1 = "卡卡西";
            int age = 30;
            string email = "kakaxi@qq.com";
            string address = "火影村";
            decimal aslary = 5000m;
            Console.WriteLine("我叫{0}，我今年{1}岁了，我住在{2}，我的邮箱是{3}，我的工资是{4}", name1, address, age, email, aslary);

            //定义两个变量如：number1，
            //number2分别赋值为10和5，写成程序交换两个变量的值
            int number1 = 10;
            int number2 = 5;
            int number3;
            number3 = number1;
            number1 = number2;
            number2 = number3;
            Console.WriteLine("number1:{0},number2:{1}",number1,number2);
        }
    }
}
