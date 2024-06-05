using GraphQLProject.Models;

namespace GraphQLProject.Interfaces
{
    public interface ICategoryRepo
    {
        Task<List<Category>> GetCategories();
        Task<Category> CreateCategory(Category category);
        Task<Category> UpdateCategory(Category category, int id);
        Task DeleteCategory(int id);
    }
}
