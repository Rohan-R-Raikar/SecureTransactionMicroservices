using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthService.Domain.Entities
{
    public class UserRole
    {
        public Guid UserId { get; private set; }
        public int RoleId { get; private set; }

        private UserRole() { }

        public UserRole(Guid userId, int roleId)
        {
            UserId = userId;
            RoleId = roleId;
        }
    }
}
