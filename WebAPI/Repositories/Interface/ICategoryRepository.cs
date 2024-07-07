using WebAPI.Models.Domain;

namespace WebAPI.Repositories.Interface
{
    public interface ICategoryRepository
    {
        Task<Category> CreateAsync(Category category);
        Task<Category> GetByIdAsync(Guid id);
        Task<IEnumerable<Category>> GetByNameAsync(string name);
        Task<IEnumerable<Category>> GetAllAsync();
    }
}
