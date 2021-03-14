using System.ComponentModel;

namespace Celebrity.ManagingContext
{
    public enum CategoryValue
    {
        [Description("Personajes reales")]
        RealCharacters,

        [Description("Personajes de ficción")]
        FictionalCharacters,

        [Description("Cultura")]
        Culture,

        [Description("Lugares")]
        Places,

        [Description("Citas")]
        Quotes,

        [Description("Universos de ficción")]
        FictionalUniverses,

        [Description("Nacionalidades")]
        Nationalities,

        [Description("Tecnología")]
        Technology,

        [Description("Ciencia")]
        Science,

        [Description("Deporte")]
        Sport
    }
}
