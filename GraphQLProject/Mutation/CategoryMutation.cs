using GraphQL;
using GraphQL.Types;
using GraphQLProject.Interfaces;
using GraphQLProject.Models;
using GraphQLProject.Type;

namespace GraphQLProject.Mutation
{
    public class CategoryMutation : ObjectGraphType
    {
        [Obsolete]
        public CategoryMutation(ICategoryRepo _categoryRepo)
        {

            //write mutation to create category
            Field<CategoryType>("createCategory",
                              arguments: new QueryArguments(
                                                new QueryArgument<NonNullGraphType<CategoryInputType>> { Name = "category" }),
                                              resolve: context =>
                                              {
                                                  var category = context.GetArgument<Category>("category");
                                                  return _categoryRepo.CreateCategory(category);
                                              });
            //Update category
            Field<CategoryType>("updateCategory",
                                             arguments: new QueryArguments(
                                                new QueryArgument<NonNullGraphType<IntGraphType>> { Name = "id" },
                                                new QueryArgument<NonNullGraphType<CategoryInputType>> { Name = "category" }),
                                                resolve: context =>
                                                {
                                                    var category = context.GetArgument<Category>("category");
                                                    var id = context.GetArgument<int>("id");
                                                    return _categoryRepo.UpdateCategory(category, id);
                                                });


            //Delete category
            Field<StringGraphType>("deleteCategory", arguments: new QueryArguments(
                                  new QueryArgument<NonNullGraphType<IntGraphType>> { Name = "id" }),
                                    resolve: context =>
                                    {
                                        var id = context.GetArgument<int>("id");
                                        _categoryRepo.DeleteCategory(id);
                                        return $"The category with id: {id} has been successfully deleted";
                                    });


        }
    }
}
