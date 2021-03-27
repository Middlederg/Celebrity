using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Celebrity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Celebrity.Api
{
    //public class UserCommands
    //{
    //    private readonly UserManager<User> userManager;

    //    public UserCommands(UserManager<User> userManager)
    //    {
    //        this.userManager = userManager;
    //    }

    //    //public async Task Create(User email, string password)
    //    //{
    //    //    var newUser = User.Create(({ UserName = email.ToString(), Email = email.ToString() };

    //    //    var result = await userManager.CreateAsync(newUser, password);

    //    //    if (!result.Succeeded)
    //    //    {
    //    //        var errors = result.Errors.Select(x => x.Description);
    //    //        throw new DomainException(errors.ToArray());
    //    //    }
    //    //}

    //    public async Task UpdatePassword(User user, string currentPassword, string newPassword)
    //    {
    //        var databaseUser = await userManager.FindByIdAsync(user.Id.ToString());
    //        var result = await userManager.ChangePasswordAsync(databaseUser, currentPassword, newPassword);
    //        if (!result.Succeeded)
    //        {
    //            throw new DomainException(result.Errors.Select(x => x.Description).ToArray());
    //        }
    //    }

    //    public async Task DeleteUser(Guid idUser)
    //    {
    //        var user = await userManager.FindByIdAsync(idUser.ToString());
    //        await userManager.DeleteAsync(user);
    //    }
    //}

  
}
