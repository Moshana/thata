namespace Sample2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SALE_RETURN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SALE_RETURN()
        {
            PRODUCTs = new HashSet<PRODUCT>();
        }

        [Key]
        public int SaleReturnID { get; set; }

        [StringLength(20)]
        public string SaleReturnDate { get; set; }

        public int? Quantity { get; set; }

        [StringLength(10)]
        public string RefundPrice { get; set; }

        [StringLength(10)]
        public string ReceiptNr { get; set; }

        public int? SaleID { get; set; }

        public int? ClientID { get; set; }

        public virtual CLIENT CLIENT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUCT> PRODUCTs { get; set; }

        public virtual SALE SALE { get; set; }
    }
}
