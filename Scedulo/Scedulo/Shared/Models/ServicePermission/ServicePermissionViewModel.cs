﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Scedulo.Shared.Models.ServicePermission
{
    public class ServicePermissionViewModel
    {
        [Display(Name = "Id")]
        public string Id { get; set; }

        [Display(Name = "Name")]
        public string EmployeeRoleId { get; set; }

        [Display(Name = "Description")]
        public string ServiceId { get; set; }
    }
}
