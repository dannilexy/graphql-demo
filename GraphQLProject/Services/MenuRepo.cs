using GraphQLProject.Interfaces;
using GraphQLProject.Models;

namespace GraphQLProject.Services
{
    public class MenuRepo : IMenuRepo
    {
        private static List<Menu> menus = new List<Menu>
        {
            new Menu
            {
                Id = 1,
                Name = "Pizza",
                Description = "Cheese Pizza",
                Price = 10.99
            },
            new Menu
            {
                Id = 2,
                Name = "Burger",
                Description = "Cheese Burger",
                Price = 5.99
            },
            new Menu
            {
                Id = 3,
                Name = "Pasta",
                Description = "White Sauce Pasta",
                Price = 8.99
            }
        };
        public Menu AddMenu(Menu menu)
        {
            //Adding data to the list above
            menus.Add(menu);
            return menu;
        }

        public void DeleteMenu(int menuId)
        {
            //Delete menu by Id
            var menuToDelete = menus?.FirstOrDefault(x => x.Id == menuId);
            if (menuToDelete != null)
            {
                menus.Remove(menuToDelete);
            }
        }

        public List<Menu> GetAllMenus()
        {
            return menus;
        }

        public Menu GetMenuById(int id)
        {
            //Get menu by Id
            return menus?.FirstOrDefault(x => x.Id == id);
        }

        public Menu UpdateMenu(Menu menu, int menuId)
        {
            //Update menu by Id
            var menuToUpdate = menus?.FirstOrDefault(x => x.Id == menuId);
            if (menuToUpdate != null)
            {
                menuToUpdate.Name = menu.Name;
                menuToUpdate.Description = menu.Description;
                menuToUpdate.Price = menu.Price;
            }
            return menuToUpdate;

        }
    }
}
