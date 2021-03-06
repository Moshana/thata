namespace Sample2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EMPLOYEE")]
    public partial class EMPLOYEE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EMPLOYEE()
        {
            CLIENT_ORDER = new HashSet<CLIENT_ORDER>();
            ORDER_STATUS = new HashSet<ORDER_STATUS>();
        }

        public int EmployeeID { get; set; }

        [Required]
        [StringLength(30)]
        public string EmployeeName { get; set; }

        [Required]
        [StringLength(30)]
        public string EmployeeSurname { get; set; }

        public int? EmployeePhone { get; set; }

        [Required]
        [StringLength(100)]
        public string EmployeeAddress { get; set; }

        [StringLength(50)]
        public string EmployeeEmail { get; set; }

        [StringLength(20)]
        public string Username { get; set; }

        [StringLength(10)]
        public string EmployeePassword { get; set; }

        [StringLength(20)]
        public string AccessLevel { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLIENT_ORDER> CLIENT_ORDER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ORDER_STATUS> ORDER_STATUS { get; set; }
    }
}
