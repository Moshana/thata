namespace Sample2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRODUCT")]
    public partial class PRODUCT
    {
        public int ProductID { get; set; }

        [StringLength(10)]
        public string Size { get; set; }

        [StringLength(20)]
        public string Colour { get; set; }

        [StringLength(30)]
        public string Product_Description { get; set; }

        [StringLength(10)]
        public string Price { get; set; }

        [StringLength(10)]
        public string SellingPrice { get; set; }

        [StringLength(10)]
        public string WriteOff { get; set; }

        public int? SaleReturnID { get; set; }

        public int? SaleID { get; set; }

        public int? ProductTypeID { get; set; }

        public int? ClientID { get; set; }

        public virtual CLIENT CLIENT { get; set; }

        public virtual PRODUCT_TYPE PRODUCT_TYPE { get; set; }

        public virtual SALE SALE { get; set; }

        public virtual SALE_RETURN SALE_RETURN { get; set; }
    }
}
