using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Celebrity.Data
{
    public class Users : IdentityUser
    {
        public ICollection<Games> Games { get; set; }

        public Users()
        {
            Games = new HashSet<Games>();
        }
    }
}
