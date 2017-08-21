namespace Sample2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RENTAL_STATUS
    {
        [Key]
        public int RentalStatusID { get; set; }

        [StringLength(20)]
        public string RentalStatusDescription { get; set; }

        [StringLength(30)]
        public string RentalStatusDate { get; set; }

        public int? RentalID { get; set; }

        public int? ClientID { get; set; }

        public virtual CLIENT CLIENT { get; set; }

        public virtual RENTAL RENTAL { get; set; }
    }
}
