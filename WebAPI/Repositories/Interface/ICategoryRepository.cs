using WebAPI.Models.Domain;

namespace WebAPI.Repositories.Interface
{
    public interface ICategoryRepository
    {
        Task<Category> CreateAsync(Category category);
    }
}
