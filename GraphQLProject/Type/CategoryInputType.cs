using GraphQL.Types;
using GraphQLProject.Models;

namespace GraphQLProject.Type
{
    public class CategoryInputType : InputObjectGraphType<Menu>
    {
        public CategoryInputType()
        {
            Field<IntGraphType>(name: "Id");
            Field<StringGraphType>(name: "Name");
            Field<StringGraphType>(name: "ImageUrl");
        }
    }
}
