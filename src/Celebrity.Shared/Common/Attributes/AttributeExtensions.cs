using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace Celebrity.Shared
{
    public static class AttributeExtensions
    {
        public static bool IsService(this Type type)
        {
            return Attribute.IsDefined(type, typeof(ServiceAttribute));
        }
        public static string Description<T>(this T source) where T : Enum
        {
            var attribute = source.GetAttribute<T, DescriptionAttribute>();
            if (attribute is null)
                return source.ToString();

            return attribute.Description;
        }

        private static TAttribute GetAttribute<TEnum, TAttribute>(this TEnum source)
            where TEnum : Enum
            where TAttribute : Attribute
        {
            var typeInfo = source.GetType().GetTypeInfo();
            var memberInfo = typeInfo.GetMember(source.ToString());
            var attributes = memberInfo[0].GetCustomAttributes<TAttribute>();
            if (attributes.Any())
            {
                return attributes.First();
            }
            return null;
        }
    }

  
}
