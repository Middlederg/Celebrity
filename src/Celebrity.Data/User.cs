using Celebrity.Domain;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Celebrity.Data
{
    public class User : IdentityUser, IUser
    {
        public User()
        {
          
        }
    }
}
