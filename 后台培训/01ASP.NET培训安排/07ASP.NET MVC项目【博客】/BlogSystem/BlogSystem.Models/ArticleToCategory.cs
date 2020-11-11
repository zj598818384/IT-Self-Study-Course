using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSystem.Models
{
    public class ArticleToCategory:BaseEntity
    {
        [ForeignKey(nameof(BlogCategroy))]
        public Guid BlogCategoryId { get; set; }
        public BlogCategroy BlogCategroy { get; set; }

        [ForeignKey(nameof(Artricle))]
        public Guid ArticleId { get; set; }
        public Article Artricle { get; set; }

    }
}
