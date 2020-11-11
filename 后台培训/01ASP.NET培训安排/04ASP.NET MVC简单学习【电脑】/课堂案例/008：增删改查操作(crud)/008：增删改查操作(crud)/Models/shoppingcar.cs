namespace _008_增删改查操作_crud_.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("shoppingcar")]
    public partial class shoppingcar
    {
        public int id { get; set; }

        [StringLength(50)]
        public string username { get; set; }

        [StringLength(5)]
        public string bh { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        [StringLength(255)]
        public string zp { get; set; }

        public int? price { get; set; }

        public int? sl { get; set; }

        public virtual user_register user_register { get; set; }
    }
}
