using System.Collections.Generic;
using System.Threading.Tasks;
using HyperX.Application.Contracts.Blog;

namespace HyperX.Application.Blog.Interfaces;
public partial interface ICategoryService
{


    /// <summary>
    /// 查询分类列表
    /// </summary>
    /// <returns></returns>
    public Task<QueryCategoryDto?> GetCategoryAsync(int id);
    /// <summary>
    /// 保存数据
    /// </summary>
    /// <param name="dto"></param>
    /// <returns></returns>
    public Task Save(CategoryDto dto);
}