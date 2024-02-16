namespace RestaurantAPI.Models;


public static class FullOrder
{
    public static Dictionary<string, MenuItem> AllOrders { get; set; } = Order.CartItems;

    private static decimal _amountBeforeTax = Totalbeforetax();

    public static decimal AmountBeforeTax
    {
        get
        {
            return _amountBeforeTax;
        }

    }

    public static decimal Totalbeforetax()
    {
        decimal total = 0;
        foreach (var pair in AllOrders)
        {
            
            total += pair.Value.MenuItemPrice;
        }

        return total;
    }

    private static decimal _tax;
    public static decimal Tax
    {
        get
        {
            return AmountBeforeTax * 0.1m;
        }
    } 

    private static decimal _totalAfterTax;
    public static decimal TotalAfterTax
    {
        get
        {
            return AmountBeforeTax + Tax;
        }
        
    }

   

}