namespace HyperX.Domain.Shared.Wrappers;

/// <summary>
/// API 响应格式
/// <para>避免滥用，此类不能实例化，只能通过预定义的静态方法生成</para>
/// </summary>
/// <typeparam name="TData"></typeparam>
public abstract class ResponseModel<TData>
{
    /// <summary>
    /// 状态吗
    /// </summary>
    /// <remarks>
    /// See <see cref="HttpStateCode"/> 
    /// </remarks>
    public HttpStateCode StatuCode { get; set; }
    /// <summary>
    /// Message
    /// </summary>
    public string? Message { get; set; }
    /// <summary>
    /// Data
    /// </summary>
    public TData? Data { get; set; }


    /// <summary>
    /// 私有类
    /// </summary>
    /// <typeparam name="TResult"></typeparam>
    private class PrivateResponseModel<TResult> : ResponseModel<TResult> { }
}