using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSystem.Models
{
    public class Book:BaseEntity
    {
        public string BookName { get; set; }
        public string Price { get; set; }

        //[ForeignKey(nameof(BookType))]
        //public long BookTypeId { get; set; }
        //public BookType BookType { get; set; }
    }
}
