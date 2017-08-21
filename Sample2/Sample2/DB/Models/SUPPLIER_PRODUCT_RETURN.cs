namespace Sample2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SUPPLIER_PRODUCT_RETURN
    {
        [Key]
        public int SupProductReturnID { get; set; }

        [StringLength(20)]
        public string DateSupProductReturn { get; set; }

        [StringLength(10)]
        public string AmountRefundable { get; set; }

        [StringLength(30)]
        public string DescripSupProductReturn { get; set; }
    }
}
