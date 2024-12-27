using Microsoft.AspNetCore.Builder;
using HyperX;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
builder.Environment.ContentRootPath = GetWebProjectContentRootPathHelper.Get("HyperX.Web.csproj"); 
await builder.RunAbpModuleAsync<HyperXWebTestModule>(applicationName: "HyperX.Web");

public partial class Program
{
}
