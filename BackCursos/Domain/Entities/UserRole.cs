using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class UserRole
    {
        public int IdUserFk {get; set;}
        public User User {get; set;}
        public int IdRoleFk {get; set;}
        public Role Role {get; set;}
    }
}