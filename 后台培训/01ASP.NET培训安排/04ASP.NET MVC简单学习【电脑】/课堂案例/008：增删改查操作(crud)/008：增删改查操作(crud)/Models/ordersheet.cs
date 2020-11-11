namespace _008_增删改查操作_crud_.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ordersheet")]
    public partial class ordersheet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ordersheet()
        {
            order_detail = new HashSet<order_detail>();
        }

        [Key]
        [StringLength(50)]
        public string order_id { get; set; }

        [StringLength(50)]
        public string username { get; set; }

        public DateTime? ordertime { get; set; }

        public DateTime? arrivetime { get; set; }

        [StringLength(10)]
        public string orderstate { get; set; }

        [StringLength(50)]
        public string receivername { get; set; }

        [StringLength(20)]
        public string receivertel { get; set; }

        [StringLength(50)]
        public string receiveraddr { get; set; }

        public int? number { get; set; }

        public int? paymoney { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<order_detail> order_detail { get; set; }

        public virtual user_register user_register { get; set; }
    }
}
