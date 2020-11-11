using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF优化.Models
{
    public class Book
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Descr { get; set; }
        public DateTime CreateTime { get; set; } = DateTime.Now;

        [ForeignKey(nameof(BookType))]
        public long BookTypeId { get; set; }
        public BookType BookType { get; set; }
    }
}
