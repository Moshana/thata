namespace Sample2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ORDER_STATUS
    {
        [Key]
        public int OrderStatusID { get; set; }

        [StringLength(20)]
        public string OrderStatusDate { get; set; }

        [StringLength(30)]
        public string OrderStatusDescription { get; set; }

        public int? ClientID { get; set; }

        public int? OrderID { get; set; }

        public int? OrderTypeID { get; set; }

        public int? EmployeeID { get; set; }

        public int? EmployeeTypeID { get; set; }

        public virtual CLIENT CLIENT { get; set; }

        public virtual CLIENT_ORDER CLIENT_ORDER { get; set; }

        public virtual EMPLOYEE EMPLOYEE { get; set; }

        public virtual EMPLOYEE_TYPE EMPLOYEE_TYPE { get; set; }

        public virtual ORDER_TYPE ORDER_TYPE { get; set; }
    }
}
