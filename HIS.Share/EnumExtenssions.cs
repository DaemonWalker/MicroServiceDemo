using System;
using System.ComponentModel;

namespace HIS.Share
{
    public static class EnumExtenssions
    {
        public static string GetDescription<T>(this T tEnum) where T : Enum
        {
            var enumType = tEnum.GetType();
            var fieldName = Enum.GetName(enumType, tEnum);
            var objs = enumType.GetField(fieldName).GetCustomAttributes(typeof(DescriptionAttribute), false);
            return objs.Length > 0 ? ((DescriptionAttribute)objs[0]).Description : throw new InvalidOperationException($"{tEnum}中不包含DescriptionAttribute");
        }
    }
}
