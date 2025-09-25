using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;

namespace DecoratorPattern.Factory
{
    internal static class BeverageFactory
    {
        public static Beverage Create(string beverageName, Size size = Size.TALL)
        {
            Beverage drink;

            switch (beverageName.ToLower())
            {
                // 1. Espresso
                case "espresso":
                    drink = new Espresso();
                    break;

                // 2. Doppio (double/triple espresso)
                case "doppio":
                    drink = new Espresso();
                    drink = new Espresso(drink);
                    break;

                // 3. Lungo
                case "lungo":
                    drink = new Espresso();
                    drink = new Water(drink);
                    break;

                // 4. Ristretto
                case "ristretto":
                    drink = new Espresso();
                    break;

                // 5. Macchiato
                case "macchiato":
                    drink = new Espresso();
                    drink = new Milk_Foam(drink);
                    break;

                // 6. Corretto
                case "corretto":
                    drink = new Espresso();
                    drink = new Liqour(drink);
                    break;

                // 7. Con Panna
                case "con panna":
                    drink = new Espresso();
                    drink = new Whip(drink);
                    break;

                // 8. Cappuccino
                case "cappuccino":
                    drink = new Espresso();
                    drink = new Half_Milk(drink);
                    drink = new Milk_Foam(drink);
                    break;

                // 9. Americano
                case "americano":
                    drink = new Espresso();
                    drink = new Water(drink);
                    drink = new Water(drink);
                    break;

                // 10. Caffè Latte
                case "latte":
                    drink = new Espresso();
                    drink = new Half_Milk(drink);
                    drink = new Milk_Foam(drink);
                    break;

                // 11. Flat White
                case "flat white":
                    drink = new Espresso();
                    drink = new Half_Milk(drink);
                    break;

                // 12. Romano
                case "romano":
                    drink = new Espresso();
                    drink = new Lemon(drink);
                    break;

                // 13. Marocchino
                case "marocchino":
                    drink = new Espresso();
                    drink = new Chocolate(drink);
                    drink = new Milk_Foam(drink);
                    break;

                // 14. Mocha
                case "mocha":
                    drink = new Espresso();
                    drink = new Chocolate(drink);
                    drink = new Half_Milk(drink);
                    drink = new Whip(drink);
                    break;

                // 15. Bicerin
                case "bicerin":
                    drink = new Espresso();
                    drink = new Chocolate(drink);
                    drink = new Whip(drink);
                    break;

                // 16. Breve
                case "breve":
                    drink = new Espresso();
                    drink = new Half_Milk(drink);
                    drink = new Milk_Foam(drink);
                    break;

                // 17. Raf Coffee
                case "raf":
                    drink = new Espresso();
                    drink = new Cream(drink);
                    drink = new Vanilla_Sugar(drink);
                    break;

                // 18. Mead Raf
                case "mead raf":
                    drink = new Espresso();
                    drink = new Cream(drink);
                    drink = new Honey(drink);
                    break;

                // 19. Galao
                case "galao":
                    drink = new Espresso();
                    drink = new Milk_Foam(drink);
                    break;

                // 20. Affogato
                case "affogato":
                    drink = new Espresso();
                    drink = new Ice_cream(drink);
                    break;

                // 21. Vienna
                case "vienna":
                    drink = new Espresso();
                    drink = new Whip(drink);
                    break;

                // 22. Glace
                case "glace":
                    drink = new Espresso();
                    drink = new Ice_cream(drink);
                    break;

                // 23. Chocolate Milk
                case "chocolate milk":
                    drink = new Espresso();
                    drink = new Half_Milk(drink);
                    drink = new Black_chocolate(drink);
                    break;

                // 24. Demi-Crème
                case "demi-crème":
                    drink = new Espresso();
                    drink = new Cream(drink);
                    break;

                // 25. Latte Macchiato
                case "latte macchiato":
                    drink = new Espresso();
                    drink = new Half_Milk(drink);
                    drink = new Milk_Foam(drink);
                    break;

                // 26. Freddo
                case "freddo":
                    drink = new Espresso();
                    drink = new Liqour(drink);
                    drink = new Ice(drink);
                    break;

                // 27. Frappuccino
                case "frappuccino":
                    drink = new Espresso();
                    drink = new Half_Milk(drink);
                    drink = new Whip(drink);
                    break;

                // 28. Caramel Frappuccino
                case "caramel frappuccino":
                    drink = new Espresso();
                    drink = new Half_Milk(drink);
                    drink = new Syrup(drink);
                    drink = new Cream(drink);
                    break;

                // 29. Frappe
                case "frappe":
                    drink = new Espresso();
                    drink = new Half_Milk(drink);
                    drink = new Ice_cream(drink);
                    break;

                // 30. Irish Coffee
                case "irish coffee":
                    drink = new Espresso();
                    drink = new Whiskey(drink);
                    drink = new Whip(drink);
                    break;

                default:
                    throw new ArgumentException($"Unknown beverage: {beverageName}");
            }

            // set size
            drink.Size = size;
            return drink;
        }
    }
}
