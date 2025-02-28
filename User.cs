using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_practice_
{
    public class User
    {
        public string? Username { get; set; }
        public string? Role { get; set; }

        public virtual string AccessControl()
        {
            return "Access level not defined.";
        }
    }

    public class Admin : User
    {
        public Admin()
        {
            Role = "Admin";
        }

        public override string AccessControl()
        {
            return "Admin has access to all features.";
        }
    }

    public class Customer : User
    {
        public Customer()
        {
            Role = "Customer";
        }

        public override string AccessControl()
        {
            return "Customer has limited access.";
        }
    }
}
