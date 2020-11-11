using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EF优化.Models
{
    public class BookType
    {
        public long Id { get; set; }
        [StringLength(20),Required]
        public string Name { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}
