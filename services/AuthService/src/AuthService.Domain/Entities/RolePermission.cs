using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthService.Domain.Entities
{
    public class RolePermission
    {
        public int RoleId { get; private set; }
        public int PermissionId { get; private set; }

        public RolePermission() { }

        public RolePermission(int roleId, int permissionId)
        {
            RoleId = roleId;
            PermissionId = permissionId;
        }
    }
}
