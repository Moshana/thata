using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample2
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeSurname { get; set; }
        public string EmployeePhone { get; set; }
        public string EmployeeAddress { get; set; }
        public string EmployeeEmail { get; set; }
        public string UserName { get; set; }
        public string EmployeePassword { get; set; }
        public virtual EmployeeType EmployeeTypeID { get; set; }
        public string AccessLevel { get; set; }

        
    }
}
