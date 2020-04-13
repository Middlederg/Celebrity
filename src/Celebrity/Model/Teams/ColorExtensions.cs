using System;
using System.ComponentModel;
using System.Reflection;

namespace Celebrity
{
    public static class ColorExtensions
    {
        public static string Description<T>(this T source) where T : Enum
        {
            FieldInfo fi = source.GetType().GetField(source.ToString());

            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(
                typeof(DescriptionAttribute), false);

            if (attributes != null && attributes.Length > 0) return attributes[0].Description;
            else return source.ToString();
        }

        public static string ColorClass(this Color color)
        {
            switch (color)
            {
                case Color.Bluemoon: return "primary";
                case Color.Greenfindor: return "success";
                case Color.Passion: return "danger";
                case Color.Lemon:return "warning";
                case Color.DarkParty:return "dark";
                case Color.PacificTeam:return "info";
                default: return "";
            }
        }
    }
}
