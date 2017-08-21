namespace Sample2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SALE")]
    public partial class SALE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SALE()
        {
            PRODUCTs = new HashSet<PRODUCT>();
            SALE_RETURN = new HashSet<SALE_RETURN>();
        }

        public int SaleID { get; set; }

        [StringLength(20)]
        public string SaleDate { get; set; }

        [StringLength(10)]
        public string Price { get; set; }

        public int? Quantity { get; set; }

        [StringLength(10)]
        public string ReceiptNum { get; set; }

        [StringLength(10)]
        public string Item { get; set; }

        public int? ClientID { get; set; }

        public virtual CLIENT CLIENT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUCT> PRODUCTs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SALE_RETURN> SALE_RETURN { get; set; }
    }
}
