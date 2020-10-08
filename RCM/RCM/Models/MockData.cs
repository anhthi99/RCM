using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RCM.Models
{
    public class MockData
    {
        public static List<Role> Roles { get; set; } = new List<Role>() 
        {
            new Role() { ID = 1, RoleName = "Administrator"},
            new Role() { ID = 2, RoleName = "Manager"},
            new Role() {ID = 3, RoleName = "User"}
        };
        public static List<Operator> Operators { get; set; } = new List<Operator>();
    }
}
