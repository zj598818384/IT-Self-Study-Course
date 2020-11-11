using _001_webapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _001_webapi.Controllers
{
    public class StudentsController : ApiController
    {
        public List<Student> Get()
        {
            return new List<Student>()
            {
                new Student() { id = 1,name="shatao" },
                new Student() { id = 2,name="shatao" },
                new Student() { id = 3,name="shatao" },
             };
        }

        //采用get传输数据的时候要带上get
        //不一定需要是id，也可以是其他参数
        //需要在控制器后面传入?name=abc
        //在地址栏中?表示Querystring查询字符串
        public string Get(string name)
        {
            return "你传入的参数是" + name;
        }

        //只需要更改传过去的参数名
        //采用restful风格的方式，方法名需要加上get关键字
        public string GetAddress(string address)
        {
            return "你传入的参数是11：" + address;
        }

        //新增数据
        public void Post(Student stu)
        {
            //抛异常
            throw new Exception(message: "错误");
        }

        //修改
        //修改数据需要传值，id等等
        public void Put(int id, string name, Student stu)
        {
            //id：获取的是1
            //name：获取的是taotao
            //student对象里面获取的是 :12 list
            //id需要通过地址栏的querystring里面进行传递
        }


        //删除
        public void Delete(int id)
        {
            //通过地址栏传入需要删除的id
        }
    }
}
