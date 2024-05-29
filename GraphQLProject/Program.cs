using GraphiQl;
using GraphQL;
using GraphQL.Types;
using GraphQLProject.Interfaces;
using GraphQLProject.Mutation;
using GraphQLProject.Query;
using GraphQLProject.Schema;
using GraphQLProject.Services;
using GraphQLProject.Type;

namespace GraphQLProject
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddTransient<IMenuRepo, MenuRepo>();
            builder.Services.AddTransient<MenuType>();
            builder.Services.AddTransient<MenuQuery>();
            builder.Services.AddTransient<MenuMutation>();
            builder.Services.AddTransient<ISchema, MenuSchema>();

            builder.Services.AddGraphQL(b => b.AddAutoSchema<ISchema>().AddSystemTextJson());

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            //using graphQL
            app.UseGraphiQl("/graphql");
            app.UseGraphQL<ISchema>();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
