using System;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace HyperX.Domain.Configurations;

/// <summary>
/// appsettings.json配置文件数据读取类
/// </summary>
public class AppSettings
{
    /// <summary>
    /// 配置文件的根节点
    /// </summary>
    private static readonly IConfigurationRoot _config;

    /// <summary>
    /// Constructor
    /// </summary>
    static AppSettings()
    {
        // 加载appsettings.json，并构建IConfigurationRoot
        var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", true, true);
        _config = builder.Build();
    }

    /// <summary>
    /// EnableDb
    /// </summary>
    public static string DefaultKey => _config["ConnectionStrings:DefaultKey"] ?? throw new ApplicationException ("请设置默认数据库");

    /// <summary>
    /// ConnectionStrings
    /// </summary>
    public static string? ConnectionStrings => _config.GetConnectionString(DefaultKey);
}