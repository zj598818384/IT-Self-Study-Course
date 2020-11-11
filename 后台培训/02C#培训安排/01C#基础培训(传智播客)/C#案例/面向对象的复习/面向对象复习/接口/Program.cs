using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接口
{
    class Program
    {
        static void Main(string[] args)
        {
            //接口是什么?什么时候使用接口？使用接口的目的是什么？目的是实现多态
            IFlyable fly = new Plane();//new Bird();
            fly.Fly();
            
        }
    }
    public interface IFlyable
    {
        void Fly();
    }
    public class Bird
    {
        //public void Fly()
        //{
        //    Console.WriteLine("大多数鸟都会飞");
        //}
    }
    //public class QQ : Bird
    //{

    //}
    //当一个类继承多个类的时候，应当将父类写在前面
    public class Maque : Bird,IFlyable
    {
        //这个函数是子类自己的
        public void Fly()
        {
            Console.WriteLine("鸟会飞");
        }
        //这个函数是接口的
        void IFlyable.Fly()
        {
            Console.WriteLine("实现的接口的飞方法");
        }
    }

    public class Plane : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("飞机会飞");
        }
    }
}
