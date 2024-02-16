using RestaurantAPI.Data;

namespace RestaurantAPI.Models;

public class Restaurant
{
    public string RestaurantName { get; set; }

    public string CuisineType { get; set; }
    public Dictionary<string, MenuCategory> Menu { get; } = new();
    
    public Restaurant()
    {
        Menu["Drinks(Non-Alcoholic)"] = new MenuCategory();
        Menu["Appetizers"] = new MenuCategory();
        Menu["Lunch Special"] = new MenuCategory();
        Menu["Dinner"] = new MenuCategory();
        Menu["Dessert"] = new MenuCategory();

        Menu["Drinks(Non-Alcoholic)"].AddMenuItemToTheCategory(FullMenu.coke);
        Menu["Drinks(Non-Alcoholic)"].AddMenuItemToTheCategory(FullMenu.dietcoke);
        Menu["Drinks(Non-Alcoholic)"].AddMenuItemToTheCategory(FullMenu.water);
        Menu["Drinks(Non-Alcoholic)"].AddMenuItemToTheCategory(FullMenu.fourcousins);
        Menu["Drinks(Non-Alcoholic)"].AddMenuItemToTheCategory(FullMenu.saltwater);

        Menu["Appetizers"].AddMenuItemToTheCategory(FullMenu.bruschettatrio);
        Menu["Appetizers"].AddMenuItemToTheCategory(FullMenu.stuffedmushroom);
        Menu["Appetizers"].AddMenuItemToTheCategory(FullMenu.tempuraprawns);
        Menu["Appetizers"].AddMenuItemToTheCategory(FullMenu.capreseskewers);
        Menu["Appetizers"].AddMenuItemToTheCategory(FullMenu.chickensatay);

        Menu["Lunch Special"].AddMenuItemToTheCategory(FullMenu.chickensandwich);
        Menu["Lunch Special"].AddMenuItemToTheCategory(FullMenu.tunasandwich);
        Menu["Lunch Special"].AddMenuItemToTheCategory(FullMenu.pestochickenpanini);
        Menu["Lunch Special"].AddMenuItemToTheCategory(FullMenu.vegetarianbuddha);
        Menu["Lunch Special"].AddMenuItemToTheCategory(FullMenu.shrimpandavocadowrap);

        Menu["Dinner"].AddMenuItemToTheCategory(FullMenu.grilledsalmonwithlemondillsauce);
        Menu["Dinner"].AddMenuItemToTheCategory(FullMenu.trufflemushroomrisotto);
        Menu["Dinner"].AddMenuItemToTheCategory(FullMenu.bbqpulledporktacos);
        Menu["Dinner"].AddMenuItemToTheCategory(FullMenu.moroccanspicedchickentagine);
        Menu["Dinner"].AddMenuItemToTheCategory(FullMenu.teriyakiglazedbeefskewers);

        Menu["Dessert"].AddMenuItemToTheCategory(FullMenu.chocolatelavacake);
        Menu["Dessert"].AddMenuItemToTheCategory(FullMenu.raspberrycheesecake);
        Menu["Dessert"].AddMenuItemToTheCategory(FullMenu.tiramisu);
        Menu["Dessert"].AddMenuItemToTheCategory(FullMenu.stickydatepudding);
        Menu["Dessert"].AddMenuItemToTheCategory(FullMenu.mangosorbetwithfreshberries);




    }

    public void AddMenuItemToCategory(string categoryName, MenuItem item)
    {
        Menu[categoryName].AddMenuItemToTheCategory(item);
    }

    public void DisplayMenu()
    {

    }

}