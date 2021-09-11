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
    public class UserRegistrationShould
    {
        private readonly ServerFixture Given;

        public UserRegistrationShould(ServerFixture fixture)
        {
            Given = fixture ?? throw new ArgumentNullException(nameof(fixture));
        }

        [Fact]
        public async Task Success()
        {
            var dto = UserMother.GoodUser();

            var response = await Given
               .Server
               .CreateRequest(UserEndpoints.Register)
               .WithJsonBody(dto)
               .PostAsync();

            await response.ShouldBe(StatusCodes.Status200OK);
            var result = await response.ReadJsonResponse<RegisterResult>();

            result.Email.Should().Be(dto.Email);
        }

        [Fact]
        public async Task Fail_when_user_already_exists()
        {
            var user = await Given.UserInDatabase();

            var response = await Given
               .Server
               .CreateRequest(UserEndpoints.Register)
               .WithJsonBody(new RegisterModel()
               {
                   Email = user.Email,
                   Password = "Any6g**dPassw0rd",
                   ConfirmPassword = "Any6g**dPassw0rd"
               })
               .PostAsync();

            await response.ShouldBe(StatusCodes.Status400BadRequest);
            var result = await response.ReadJsonResponse<ProblemDetails>();

            result.Title.Should().NotBeNullOrEmpty();
        }

        [Fact]
        public async Task Fail_when_password_does_not_match()
        {
            var user = await Given.UserInDatabase();

            var response = await Given
                .Server
                .CreateRequest(UserEndpoints.Register)
                .WithJsonBody(new RegisterModel()
                {
                    Email = user.Email,
                    Password = "Any6g**dPassw0rd",
                    ConfirmPassword = "Any6g**dPassw0rd"
                })
                .PostAsync();

            await response.ShouldBe(StatusCodes.Status400BadRequest);
            var result = await response.ReadJsonResponse<ProblemDetails>();

            result.Title.Should().NotBeNullOrEmpty();
        }

        [Fact]
        public async Task Fail_when_password_is_weak()
        {
            var response = await Given
              .Server
              .CreateRequest(UserEndpoints.Register)
              .WithJsonBody(new RegisterModel()
              {
                  Email = "myInventedmail@user.com",
                  Password = "weak",
                  ConfirmPassword = "weak"
              })
              .PostAsync();

            await response.ShouldBe(StatusCodes.Status400BadRequest);
            var result = await response.ReadJsonResponse<ProblemDetails>();

            result.Title.Should().NotBeNullOrEmpty();
        }

    }
}
