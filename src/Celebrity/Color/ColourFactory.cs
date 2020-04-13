namespace Celebrity
{
    public class ColourFactory
    {
        public static Colour Blue => Create(41, 128, 185);

        private static Colour Create(int red, int green, int blue)
        {
            return Colour.FromRgb(
                new Intensity(red),
                new Intensity(green),
                new Intensity(blue));
        }
    }
}
