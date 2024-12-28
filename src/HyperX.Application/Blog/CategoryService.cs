using System.Collections.Generic;
using System.Threading.Tasks;
using HyperX.Application.Blog.Interfaces;
using HyperX.Application.Contracts.Blog;
using Volo.Abp.Domain.Repositories;

namespace HyperX.Application.Blog;

public partial class CategoryService(
    IRepository<Domain.Blog.Category, int> categoryRepository
    ) : ServiceBase, ICategoryService
{
    // private readonly IRepository<Domain.Blog.Category> _repository;
    private readonly IRepository<Domain.Blog.Category, int> _categoryRepository = categoryRepository;
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public async Task<QueryCategoryDto?> GetCategoryAsync()
    {
        var entity = await _categoryRepository.FirstOrDefaultAsync();
        return entity == null ? null : new QueryCategoryDto() { CategoryName = entity.CategoryName, DisplayName = entity.DisplayName };
    }
}