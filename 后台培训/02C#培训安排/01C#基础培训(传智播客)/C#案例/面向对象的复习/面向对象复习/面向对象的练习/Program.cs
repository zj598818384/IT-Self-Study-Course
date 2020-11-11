using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面向对象的练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //练习一：定义父亲类Father(姓lastName，财产property，血型bloodType)
            //儿子Son类(玩游戏PlayGame方法)
            //女儿Daughter类(跳舞Dance方法)
            //调用父亲构造函数(:base())给子类字段赋值
        }
    }
    
    public class Father
    {
        private string _LastName;
        public string LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                _LastName = value;
            }
        }
        private decimal _property;
        public decimal Property
        {
            get
            {
                return _property;
            }
            set
            {
                _property = value;
            }
        }
        private string _bloodType;
        public string BloodType
        {
            get
            {
                return _bloodType;
            }
            set
            {
                _bloodType = value;
            }
        }
        public Father(string lastName,decimal property,string bloodType)
        {
            this.LastName = lastName;
            this.Property = property;
            this.BloodType = bloodType;
        }
    }
}
