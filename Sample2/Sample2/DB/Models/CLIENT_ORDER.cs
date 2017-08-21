namespace Sample2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CLIENT_ORDER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CLIENT_ORDER()
        {
            ORDER_STATUS = new HashSet<ORDER_STATUS>();
        }

        [Key]
        public int OrderID { get; set; }

        [StringLength(20)]
        public string OrderDate { get; set; }

        [StringLength(10)]
        public string ReceiptNumber { get; set; }

        [StringLength(10)]
        public string Paid { get; set; }

        [StringLength(30)]
        public string OrderDescription { get; set; }

        [StringLength(20)]
        public string Colour { get; set; }

        [StringLength(30)]
        public string Material { get; set; }

        public int? BaseFee { get; set; }

        public int? LabourFee { get; set; }

        public int? Deposit { get; set; }

        public int? AlterationFee { get; set; }

        public int? ClientID { get; set; }

        public int? OrderTypeID { get; set; }

        public int? EmployeeID { get; set; }

        public int? EmployeeTypeID { get; set; }

        public virtual CLIENT CLIENT { get; set; }

        public virtual EMPLOYEE EMPLOYEE { get; set; }

        public virtual EMPLOYEE_TYPE EMPLOYEE_TYPE { get; set; }

        public virtual ORDER_TYPE ORDER_TYPE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ORDER_STATUS> ORDER_STATUS { get; set; }
    }
}
