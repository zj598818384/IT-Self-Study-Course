namespace _008_增删改查操作_crud_.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class flower_detail
    {
        [Key]
        [StringLength(5)]
        public string bh { get; set; }

        public int? flower_id { get; set; }

        public int? ft_id { get; set; }

        [StringLength(20)]
        public string name { get; set; }

        [StringLength(100)]
        public string material { get; set; }

        [StringLength(255)]
        public string package { get; set; }

        public int? market_price { get; set; }

        public int? price { get; set; }

        [StringLength(255)]
        public string flower_language { get; set; }

        [StringLength(255)]
        public string remarks { get; set; }

        [StringLength(255)]
        public string zp { get; set; }

        public int? count { get; set; }

        public virtual flower_type flower_type { get; set; }
    }
}
