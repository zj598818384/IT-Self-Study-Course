using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 结构
{
    //声明结构类型
    public struct Preson
    {
        public string _name;//不是变量，而是字段，但是他们都是存储东西的
        public int _age;
        public Gerden _gender;
    }
    //声明枚举类型
    public enum Gerden
    {
        男,
        女
    }
    class Program
    {
        static void Main(string[] args)
        {
            //声明结构变量
            Preson zsPerson;
            //给结构里赋值
            zsPerson._name = "张三";
            zsPerson._age = 21;
            zsPerson._gender=Gerden.男;

            //声明结构变量
            Preson lsPerson;
            //给结构里赋值
            lsPerson._name = "李四";
            lsPerson._age = 21;
            lsPerson._gender =Gerden.女;
            Console.WriteLine(zsPerson._name);
            Console.WriteLine(lsPerson._name);
        }
    }
}
