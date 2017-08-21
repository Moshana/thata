namespace Sample2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FITTING")]
    public partial class FITTING
    {
        public int FittingID { get; set; }

        [StringLength(20)]
        public string FittingDate { get; set; }

        [StringLength(30)]
        public string FittingDescription { get; set; }

        public int? RentalID { get; set; }

        public int? ClientID { get; set; }

        public int? DesignID { get; set; }

        public int? DesignTypeID { get; set; }

        public virtual CLIENT CLIENT { get; set; }

        public virtual GARMENT GARMENT { get; set; }

        public virtual GARMENT_TYPE GARMENT_TYPE { get; set; }

        public virtual RENTAL RENTAL { get; set; }
    }
}
