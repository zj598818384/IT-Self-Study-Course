using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_继承
{
    //base和this
    //class A
    //{
    //    public A() { Console.WriteLine("A()"); }
    //    public A(string a) : this() { Console.WriteLine("A(string)"); }
    //    public A(int a) : this("123") { Console.WriteLine("A(int)"); }
    //}

    //class B :A
    //{
    //    public B():base(123) { Console.WriteLine("B()"); }
    //}

    class SecretData//隐私数据
    {
        public int Age { get; set; }
    }
    //需要被继承的类的类叫做基类、父类或者超类
    //需要继承的类叫做派生类或者子类
    //而中间的过程叫做派生或继承

    //Sealed就是密封类，无法进行继承操作
    class Animal//抽象概念
    {
        protected SecretData SecretData = new SecretData() { Age=1};
        public string Name { get; set; }//has-a有 一个

        //虚函数
        public virtual void Shout() { Console.WriteLine("未知的叫声"); }

    }

    //封装
    //继承
    class Dog:Animal//is-a是一个
    {
        //覆写：覆盖之前同名方法
        public override void Shout() { Console.WriteLine("{0}岁的"+this.Name+":汪汪",SecretData.Age); }
    }

    class Cat:Animal
    {
        public void Shout() { Console.WriteLine(this.Name+":喵喵"); }
    }


    class Program
    {
        //【多态】
        //多态：一个方法实现多种效果
        static void Test(Animal animal)
        {
            Console.WriteLine(animal.Name);
            animal.Shout();
        }
        static void Main(string[] args)
        {
            Animal dog = new Cat() { Name = "小黑" };
            Test(dog);
            //A b = new A(123);
            //var dog = new Dog() { Name = "小黑" };
            //dog.Shout();
            //var cat = new Cat() { Name = "小白" };
            //cat.Shout();

            //基类往子类转换
            //运用了多态
            //Animal animal = new Dog() { Name = "小黑" };
            //Console.WriteLine(animal.Name );


            Console.Read();
        }
    }
}
