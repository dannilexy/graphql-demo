using GraphQLProject.Data;
using GraphQLProject.Interfaces;
using GraphQLProject.Models;

namespace GraphQLProject.Services
{
    public class MenuRepo : IMenuRepo
    {
        private readonly ApplicationDbContext _context;
        public MenuRepo(ApplicationDbContext _context)
        {
            this._context = _context;
        }
        public Menu AddMenu(Menu menu)
        {
            //Adding data to the list above
            _context.Menus.Add(menu);
            _context.SaveChanges();
            return menu;
        }

        public void DeleteMenu(int menuId)
        {
            //Delete menu by Id
            var menuToDelete = _context.Menus?.FirstOrDefault(x => x.Id == menuId);
            if (menuToDelete != null)
            {
                _context.Menus.Remove(menuToDelete);
                _context.SaveChanges();
            }
        }

        public List<Menu> GetAllMenus()
        {
            return _context.Menus.ToList();
        }

        public Menu GetMenuById(int id)
        {
            //Get menu by Id
            return _context.Menus?.FirstOrDefault(x => x.Id == id);
        }

        public Menu UpdateMenu(Menu menu, int menuId)
        {
            //Update menu by Id
            var menuToUpdate = _context.Menus?.FirstOrDefault(x => x.Id == menuId);
            if (menuToUpdate != null)
            {
                menuToUpdate.Name = menu.Name;
                menuToUpdate.Description = menu.Description;
                menuToUpdate.Price = menu.Price;
            }
            _context.Menus.Update(menuToUpdate);
            _context.SaveChanges();
            return menuToUpdate;

        }
    }
}
