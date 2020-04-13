using System;
using System.Collections.Generic;

namespace Celebrity
{

    public class Colour : ValueObject
    {
        private readonly Intensity red;
        private readonly Intensity green;
        private readonly Intensity blue;

        private Colour(Intensity red, Intensity green, Intensity blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
        }

        public static Colour FromRgb(Intensity red, Intensity green, Intensity blue)
        {
            return new Colour(red, green, blue);
        }

        public System.Drawing.Color ToWindowsColor()
        {
            return System.Drawing.Color.FromArgb(red, green, blue);
        }

       

        //public static Colour FromHex(string hexadecimalColor)
        //{
        //    var 
        //    return new Colour(red, green, blue);
        //}

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return red;
            yield return green;
            yield return blue;
        }
    }
}
