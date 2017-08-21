namespace Sample2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LATE_RETURN
    {
        [Key]
        public int LateReturnID { get; set; }

        [StringLength(30)]
        public string LateReturnDescription { get; set; }

        public int? DaysLate { get; set; }

        public int? RentalID { get; set; }

        public int? ClientID { get; set; }

        public virtual CLIENT CLIENT { get; set; }

        public virtual RENTAL RENTAL { get; set; }
    }
}
