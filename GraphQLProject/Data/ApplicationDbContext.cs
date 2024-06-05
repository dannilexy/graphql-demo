using GraphQLProject.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQLProject.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        //override onModelCreating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Menu>().HasData(
                               new Menu
                               {
                                   Id = 1,
                                   Name = "Menu 1",
                                   Description = "Menu 1 Description",
                                   Price = 10.99
                               },
                                              new Menu
                                              {
                                                  Id = 2,
                                                  Name = "Menu 2",
                                                  Description = "Menu 2 Description",
                                                  Price = 20.99
                                              },
                                                             new Menu
                                                             {
                                                                 Id = 3,
                                                                 Name = "Menu 3",
                                                                 Description = "Menu 3 Description",
                                                                 Price = 30.99
                                                             }
                                                                        );
        }
    }
}
