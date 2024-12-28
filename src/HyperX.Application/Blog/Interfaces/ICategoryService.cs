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
    Task<QueryCategoryDto?> GetCategoryAsync();
}