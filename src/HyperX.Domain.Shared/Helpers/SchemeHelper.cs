using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using HyperX.Domain.Shared.Attributes;

namespace HyperX.Domain.Shared.Helpers;
/// <summary>
/// 获取各种枚举代表的信息
/// </summary>
public static class SchemeHelper
{
    private static readonly PropertyInfo? SchemeNameAttributeMessage = typeof(SchemeNameAttribute).GetProperty(nameof(SchemeNameAttribute.Message));

    /// <summary>
    /// 获取一个使用了 SchemeNameAttribute 特性的 Message 属性值
    /// </summary>
    /// <typeparam name="T">枚举类型</typeparam>
    /// <param name="type">枚举值</param>
    /// <returns>Message 属性值或空字符串</returns>
    public static string Get<T>(T type) where T : Enum
    {
        return GetValue(type);
    }

    private static string GetValue<T>(T type) where T : Enum
    {
        var fieldName = Enum.GetName(typeof(T), type);
        if (string.IsNullOrEmpty(fieldName))
            return string.Empty;

        var field = typeof(T).GetField(fieldName);
        if (field == null)
            return string.Empty;

        var attr = field.GetCustomAttributes(typeof(SchemeNameAttribute), false)
            .FirstOrDefault() as SchemeNameAttribute;

        return attr?.Message ?? string.Empty;
    }
}
