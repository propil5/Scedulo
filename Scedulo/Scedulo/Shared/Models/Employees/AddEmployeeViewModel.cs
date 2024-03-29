using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Scedulo.Shared.Models.Employees
{
    public class AddEmployeeViewModel
    {
        [Required]
        [Display(Name = "User")]
        public string UserId { get; set; }
        [Display(Name = "Email")]
        public DateTimeOffset EmploymentDate { get; set; }
        [Display(Name = "Email")]
        public DateTimeOffset? ContractEndDate { get; set; }
        [Display(Name = "Email")]
        [Range(0, 99999.99)]
        public double BaseMonthSalary { get; set; }
    }
}