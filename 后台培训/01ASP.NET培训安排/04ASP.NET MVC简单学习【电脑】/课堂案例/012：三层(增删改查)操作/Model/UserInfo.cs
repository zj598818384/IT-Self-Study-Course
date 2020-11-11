namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserInfo")]
    public partial class UserInfo
    {
        public int id { get; set; }

        [Required]
        [StringLength(20)]
        public string CustomerID { get; set; }

        [Required]
        [StringLength(20)]
        public string CustomerPWD { get; set; }

        [Required]
        [StringLength(20)]
        public string CustomerType { get; set; }

        public int Score { get; set; }

        public int StatesId { get; set; }

        public virtual States States { get; set; }
    }
}
