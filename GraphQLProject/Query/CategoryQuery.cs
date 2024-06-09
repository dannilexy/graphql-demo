using GraphQL.Types;
using GraphQLProject.Interfaces;
using GraphQLProject.Type;

namespace GraphQLProject.Query
{
    public class CategoryQuery : ObjectGraphType
    {
        public CategoryQuery(ICategoryRepo categoryRepo)
        {
            Field<ListGraphType<CategoryType>>("categories").ResolveAsync(async x =>
            {
                return await categoryRepo.GetCategories();
            });
        }
    }
}
