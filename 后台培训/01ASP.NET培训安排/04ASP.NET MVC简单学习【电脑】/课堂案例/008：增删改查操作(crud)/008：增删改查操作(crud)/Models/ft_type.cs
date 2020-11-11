namespace _008_增删改查操作_crud_.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ft_type
    {
        public int ID { get; set; }

        public int ft_id { get; set; }

        public int? flower_id { get; set; }

        [StringLength(20)]
        public string ft_name { get; set; }

        public virtual flower_type flower_type { get; set; }
    }
}
