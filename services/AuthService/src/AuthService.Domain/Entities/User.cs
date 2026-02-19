using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthService.Domain.Entities
{
    public class User
    {
        public Guid Id { get; private set; }
        public string Email{ get; private set; }
        public string HashPassword { get; private set; }
        public bool IsActive {  get; private set; }
        public DateTime CreatedAt {  get; private set; }
        
        private readonly List<UserRole> _userRoles = new();
        public IReadOnlyCollection<UserRole> UserRoles => _userRoles;

        private User() { } // For EF

        public User(string email, string hashPassword)
        {
            Id = Guid.NewGuid();
            Email = email;
            HashPassword = hashPassword;
            IsActive = true;
            CreatedAt = DateTime.UtcNow;
        }
        public void AssignRole(Role role)
        {
            _userRoles.Add(new UserRole(Id, role.Id));
        }
    }
}
