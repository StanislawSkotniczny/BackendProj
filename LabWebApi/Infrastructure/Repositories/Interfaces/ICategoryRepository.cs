using LabWebApi.Core.Entities;

namespace LabWebApi.Infrastructure.Repositories.Interfaces
{
    public interface ICategoryRepository
    {
        Task<Category> GetCategoryByIdAsync(int id);
        Task<IEnumerable<Category>> GetCategoriesAsync();
        Task AddCategoryAsync(Category category);
        Task UpdateCategoryAsync(Category category);
        Task DeleteCategoryAsync(int id);
    }
}