using System;
using System.Threading.Tasks;
using HyperX.Application.Blog.Interfaces;
using HyperX.Application.Contracts.Blog;
using HyperX.Domain.Blog;
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
    public async Task<QueryCategoryDto?> GetCategoryAsync(int id)
    {
        var entity = await _categoryRepository.FindAsync(id);
        return entity == null ? null : new QueryCategoryDto() { CategoryName = entity.CategoryName, DisplayName = entity.DisplayName };
    }

    /// <summary>
    /// 保存数据
    /// </summary>
    /// <param name="dto"></param>
    /// <returns></returns>
    public async Task Save(CategoryDto dto)
    {
        // 检查输入参数是否为空
        if (dto == null)
        {
            throw new ArgumentNullException(nameof(dto), "CategoryDto cannot be null.");
        }

        // 映射 DTO 到实体对象
        var entity = new Category
        {
            CategoryName = dto.CategoryName,
            DisplayName = dto.DisplayName
        };
        // 插入新的类别
        await _categoryRepository.InsertAsync(entity);



    }

}