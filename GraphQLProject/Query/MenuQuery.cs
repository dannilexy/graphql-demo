using GraphQL;
using GraphQL.Types;
using GraphQLProject.Interfaces;
using GraphQLProject.Type;

namespace GraphQLProject.Query
{
    public class MenuQuery : ObjectGraphType
    {
        public MenuQuery(IMenuRepo _menu)
        {
            Field<ListGraphType<MenuType>>("menus", resolve: context => _menu.GetAllMenus());

            Field<MenuType>("menu", arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" }),
                            resolve: context =>
                            {
                                var id = context.GetArgument<int>("id");
                                return _menu.GetMenuById(id);
                            });
        }
    }
}
