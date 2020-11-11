using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _011_CodeFirst_代码优先_.Models
{
    public class BookInfo1
    {
        [Key]
        public int BookId { get; set; }
        [StringLength(50)]
        public string BookTitle { get; set; }
        [ForeignKey("BookType1")]
        public int TypeId { get; set; }

        public virtual BookType1 BookType1 { get; set; }
    }
}