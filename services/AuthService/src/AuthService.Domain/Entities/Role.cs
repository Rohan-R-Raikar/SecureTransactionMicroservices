using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthService.Domain.Entities
{
    public class Role
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        private readonly List<RolePermission> _rolePermissions = new();
        public IReadOnlyCollection<RolePermission> RolePermissions => _rolePermissions;

        private Role() { }

        public Role(string name)
        {
            Name = name;
        }
        public void AddPermission(Permission permission)
        {
            _rolePermissions.Add(new RolePermission(Id, permission.Id));
        }
    }
}
