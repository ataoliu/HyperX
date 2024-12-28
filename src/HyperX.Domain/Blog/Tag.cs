using Volo.Abp.Domain.Entities;

namespace HyperX.Domain.Blog;

/// <summary>
/// Tag
/// </summary>
public class Tag : Entity<int>
{
    /// <summary>
    /// 标签名称
    /// </summary>
    public string? TagName { get; set; }

    /// <summary>
    /// 展示名称
    /// </summary>
    public string? DisplayName { get; set; }
}