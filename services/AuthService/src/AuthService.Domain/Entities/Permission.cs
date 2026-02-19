using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthService.Domain.Entities
{
    public class Permission
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        private Permission() { }
        public Permission(string name)
        {  
            Name = name; 
        }

    }
}
