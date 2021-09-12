using Celebrity.Shared;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;

namespace Celebrity.FunctionalTests
{
    [Collection(nameof(ServerFixtureCollection))]
    public class EmailConfirmationShould
    {
        private readonly ServerFixture Given;

        public EmailConfirmationShould(ServerFixture fixture)
        {
            Given = fixture ?? throw new ArgumentNullException(nameof(fixture));
        }

        [Fact]
        public async Task Success()
        {
            var dto = UserMother.RegisterModel();

            var response = await Given
               .Server
               .CreateRequest(UserEndpoints.Register)
               .WithJsonBody(dto)
               .PostAsync();

            await response.ShouldBe(StatusCodes.Status200OK);
            var result = await response.ReadJsonResponse<RegisterResult>();
            result.Email.Should().Be(dto.Email);
            result.UserId.Should().NotBeEmpty();

            var emailSender = Given.GetService<IEmailSender>() as FakeEmailSender;
            emailSender.EmailWasSentTo(dto.Email, EmailSubjects.ConfirmEmailSubject, 1);
            var code = emailSender.SearchForCode(dto.Email);

            response = await Given
               .Server
               .CreateRequest(UserEndpoints.ConfirmEmail)
               .WithJsonBody(new ConfirmEmailModel()
               {
                   Code = code,
                   UserId = result.UserId
               })
               .PostAsync();
            await response.ShouldBe(StatusCodes.Status200OK);
        }

        [Fact]
        public async Task Fail_when_code_is_incorrect()
        {
            var dto = UserMother.RegisterModel();

            var response = await Given
               .Server
               .CreateRequest(UserEndpoints.Register)
               .WithJsonBody(dto)
               .PostAsync();

            await response.ShouldBe(StatusCodes.Status200OK);
            var result = await response.ReadJsonResponse<RegisterResult>();
            result.Email.Should().Be(dto.Email);
            result.UserId.Should().NotBeEmpty();

            response = await Given
               .Server
               .CreateRequest(UserEndpoints.ConfirmEmail)
               .WithJsonBody(new ConfirmEmailModel()
               {
                   Code = Guid.NewGuid().ToString(),
                   UserId = result.UserId
               })
               .PostAsync();
            await response.ShouldBe(StatusCodes.Status400BadRequest);
        }

        [Fact]
        public async Task Fail_when_user_does_not_exist()
        {
            var response = await Given
               .Server
               .CreateRequest(UserEndpoints.ConfirmEmail)
               .WithJsonBody(new ConfirmEmailModel()
               {
                   Code = Guid.NewGuid().ToString(),
                   UserId = Guid.NewGuid()
               })
               .PostAsync();
            await response.ShouldBe(StatusCodes.Status404NotFound);
        }
    }
}
