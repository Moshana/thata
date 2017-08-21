namespace Sample2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GARMENT")]
    public partial class GARMENT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GARMENT()
        {
            FITTINGs = new HashSet<FITTING>();
        }

        [Key]
        public int DesignID { get; set; }

        [StringLength(20)]
        public string Colour { get; set; }

        [StringLength(20)]
        public string Material { get; set; }

        [StringLength(30)]
        public string GarmentDescripion { get; set; }

        [StringLength(10)]
        public string Price { get; set; }

        public int? Neck { get; set; }

        public int? Shoulders { get; set; }

        public int? ArmAround { get; set; }

        public int? ArmLength { get; set; }

        public int? Wrist { get; set; }

        public int? Chest { get; set; }

        public int? Bust { get; set; }

        public int? Waist { get; set; }

        public int? Hips { get; set; }

        public int? UpperThigh { get; set; }

        public int? LegLength { get; set; }

        public int? BodyLength { get; set; }

        public int? BackLength { get; set; }

        [StringLength(10)]
        public string WriteOff { get; set; }

        public int? DesignTypeID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FITTING> FITTINGs { get; set; }

        public virtual GARMENT_TYPE GARMENT_TYPE { get; set; }
    }
}
