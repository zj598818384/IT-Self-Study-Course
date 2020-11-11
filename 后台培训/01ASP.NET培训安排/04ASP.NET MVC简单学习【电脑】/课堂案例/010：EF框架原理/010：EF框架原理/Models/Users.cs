namespace _010_EF框架原理.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Users
    {
        [Key]
        public string Username { get; set; }

        public string Truename { get; set; }

        public string Password { get; set; }

        [StringLength(11)]
        public string Phone { get; set; }

        public int? Age { get; set; }
    }
}
