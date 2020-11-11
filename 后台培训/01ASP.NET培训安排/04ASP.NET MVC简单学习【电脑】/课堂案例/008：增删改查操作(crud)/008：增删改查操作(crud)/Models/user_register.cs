namespace _008_增删改查操作_crud_.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class user_register
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public user_register()
        {
            ordersheet = new HashSet<ordersheet>();
            shoppingcar = new HashSet<shoppingcar>();
        }

        [Key]
        [StringLength(50)]
        public string username { get; set; }

        [StringLength(20)]
        public string truename { get; set; }

        [StringLength(50)]
        public string password { get; set; }

        [StringLength(2)]
        public string sex { get; set; }

        [StringLength(50)]
        public string guding { get; set; }

        [StringLength(50)]
        public string mobile { get; set; }

        [StringLength(50)]
        public string qq { get; set; }

        public int? age { get; set; }

        public DateTime? birthday { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ordersheet> ordersheet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<shoppingcar> shoppingcar { get; set; }
    }
}
