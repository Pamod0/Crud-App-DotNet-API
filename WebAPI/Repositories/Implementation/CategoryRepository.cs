using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;
using WebAPI.Data;
using WebAPI.Models.Domain;
using WebAPI.Repositories.Interface;

namespace WebAPI.Repositories.Implementation
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public CategoryRepository(ApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public async Task<Category> CreateAsync(Category category)
        {
            await _dbContext.Categories.AddAsync(category);
            await _dbContext.SaveChangesAsync();

            return category;
        }

        public async Task<Category> GetByIdAsync(Guid id)
        {
            return await _dbContext.Categories.FindAsync(id);
        }

        public async Task<IEnumerable<Category>> GetByNameAsync(string name)
        {
            // LINQ Query Syntax
            var query =
                from c in _dbContext.Categories
                where c.Name == name
                select c;

            return await query.ToListAsync();

            // Method Syntax

            //return await _dbContext.Categories
            //    .Where(c => c.Name == name)
            //    .ToListAsync();
        }

        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            return await _dbContext.Categories.ToListAsync();
        }
    }   
}
