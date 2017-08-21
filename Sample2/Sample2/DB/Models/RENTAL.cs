namespace Sample2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RENTAL")]
    public partial class RENTAL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RENTAL()
        {
            FITTINGs = new HashSet<FITTING>();
            LATE_RETURN = new HashSet<LATE_RETURN>();
            RENTAL_STATUS = new HashSet<RENTAL_STATUS>();
        }

        public int RentalID { get; set; }

        public int? RentalPrice { get; set; }

        public int? Deposit { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EventDate { get; set; }

        public int? DepositRefund { get; set; }

        public DateTime? ReturnDate { get; set; }

        public DateTime? PickUpDate { get; set; }

        public int? AddExtra { get; set; }

        public int? ClientID { get; set; }

        public virtual CLIENT CLIENT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FITTING> FITTINGs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LATE_RETURN> LATE_RETURN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RENTAL_STATUS> RENTAL_STATUS { get; set; }
    }
}
