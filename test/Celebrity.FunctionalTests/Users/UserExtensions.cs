using Celebrity.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Celebrity.FunctionalTests
{
    public static class UserExtensions
    {
        public static async Task<RegisterResult> UserInDatabase(this ServerFixture given)
        {
            var dto = UserMother.GoodUser();

            var response = await given
               .Server
               .CreateRequest(UserEndpoints.Register)
               .WithJsonBody(dto)
               .PostAsync();

            await response.ShouldBe(StatusCodes.Status200OK);
            var result = await response.ReadJsonResponse<RegisterResult>();
            return result;
        }
        
        public static async Task<RegisterResult> UserInDatabase(this ServerFixture given, RegisterModel dto)
        {
            var response = await given
               .Server
               .CreateRequest(UserEndpoints.Register)
               .WithJsonBody(dto)
               .PostAsync();

            await response.ShouldBe(StatusCodes.Status200OK);
            var result = await response.ReadJsonResponse<RegisterResult>();
            return result;
        }

        public static async Task<RegisterResult> ConfirmedUserInDatabase(this ServerFixture given, RegisterModel dto)
        {
            var result = await given.UserInDatabase(dto);
            //TODO here confirm user
            return result;
        }
    }
}
