namespace _008_增删改查操作_crud_.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class news
    {
        public int id { get; set; }

        [StringLength(255)]
        public string title { get; set; }

        [StringLength(800)]
        public string content { get; set; }

        [StringLength(20)]
        public string author { get; set; }

        public DateTime? publish_dt { get; set; }
    }
}
