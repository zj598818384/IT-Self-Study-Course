using BookSystem.DAL;
using BookSystem.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 测试
{
    class Program
    {
        static void Main(string[] args)
        {
            using (IBookTypeService bsvc = new BookTypeService())
            {
                //添加数据
                bsvc.Add(new BookSystem.Models.BookType { Name = "aaaa" });
                foreach (var item in bsvc.GetAll())
                {
                    Console.WriteLine(item.Name);
                }
            }
        }
    }
}
