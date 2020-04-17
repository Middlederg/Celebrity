using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Celebrity.Data
{
    public class Users : IdentityUser
    {
        public string Culture { get; set; }
        public CultureInfo GetCulture()
        {
            return string.IsNullOrWhiteSpace(Culture)
                    ? new CultureInfo(User.DefaultCulture)
                    : new CultureInfo(Culture);
        }

        public ICollection<Games> Games { get; set; }

        public Users()
        {
            Games = new HashSet<Games>();
        }
    }
}
