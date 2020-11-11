using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSystem.Models
{
    public class BookType:BaseEntity
    { 
        [StringLength(20), Required]
        public string Name { get; set; }
    }
}
