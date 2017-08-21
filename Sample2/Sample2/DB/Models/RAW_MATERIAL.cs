namespace Sample2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RAW_MATERIAL
    {
        [Key]
        public int RawMaterialID { get; set; }

        [StringLength(30)]
        public string RawDescription { get; set; }

        [StringLength(10)]
        public string CostPrice { get; set; }

        [StringLength(10)]
        public string MarkUp { get; set; }

        [StringLength(10)]
        public string WriteOff { get; set; }

        public int? RawMaterialTypeID { get; set; }

        public virtual RAW_MATERIAL_TYPE RAW_MATERIAL_TYPE { get; set; }
    }
}
