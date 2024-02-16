namespace RestaurantAPI.Models;

public static class Order
{
    public static Dictionary<string, MenuItem> CartItems { get; set; } = new Dictionary<string, MenuItem>();


}