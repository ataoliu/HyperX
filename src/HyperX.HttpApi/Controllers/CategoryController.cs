using System.Threading.Tasks;
using HyperX.Application.Blog;
using HyperX.Application.Blog.Interfaces;
using HyperX.Application.Contracts.Blog;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;
namespace HyperX.HttpApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CategoryController(ICategoryService categoryService) : AbpController
{
    private readonly ICategoryService _categoryService = categoryService;

    [HttpGet]
    public async Task<QueryCategoryDto?> HelloWorld()
    {
        return await _categoryService.GetCategoryAsync();
    }
}