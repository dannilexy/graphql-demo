using GraphQL.Types;
using GraphQLProject.Models;

namespace GraphQLProject.Type
{
    public class MenuInputType : InputObjectGraphType<Menu>
    {
        public MenuInputType()
        {
            Field<IntGraphType>(name: "Id");
            Field<StringGraphType>(name: "Name");
            Field<StringGraphType>(name: "Description");
            Field<FloatGraphType>(name: "Price");
        }
    }
}
