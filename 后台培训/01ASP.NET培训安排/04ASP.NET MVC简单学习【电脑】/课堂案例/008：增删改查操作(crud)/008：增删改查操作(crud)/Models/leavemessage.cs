namespace _008_增删改查操作_crud_.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("leavemessage")]
    public partial class leavemessage
    {
        [Key]
        public int fid { get; set; }

        [StringLength(255)]
        public string Mtype { get; set; }

        [StringLength(255)]
        public string Mname { get; set; }

        [StringLength(255)]
        public string Mphone { get; set; }

        [StringLength(255)]
        public string QQ { get; set; }

        [StringLength(255)]
        public string Mtitle { get; set; }

        [StringLength(255)]
        public string Mtext { get; set; }
    }
}
