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

    public static void SaveToFile()
    {
        string filepath = @"order.txt";

        using (StreamWriter writer = new StreamWriter(filepath))
        {
            writer.WriteLine("Order: ");
            foreach (var (itemName, item) in AllOrders)
            {
                writer.WriteLine($"{itemName}: {item.MenuItemDescription} - ${item.MenuItemPrice:F2}");
            }
            writer.WriteLine("Total before tax: ");
            writer.WriteLine(AmountBeforeTax);
            writer.WriteLine("Tax amount at 10%: ");
            writer.WriteLine(Tax);
            writer.WriteLine("Subtotal: ");
            writer.WriteLine(TotalAfterTax);




        }

    } 

}