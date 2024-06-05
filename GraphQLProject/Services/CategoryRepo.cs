using GraphQLProject.Data;
using GraphQLProject.Interfaces;
using GraphQLProject.Models;

namespace GraphQLProject.Services
{
    public class CategoryRepo : ICategoryRepo
    {
        private readonly ApplicationDbContext _context;
        public CategoryRepo(ApplicationDbContext _context)
        {
            this._context = _context;
        }
        public async Task<Category> CreateCategory(Category category)
        {
            var cat = await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();
            return cat.Entity;
        }

        public async Task DeleteCategory(int id)
        {
            var category = _context.Categories.FirstOrDefault(x => x.Id == id);
            if (category != null)
            {
                _context.Categories.Remove(category);
                await _context.SaveChangesAsync();
            }
        }

        public Task<List<Category>> GetCategories()
        {
            return Task.FromResult(_context.Categories.ToList());
        }

        public Task<Category> UpdateCategory(Category category, int id)
        {
            var cat = _context.Categories.FirstOrDefault(x => x.Id == id);
            if (cat != null)
            {
                cat.Name = category.Name;
                cat.ImageUrl = category.ImageUrl;
                _context.Categories.Update(cat);
                _context.SaveChanges();
            }
            return Task.FromResult(cat);
        }
    }
}
