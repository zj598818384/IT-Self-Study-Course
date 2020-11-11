namespace _008_增删改查操作_crud_.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("getmoney")]
    public partial class getmoney
    {
        [Key]
        public int fid { get; set; }

        [StringLength(255)]
        public string bank_deposit { get; set; }

        [StringLength(255)]
        public string bank_account { get; set; }

        [StringLength(255)]
        public string payee { get; set; }
    }
}
