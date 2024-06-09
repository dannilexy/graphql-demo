using GraphQL.Types;
using GraphQLProject.Interfaces;
using GraphQLProject.Models;

namespace GraphQLProject.Type
{
    public class CategoryType : ObjectGraphType<Category>
    {
        public CategoryType(IMenuRepo _menu)
        {
            Field(x => x.Id);
            Field(x => x.Name);
            Field(x => x.ImageUrl);
            Field<ListGraphType<MenuType>>("menus").Resolve(x =>
            {
                return _menu.GetAllMenus();
            });
        }
    }
}
