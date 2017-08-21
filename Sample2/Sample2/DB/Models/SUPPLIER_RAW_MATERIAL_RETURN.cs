namespace Sample2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SUPPLIER_RAW_MATERIAL_RETURN
    {
        [Key]
        public int SupRawMatReturnID { get; set; }

        [StringLength(20)]
        public string DateSupRMReturn { get; set; }

        [StringLength(10)]
        public string AmountRefundable { get; set; }

        [StringLength(30)]
        public string DescripSupRMReturn { get; set; }
    }
}
