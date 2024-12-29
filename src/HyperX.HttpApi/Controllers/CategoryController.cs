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
    /// <summary>
    /// 查询
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public async Task<QueryCategoryDto?> Get(int id)
    {
        return await _categoryService.GetCategoryAsync(id);
    }
    /// <summary>
    /// 添加数据
    /// </summary>
    /// <param name="dto"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task Save([FromBody] QueryCategoryDto dto)
    {
        await _categoryService.Save(dto);
    }
}