using System.ComponentModel;
using System.Reflection;

namespace ConsoleApplicationFoundational.Helpers
{
    public static class EnumHelper
    {
        public static TEnum ConvertToEnum<TEnum>(int enumValue) where TEnum : Enum
        {
            if (!Enum.IsDefined(typeof(TEnum), enumValue))
            {
                throw new ArgumentException($"Invalid Value Enum {typeof(TEnum).Name}: {enumValue}");
            }

            return (TEnum)Enum.ToObject(typeof(TEnum), enumValue);
        }

        public static string GetEnumDescription(Enum value)
        {
            FieldInfo field = value.GetType().GetField(value.ToString());
            var attribute = (DescriptionAttribute)Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute));

            return attribute?.Description ?? value.ToString();
        }

        public static string GetEnumDescriptionFromInt<TEnum>(int enumValue) where TEnum : Enum
        {
            var enumObject = ConvertToEnum<TEnum>(enumValue);

            // Retorna a descrição do enum
            return GetEnumDescription(enumObject);
        }
    }
}
