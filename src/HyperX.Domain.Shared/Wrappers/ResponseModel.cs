using System;
using HyperX.Domain.Shared.Helpers;

namespace HyperX.Domain.Shared.Wrappers;

/// <summary>
/// Web 响应格式
/// <para>避免滥用，此类不能实例化，只能通过预定义的静态方法生成</para>
/// </summary>
public abstract class ResponseModel : ResponseModel<dynamic>
{
    /// <summary>
    /// 根据枚举创建响应格式
    /// </summary>
    /// <typeparam name="TEnum"></typeparam>
    /// <param name="code"></param>
    /// <param name="enumType"></param>
    /// <returns></returns>
    public static ResponseModel Create<TEnum>(HttpStateCode code, TEnum enumType) where TEnum : Enum
    {
        return new PrivateResponseModel
        {
            StatuCode = code,
            Message = SchemeHelper.Get<TEnum>(enumType),
        };
    }

    /// <summary>
    /// 创建标准的响应
    /// </summary>
    /// <typeparam name="TEnum"></typeparam>
    /// <typeparam name="TData"></typeparam>
    /// <param name="code"></param>
    /// <param name="enumType"></param>
    /// <param name="Data"></param>
    /// <returns></returns>
    public static ResponseModel Create<TEnum>(HttpStateCode code, TEnum enumType, object data) where TEnum : Enum
    {
        return new PrivateResponseModel
        {
            StatuCode = code,
            Message = SchemeHelper.Get(enumType),
            Data = data
        };
    }


    /// <summary>
    /// 请求成功
    /// </summary>
    /// <param name="code"></param>
    /// <param name="Data"></param>
    /// <returns></returns>
    public static ResponseModel CreateSuccess(HttpStateCode code, dynamic Data)
    {
        return new PrivateResponseModel
        {
            StatuCode = code,
            Message = "Success",
            Data = Data
        };
    }

    /// <summary>
    /// 私有类
    /// </summary>
    private class PrivateResponseModel : ResponseModel { }
}