namespace _008_增删改查操作_crud_.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class order_detail
    {
        public int id { get; set; }

        [StringLength(50)]
        public string order_id { get; set; }

        [StringLength(50)]
        public string bh { get; set; }

        public int? sl { get; set; }

        public virtual ordersheet ordersheet { get; set; }
    }
}
