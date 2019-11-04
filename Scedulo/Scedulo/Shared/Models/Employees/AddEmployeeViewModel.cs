using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Scedulo.Shared.Models.Employees
{
    public class AddEmployeeViewModel
    {
        [Required]
        [Display(Name = "User")]
        public String UserId { get; set; }
        [Display(Name = "Email")]
        public string FirstName {get; set;}
        [Display(Name = "Email")]
        public string SecondName {get; set;}
        [Display(Name = "Email")]
        public string Surname {get; set;}
        [Display(Name = "Email")]
        public IdentityUser[] Users {get; set;}
        [Display(Name = "Email")]
        public DateTimeOffset EmploymentDate { get; set; }
        [Display(Name = "Email")]
        public DateTimeOffset? ContractEndDate { get; set; }
        [Display(Name = "Email")]
        public DateTimeOffset? UpdateDate { get; set; }
        [Display(Name = "Email")]
        public String EditedBy { get; set; }
        [Display(Name = "Email")]
        [Range(0, 99999.99)]
        public double BaseMonthSalary { get; set; }
    }
}