using RestaurantAPI.Models;

namespace RestaurantAPI.Data;

public static class FullMenu
{
     public static MenuItem coke = new MenuItem()
     {
          MenuItemName = "Coke",
          MenuItemDescription = "Made By Coca Cola (Not Diet Coke)",
          MenuItemPrice = 200m

     };
     public static MenuItem dietcoke = new MenuItem()
     {
          MenuItemName = "Diet Coke",
          MenuItemDescription = "Made By Coca Cola (Less Sugar)",
          MenuItemPrice = 0.65m
     };
     public static MenuItem water = new MenuItem()
     {
          MenuItemName = "Water",
          MenuItemDescription = "Plain Clean Bottled Water",
          MenuItemPrice = 1m
     };
     public static MenuItem fourcousins = new MenuItem()
     {
          MenuItemName = "Four Cousins",
          MenuItemDescription = "Mild Alcohol",
          MenuItemPrice = 15m
     };
     public static MenuItem saltwater = new MenuItem()
     {
          MenuItemName = "Salt Water",
          MenuItemDescription = "Water with Electrolytes",
          MenuItemPrice = 1.15m
     };
     public static MenuItem bruschettatrio = new MenuItem()
     {
          MenuItemName = "Bruschetta Trio",
          MenuItemDescription = "A delightful trio of bruschettas featuring classic tomato and basil, creamy goat cheese with honey and walnuts, and smoked salmon with dill. Served on toasted ciabatta slices.",
          MenuItemPrice = 8.65m
     };
     public static MenuItem stuffedmushroom = new MenuItem()
     {
          MenuItemName = "Stuffed Mushroom",
          MenuItemDescription = "savory blend of spinach, garlic, and Parmesan cheese, baked to perfection. Served with a drizzle of balsamic glaze for a burst of flavor.",
          MenuItemPrice = 7.60m
     };
     public static MenuItem tempuraprawns = new MenuItem()
     {
          MenuItemName = "Tempura Prawns",
          MenuItemDescription = "Light and crispy tempura-battered prawns served with a zesty sweet chili dipping sauce. A perfect combination of crunchy texture and succulent seafood.",
          MenuItemPrice = 9.99m
     };
     public static MenuItem capreseskewers = new MenuItem()
     {
          MenuItemName = "Caprese Skewers",
          MenuItemDescription = "Fresh mozzarella, cherry tomatoes, and basil leaves threaded onto skewers and drizzled with balsamic glaze. A classic Italian appetizer that's both refreshing and flavorful.",
          MenuItemPrice = 6.95m
     };
     public static MenuItem chickensatay = new MenuItem()
     {
          MenuItemName = "Chicken Satay",
          MenuItemDescription = "Grilled marinated chicken skewers served with a side of peanut sauce. The tender chicken and rich, savory peanut sauce create a harmonious blend of flavors with a hint of sweetness.",
          MenuItemPrice = 8.95m
     };
     public static MenuItem chickensandwich = new MenuItem()
     {
          MenuItemName = "Chicken Sandwich",
          MenuItemDescription = "bread, butter, chicken, cheese",
          MenuItemPrice = 2.5m
     };
     public static MenuItem tunasandwich = new MenuItem()
     {
          MenuItemName = "Tuna Sandwich",
          MenuItemDescription = "Tuna,sweetcorn,cheese,bread",
          MenuItemPrice = 2.20m
     };
     public static MenuItem pestochickenpanini = new MenuItem()
     {
          MenuItemName = "Pesto Chicken Panini",
          MenuItemDescription = "Grilled chicken breast, sun-dried tomatoes, fresh spinach, and melted mozzarella cheese, all sandwiched between artisanal ciabatta bread spread with basil pesto.",
          MenuItemPrice = 10.99m
     };
     public static MenuItem vegetarianbuddha = new MenuItem()
     {
          MenuItemName = "Vegetarian Buddha Bowl",
          MenuItemDescription = "A wholesome bowl featuring quinoa, roasted vegetables, avocado slices, chickpeas, and a drizzle of tahini dressing. A nutritious and flavorful vegetarian option.",
          MenuItemPrice = 9.95m
     };
     public static MenuItem shrimpandavocadowrap = new MenuItem()
     {
          MenuItemName = "Shrimp and Avocado Wrap",
          MenuItemDescription = "Succulent shrimp, ripe avocado, crisp lettuce, and diced tomatoes wrapped in a soft flour tortilla. Served with a zesty lime-cilantro dressing on the side.",
          MenuItemPrice = 11.75m
     };
     public static MenuItem grilledsalmonwithlemondillsauce = new MenuItem()
     {
          MenuItemName = "Grilled Salmon with Lemon-Dill Sauce",
          MenuItemDescription = "A perfectly grilled salmon fillet topped with a zesty lemon-dill sauce. Served alongside roasted garlic mashed potatoes and sautéed asparagus spears.",
          MenuItemPrice = 17.99m
     };
     public static MenuItem trufflemushroomrisotto = new MenuItem()
     {
          MenuItemName = "Truffle Mushroom Risotto",
          MenuItemDescription = "Creamy Arborio rice cooked to perfection with a medley of wild mushrooms, finished with truffle oil and Parmesan cheese. Garnished with fresh chives.",
          MenuItemPrice = 15.95m
     };
     public static MenuItem bbqpulledporktacos = new MenuItem()
     {
          MenuItemName = "BBQ Pulled Pork Tacos",
          MenuItemDescription = "Slow-cooked pulled pork tossed in smoky barbecue sauce, served in soft corn tortillas with shredded cabbage, pickled red onions, and a drizzle of chipotle mayo.",
          MenuItemPrice = 14.50m
     };
     public static MenuItem moroccanspicedchickentagine = new MenuItem()
     {
          MenuItemName = "Moroccan Spiced Chicken Tagine",
          MenuItemDescription = "Tender chicken thighs slow-cooked with aromatic Moroccan spices, apricots, and almonds. Served with couscous and a side of cucumber-mint yogurt.",
          MenuItemPrice = 16.99m
     };
     public static MenuItem teriyakiglazedbeefskewers = new MenuItem()
     {
          MenuItemName = "Teriyaki Glazed Beef Skewers",
          MenuItemDescription = "Skewers of marinated and grilled beef, glazed with a sweet and savory teriyaki sauce. Served with jasmine rice and stir-fried vegetables.",
          MenuItemPrice = 16.75m
     };
     public static MenuItem chocolatelavacake = new MenuItem()
     {
          MenuItemName = "Chocolate Lava Cake",
          MenuItemDescription = "A decadent chocolate lava cake with a gooey molten center. Served warm and dusted with powdered sugar, accompanied by a scoop of vanilla ice cream.",
          MenuItemPrice = 8.99m
     };
     public static MenuItem raspberrycheesecake = new MenuItem()
     {
          MenuItemName = "Raspberry Cheesecake",
          MenuItemDescription = "Creamy New York-style cheesecake swirled with raspberry compote on a graham cracker crust. Topped with fresh raspberries and a raspberry coulis.",
          MenuItemPrice = 10.50m
     };
     public static MenuItem tiramisu = new MenuItem()
     {
          MenuItemName = "Tiramisu",
          MenuItemDescription = "Layers of coffee-soaked ladyfingers and mascarpone cream, dusted with cocoa powder. A classic Italian dessert, served chilled for a delightful pick-me-up.",
          MenuItemPrice = 9.25m
     };
     public static MenuItem stickydatepudding = new MenuItem()
     {
          MenuItemName = "Sticky Date Pudding",
          MenuItemDescription = "A moist and rich date pudding drizzled with warm toffee sauce. Served with a scoop of vanilla ice cream or a dollop of whipped cream.",
          MenuItemPrice = 7.50m
     };
     public static MenuItem mangosorbetwithfreshberries = new MenuItem()
     {
          MenuItemName = "Mango Sorbet with Fresh Berries",
          MenuItemDescription = "Refreshing mango sorbet served in a frozen mango shell, accompanied by a medley of fresh berries and a mint garnish.",
          MenuItemPrice = 6.95m
     };














}