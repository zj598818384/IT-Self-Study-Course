using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面向对象的概念
{
    public class person
    {
        public string _name;
        public int _age;
        public char _gerder;

        public void chlss()
        {
            Console.WriteLine("我叫{0},我今年{1}岁了，我是{2}生",this._name,this._age,this._gerder);
        }
    }
}
