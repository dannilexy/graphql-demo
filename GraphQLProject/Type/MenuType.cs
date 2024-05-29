using GraphQL.Types;
using GraphQLProject.Models;

namespace GraphQLProject.Type
{
    public class MenuType : ObjectGraphType<Menu>
    {
        public MenuType()
        {
            Field(x => x.Id).Description("Id of the menu");
            Field(x => x.Name).Description("Name of the menu");
            Field(x => x.Description).Description("Description of the menu");
            Field(x => x.Price).Description("Price of the menu");
        }
    }
}
