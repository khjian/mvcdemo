using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCDemo.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [FirstNameValidation]
        public string FirstName { get; set; }
        [StringLength(5,ErrorMessage ="Last Name length shoud not be greater than 5")]
        public string LastName { set; get; }
        public int? Salary { get; set; }
    }
}