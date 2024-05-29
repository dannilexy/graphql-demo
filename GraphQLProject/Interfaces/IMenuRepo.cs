using GraphQLProject.Models;

namespace GraphQLProject.Interfaces
{
    public interface IMenuRepo
    {
        List<Menu> GetAllMenus();
        Menu GetMenuById(int id);
        Menu AddMenu(Menu menu);
        Menu UpdateMenu(Menu menu, int menuId);
        void DeleteMenu(int menuId);
    }
}
