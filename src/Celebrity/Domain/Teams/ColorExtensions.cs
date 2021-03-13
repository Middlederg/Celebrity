using System;
using System.ComponentModel;
using System.Reflection;

namespace Celebrity
{
    public static class ColorExtensions
    {
        public static string ColorClass(this Color color, string defaultColor = "light")
        {
            switch (color)
            {
                case Color.Bluemoon: return "primary";
                case Color.Greenfindor: return "success";
                case Color.Passion: return "danger";
                case Color.Lemon:return "warning";
                case Color.DarkParty:return "dark";
                case Color.PacificTeam:return "info";
                default: return defaultColor;
            }
        }

        public static string ColorClass(this Color? color, string defaultColor = "light")
        {
            if (!color.HasValue) return defaultColor;
            return color.Value.ColorClass();
        }
    }
}
