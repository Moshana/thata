namespace Sample2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SUPPLIER_ORDER_STATUS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SUPPLIER_ORDER_STATUS()
        {
            SUPPLIER_ORDER = new HashSet<SUPPLIER_ORDER>();
        }

        [Key]
        public int SupOrderStatusID { get; set; }

        [StringLength(20)]
        public string SupStatusDate { get; set; }

        [StringLength(30)]
        public string SupStatusDescription { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SUPPLIER_ORDER> SUPPLIER_ORDER { get; set; }
    }
}
