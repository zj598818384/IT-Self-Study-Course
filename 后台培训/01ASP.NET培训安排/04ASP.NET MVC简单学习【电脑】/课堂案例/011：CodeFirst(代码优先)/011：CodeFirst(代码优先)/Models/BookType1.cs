using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _011_CodeFirst_代码优先_.Models
{
    public class BookType1
    {
        public BookType1()
        {
            BookInfo1 = new HashSet<BookInfo1>();
        }
        [Key]
        public int TypeID { get; set; }
        public string TypeTitle { get; set; }

        //被virtual修饰的导航属性可以进行延迟加载
        public virtual ICollection<BookInfo1> BookInfo1 { get; set; }
    }
}