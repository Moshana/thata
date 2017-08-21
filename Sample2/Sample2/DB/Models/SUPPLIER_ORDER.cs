namespace Sample2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SUPPLIER_ORDER
    {
        [Key]
        public int SupplierOrderID { get; set; }

        [StringLength(20)]
        public string SupOrderDate { get; set; }

        [StringLength(10)]
        public string AmountPayable { get; set; }

        public int? SupplierID { get; set; }

        public int? SupOrderStatusID { get; set; }

        public virtual SUPPLIER SUPPLIER { get; set; }

        public virtual SUPPLIER_ORDER_STATUS SUPPLIER_ORDER_STATUS { get; set; }
    }
}
