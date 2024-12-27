using HyperX.Application;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;
namespace HyperX.Controllers;

[ApiController]
[Route("[controller]")]
public class HelloWorldController(IHelloWorldService helloWorldService) : AbpController
{
    private readonly IHelloWorldService _helloWorldService = helloWorldService;

    [HttpGet]
    public string HelloWorld()
    {
        return _helloWorldService.HelloWorld();
    }
}