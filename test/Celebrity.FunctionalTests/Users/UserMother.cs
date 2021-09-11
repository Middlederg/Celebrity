using Bogus;
using Celebrity.Shared;

namespace Celebrity.FunctionalTests
{
    public static class UserMother
    {
        public static RegisterModel RegisterModel()
        {
            var faker = new Faker<RegisterModel>()
                .StrictMode(false)
                .RuleFor(x => x.Email, f => f.Person.Email)
                .RuleFor(x => x.Password, f => f.Internet.Password() + "1cC*");

            faker.Locale = Constants.CurrentLocale;

            var result = faker.Generate();
            result.ConfirmPassword = result.Password;
            return result;
        }

        public static RegisterModel DifferentPasswordRegisterModel()
        {
            var faker = new Faker<RegisterModel>()
                .StrictMode(false)
                .RuleFor(x => x.Email, f => f.Person.Email)
                .RuleFor(x => x.Password, f => f.Internet.Password())
                .RuleFor(x => x.ConfirmPassword, f => f.Internet.Password());

            faker.Locale = Constants.CurrentLocale;

            var result = faker.Generate();
            return result;
        }
    }
}
