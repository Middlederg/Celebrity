using Bogus;
using Celebrity.Shared;
using System;
using System.Linq;

namespace Celebrity.FunctionalTests
{
    public static class ConceptMother
    {
        public static CreateConcept Create(Guid subcategoryId)
        {
            var faker = new Faker<CreateConcept>()
                .StrictMode(true)
                .RuleFor(x => x.Difficulty, f => f.PickRandom<Difficulty>())
                .RuleFor(x => x.Type, f => f.PickRandom<ConceptType>())
                .RuleFor(x => x.SubcategoryId, subcategoryId)
                .RuleFor(x => x.Name, f => f.Commerce.ProductName());

            faker.Locale = Constants.CurrentLocale;

            return faker.Generate();
        }

        public static UpdateConcept Update(Guid id)
        {
            var faker = new Faker<UpdateConcept>()
                 .StrictMode(true)
                .RuleFor(x => x.Difficulty, f => f.PickRandom<Difficulty>())
                .RuleFor(x => x.Type, f => f.PickRandom<ConceptType>())
                .RuleFor(x => x.Id, id)
                .RuleFor(x => x.Name, f => f.Commerce.ProductName());

            faker.Locale = Constants.CurrentLocale;

            return faker.Generate();
        }
    }
}
