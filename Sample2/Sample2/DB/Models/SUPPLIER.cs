namespace Sample2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SUPPLIER")]
    public partial class SUPPLIER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SUPPLIER()
        {
            SUPPLIER_ORDER = new HashSet<SUPPLIER_ORDER>();
        }

        public int SupplierID { get; set; }

        [Required]
        [StringLength(30)]
        public string SupplierName { get; set; }

        public int? SupplierPhone { get; set; }

        [StringLength(30)]
        public string SupplierAddressLine1 { get; set; }

        [StringLength(30)]
        public string SupplierAddressLine2 { get; set; }

        [StringLength(30)]
        public string SupplierEmail { get; set; }

        [StringLength(30)]
        public string SupplierBank { get; set; }

        [StringLength(30)]
        public string SupplierBranch { get; set; }

        public int? SupplierAccountNr { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SUPPLIER_ORDER> SUPPLIER_ORDER { get; set; }
    }
}
