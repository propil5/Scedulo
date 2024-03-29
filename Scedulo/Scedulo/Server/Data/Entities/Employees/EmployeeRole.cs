using Scedulo.Server.Data.Entities.Rooms;
using Scedulo.Server.Data.Entities.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Scedulo.Server.Data.Entities.Employees
{
    public class EmployeeRole
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        [Column(TypeName = "text")]
        public string Description {get; set;}

        public virtual ICollection<RolePermission> RolePermissions { get; set; }
        public virtual ICollection<PermissionToService> PermissionsToService { get; set; }
        public virtual ICollection<PermissionToRoom> PermissionToRoom { get; set; }

    }
}