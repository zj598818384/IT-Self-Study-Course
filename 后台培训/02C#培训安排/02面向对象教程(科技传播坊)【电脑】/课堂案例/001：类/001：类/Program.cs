using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_类
{
    //partial：部分类
    //自定义类
    partial class DashBorad//仪表盘
    {
        //部分方法
        partial void Func();

        //string id = Guid.NewGuid().ToString();
        readonly string id = "123";
        //嵌套类
        public class Borad { }
        //静态构造器
        static DashBorad()
        {
            Sum = 10;
            Console.WriteLine("进入了static构造器");
        }
        public static long Sum { get; set; }//总计数
        public static void ResetSum() { Sum = 0; }
        private  DashBorad()
        {
            this.Reset();//复位
        }
        //这个方法是构造函数没有返回值，系统会自己帮你写
        //当你写了这个，那么那个默认的无参数的那个函数就不存在了，当然也可以用重载的方式写出来
        //public DashBorad(string name):this()//this代表的就是DashBorad()这个函数
        //{
        //    if (string.IsNullOrEmpty(name))
        //    {
        //        this.Name = "unknow";
        //    }
        //    else
        //    {
        //        this.Name = name;
        //    }
        //}

        private static DashBorad _DashBorad = null;
        public static DashBorad Instance//实例
        {
            get
            {
                if (_DashBorad == null)
                    _DashBorad = new DashBorad();
                return _DashBorad;
            }
        }
        //定义字段
        private double Value;//表盘读数
        private List<零件> 零件s;
        public string Name { get; set; }
        //智能的写法
        //public string Name
        //{
        //    get
        //    {
        //        return _Name;
        //    }
        //    set {
        //        if (string.IsNullOrEmpty(value))
        //        {
        //            throw new ArgumentException();
        //        }
        //        _Name = value;
        //    }
        //}//表盘名称

        //在C#的写法
        //繁琐的写法
        //public string Name//属性
        //{
        //    get { return _Name; }
        //    set { _Name = value; }//上下文关键字，类似于value
        //    //总共有两种关键字：一种普通关键字，一种上下文关键字
        //}



        //在C的写法
        //getter/setter
        //访问器
        //public string GetName()
        //{
        //    return this.Name;//this表示指代更明确
        //}

        //public void SetName(string Name)
        //{
        //    this.Name = Name;
        //}

        public double GetValue()//方法
        {
            return this.Value;//this表示当前
        }

        //指针转动
        public void Rotate(double angle)//给一个指针转动的度数
        {
            Value = angle;
            Console.WriteLine("指针转动了{0}度", angle);
        }

        //指针复位
        public void Reset()
        {
            Value = 0;
            Console.WriteLine("{0},表盘复位完成",this.Name);
        }

        public void ShowValue()
        {
            Console.WriteLine("当前表盘读数{0}",Value);
        }

        //将表盘读数存储到数据库
        public bool Save()
        {
            数据库 database = new 数据库();
            return database.Store(this);//当前的this代表的是自己本身这个对象，就把自己传出去
        } 
    }

    class 零件
    {

    }

    class 数据库
    {
        //存储当前仪表盘的读数
        public bool Store(DashBorad ds)
        {
            //ds.GetValue();
            return true;
        }
    }

    //值类型，引用类型，而class是自定义类型

    class Program
    {
        static void Main(string[] args)
        {
            //实例化new
            //这个方法在你创建前，系统会自动帮你创建
            //DashBorad ds = new DashBorad("压力表盘");//构造器
            var ds1 = DashBorad.Instance;//对象初始化器
            ds1.Name = "xx";
            Console.WriteLine(ds1.Name);
            ds1.Rotate(10.0);
            ds1.ShowValue();
            DashBorad.Sum += 20;//由于sum已经是一个引用类型了，所有不需要再用ds1来点出，直接使用DashBorad点出就行了

            var ds2 = DashBorad.Instance;//对象初始化器
            Console.WriteLine(ds2.Name);
            ds2.Rotate(10.0);
            ds2.ShowValue();
            DashBorad.Sum += 20;

            DashBorad.ResetSum();//总计清零

            //嵌套类的实例化
            DashBorad.Borad b = new DashBorad.Borad();
            Console.Read();

            //扩展：匿名对象：就是没有名字的对象
            var user = new { Name = "zzz", Age = "1" };
        }
    }
}
