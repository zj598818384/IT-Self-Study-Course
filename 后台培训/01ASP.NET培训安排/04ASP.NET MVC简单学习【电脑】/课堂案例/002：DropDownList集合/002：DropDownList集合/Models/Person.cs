using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _002_DropDownList集合.Models
{
    public class Person
    {
        public string QQ { get; set; }
        public int Age { get; set; }
        public void Run()
        {

        }
    }

    //扩展方法
    public static class Class1
    {
        //这个text方法被扩展到Person类上去
        public static void Text(this Person person,string age)
        {

        }
    }
}