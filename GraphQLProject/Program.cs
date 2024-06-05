using GraphiQl;
using GraphQL;
using GraphQL.Types;
using GraphQLProject.Data;
using GraphQLProject.Interfaces;
using GraphQLProject.Mutation;
using GraphQLProject.Query;
using GraphQLProject.Schema;
using GraphQLProject.Services;
using GraphQLProject.Type;
using Microsoft.EntityFrameworkCore;

namespace GraphQLProject
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            //add dbcontext class
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddTransient<IMenuRepo, MenuRepo>();
            builder.Services.AddTransient<ICategoryRepo, CategoryRepo>();
            builder.Services.AddTransient<IReservationRepo, ReservationRepo>();
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
