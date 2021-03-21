using Bogus;
using Celebrity.Shared;
using System.Linq;

namespace Celebrity.FunctionalTests
{
    public static class SubcategoryMother
    {
        public static CreateSubcategory Create()
        {
            var faker = new Faker<CreateSubcategory>()
                .StrictMode(true)
                .RuleFor(x => x.Category, f => f.PickRandom<CategoryValue>())
                .RuleFor(x => x.Name, f => f.Commerce.Categories(1).First());

            faker.Locale = Constants.CurrentLocale;

            return faker.Generate();
        }

        public static UpdateSubcategory Update()
        {
            var faker = new Faker<UpdateSubcategory>()
                 .StrictMode(true)
                 .RuleFor(x => x.Category, f => f.PickRandom<CategoryValue>())
                 .RuleFor(x => x.Name, f => f.Commerce.Categories(1).First());

            faker.Locale = Constants.CurrentLocale;

            return faker.Generate();
        }
    }
}
