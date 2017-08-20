using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample2
{
    public class EmployeeType
    {
        [Key]
        public int EmployeeTypeID { get; set; }
        public string EmployeeDescription { get; set; }
    }
}
