using Celebrity.Shared;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;

namespace Celebrity.FunctionalTests
{
    [Collection(nameof(ServerFixtureCollection))]
    public class UserLoginShould
    {
        private readonly ServerFixture Given;

        public UserLoginShould(ServerFixture fixture)
        {
            Given = fixture ?? throw new ArgumentNullException(nameof(fixture));
        }

        [Fact]
        public async Task Success()
        {
            var dto = UserMother.GoodUser();
            await Given.ConfirmedUserInDatabase(dto);

            var response = await Given
               .Server
               .CreateRequest(UserEndpoints.Login)
               .WithJsonBody(new LoginModel()
               {
                   Email = dto.Email,
                   Password = dto.Password
               })
               .PostAsync();

            await response.ShouldBe(StatusCodes.Status200OK);
            var result = await response.ReadJsonResponse<LoginResult>();

            result.Email.Should().Be(dto.Email);
            result.Token.Should().NotBeNullOrEmpty();
        }


        [Fact]
        public async Task Fail_when__account_is_not_confirmed()
        {
            var dto = UserMother.GoodUser();
            await Given.UserInDatabase(dto);

            var response = await Given
               .Server
               .CreateRequest(UserEndpoints.Login)
               .WithJsonBody(new LoginModel()
               {
                   Email = dto.Email,
                   Password = dto.Password
               })
               .PostAsync();

            await response.ShouldBe(StatusCodes.Status400BadRequest);
            var result = await response.ReadJsonResponse<ProblemDetails>();

            result.Title.Should().NotBeNullOrEmpty();
        }

        [Fact]
        public async Task Fail_when_user_does_not_exist()
        {
            var response = await Given
               .Server
               .CreateRequest(UserEndpoints.Login)
               .WithJsonBody(new LoginModel()
               {
                   Email = "anyuser@user.com",
                   Password = "any_password"
               })
               .PostAsync();

            await response.ShouldBe(StatusCodes.Status400BadRequest);
            var result = await response.ReadJsonResponse<ProblemDetails>();

            result.Title.Should().NotBeNullOrEmpty();
        }

        [Fact]
        public async Task Fail_when_password_is_wrong()
        {
            var dto = UserMother.GoodUser();
            await Given.UserInDatabase(dto);

            var response = await Given
                .Server
                .CreateRequest(UserEndpoints.Login)
                .WithJsonBody(new LoginModel()
                {
                    Email = dto.Email,
                    Password = "wrong_password"
                })
                .PostAsync();

            await response.ShouldBe(StatusCodes.Status400BadRequest);
            var result = await response.ReadJsonResponse<ProblemDetails>();

            result.Title.Should().NotBeNullOrEmpty();
        }
    }
}
