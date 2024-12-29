using System.Text.Json;
using System.Threading.Tasks;
using HyperX.Domain.Shared.Wrappers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace HyperX.HttpApi.Filters;
/// <summary>
/// Web 全局异常过滤器，处理 Web 中出现的、运行时未处理的异常
/// </summary>
public class WebGlobalExceptionFilter : IAsyncExceptionFilter
{

    public async Task OnExceptionAsync(ExceptionContext context)
    {
        if (!context.ExceptionHandled)
        {

            ResponseModel model = ResponseModel.Create(HttpStateCode.InternalServerError,
                ResponseType.InternalServerError);
            context.Result = new ContentResult
            {
                Content = JsonSerializer.Serialize(model),
                StatusCode = StatusCodes.Status200OK,
                ContentType = "application/json; charset=utf-8"
            };
        }

        context.ExceptionHandled = true;

        await Task.CompletedTask;
    }
}