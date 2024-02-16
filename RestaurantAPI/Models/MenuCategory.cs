namespace RestaurantAPI.Models;

public class MenuCategory
{
    public Dictionary<string, MenuItem> MenuItems { get; } = new();

    public void AddMenuItemToTheCategory(MenuItem item)
    {
        MenuItems[item.MenuItemName] = item;
    }
}