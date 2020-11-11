using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 练习20
{
    class Program
    {
        static void Main(string[] args)
        {
            //练习二十：创建一个person类，属性：姓名、性别、年龄；
            //方法：sayhi().在创建一个employee类继承person类，扩展
            //属性salary，重写sayhi方法
        }
    }
    //创建person类
    public class Person
    {
        public string Name
        {
            get;
            set;
        }
        public char Gender
        {
            get;
            set;
        }
        public int Age
        {
            get;
            set;
        }

        public virtual void SayHi()
        {
            Console.WriteLine("父类打招呼");
        }
    }

    //创建员工类Employee继承person类
    public class Employee : Person
    {
        public double Salary
        {
            get;
            set;
        }
        public override void SayHi()
        {
            Console.WriteLine("子类重写父类");
        }
    }
}
