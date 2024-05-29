using GraphQL;
using GraphQL.Types;
using GraphQLProject.Interfaces;
using GraphQLProject.Models;
using GraphQLProject.Type;

namespace GraphQLProject.Mutation
{
    public class MenuMutation : ObjectGraphType
    {
        [Obsolete]
        public MenuMutation(IMenuRepo menuRepo)
        {
            Field<MenuType>("createMenu",
               arguments: new QueryArguments(
               new QueryArgument<NonNullGraphType<MenuInputType>> { Name = "menu" }),
                 resolve: context =>
                  {
                      var menu = context.GetArgument<Menu>("menu");
                      return menuRepo.AddMenu(menu);
                  });

            //Update menu
            Field<MenuType>("updateMenu",
                              arguments: new QueryArguments(
                                                new QueryArgument<NonNullGraphType<IntGraphType>> { Name = "id" },
                                                new QueryArgument<NonNullGraphType<MenuInputType>> { Name = "menu" }),
                                              resolve: context =>
                                              {
                                                  var menu = context.GetArgument<Menu>("menu");
                                                  var id = context.GetArgument<int>("id");
                                                  return menuRepo.UpdateMenu(menu, id);
                                              });

            //Delete menu 
            Field<StringGraphType>("deleteMenu",
                                                  arguments: new QueryArguments(
                                                   new QueryArgument<NonNullGraphType<IntGraphType>> { Name = "id" }),
                                                    resolve: context =>
                                                      {
                                                          var id = context.GetArgument<int>("id");
                                                          menuRepo.DeleteMenu(id);
                                                          return $"The menu with id: {id} has been successfully deleted";
                                                      });
        }
    }
}
