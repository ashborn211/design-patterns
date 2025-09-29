using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;

namespace DecoratorPattern.Factory
{
    internal static class BeverageFactory
    {
        public static Beverage Create(string beverageName, Size size)
        {
            Beverage drink;

            switch (beverageName.ToLower())
            {
                // 1
                case "espresso":
                    drink = new Espresso();
                    drink.Size = size;
                    break;

                // 2
                case "doppio":
                    drink = new Espresso();
                    drink = new Espresso(drink);
                    break;

                // 3
                case "lungo":
                    drink = new Espresso();
                    drink = new Water(drink);
                    break;

                // 4
                case "ristretto":
                    drink = new Espresso();
                    break;

                // 5
                case "macchiato":
                    drink = new Espresso();
                    drink = new Milk_Foam(drink);
                    break;

                // 6
                case "corretto":
                    drink = new Espresso();
                    drink = new Liqour(drink);
                    break;

                // 7
                case "con panna":
                    drink = new Espresso();
                    drink = new Whip(drink);
                    break;

                // 8
                case "cappuccino":
                    drink = new Espresso();
                    drink = new Half_Milk(drink);
                    drink = new Milk_Foam(drink);
                    break;

                // 9
                case "americano":
                    drink = new Espresso();
                    drink = new Water(drink);
                    drink = new Water(drink);
                    break;

                // 10
                case "latte":
                    drink = new Espresso();
                    drink = new Half_Milk(drink);
                    drink = new Milk_Foam(drink);
                    break;

                // 11
                case "flat white":
                    drink = new Espresso();
                    drink = new Half_Milk(drink);
                    break;

                // 12
                case "romano":
                    drink = new Espresso();
                    drink = new Lemon(drink);
                    break;

                // 13
                case "marocchino":
                    drink = new Espresso();
                    drink = new Chocolate(drink);
                    drink = new Milk_Foam(drink);
                    break;

                // 14
                case "mocha":
                    drink = new Espresso();
                    drink = new Chocolate(drink);
                    drink = new Half_Milk(drink);
                    drink = new Whip(drink);
                    break;

                // 15
                case "bicerin":
                    drink = new Espresso();
                    drink = new Chocolate(drink);
                    drink = new Whip(drink);
                    break;

                // 16
                case "breve":
                    drink = new Espresso();
                    drink = new Half_Milk(drink);
                    drink = new Milk_Foam(drink);
                    break;

                // 17
                case "raf":
                    drink = new Espresso();
                    drink = new Cream(drink);
                    drink = new Vanilla_Sugar(drink);
                    drink.Size = size;
                    break;

                // 18
                case "mead raf":
                    drink = new Espresso();
                    drink = new Cream(drink);
                    drink = new Honey(drink);
                    break;

                // 19
                case "galao":
                    drink = new Espresso();
                    drink = new Milk_Foam(drink);
                    break;

                // 20
                case "affogato":
                    drink = new Espresso();
                    drink = new Ice_cream(drink);
                    break;

                // 21
                case "vienna":
                    drink = new Espresso();
                    drink = new Whip(drink);
                    break;

                // 22
                case "glace":
                    drink = new Espresso();
                    drink = new Ice_cream(drink);
                    break;

                // 23
                case "chocolate milk":
                    drink = new Espresso();
                    drink = new Half_Milk(drink);
                    drink = new Black_chocolate(drink);
                    break;

                // 24
                case "demi crème":
                    drink = new Espresso();
                    drink = new Cream(drink);
                    break;

                // 25
                case "latte macchiato":
                    drink = new Espresso();
                    drink = new Half_Milk(drink);
                    drink = new Milk_Foam(drink);
                    break;

                // 26
                case "freddo":
                    drink = new Espresso();
                    drink = new Liqour(drink);
                    drink = new Ice(drink);
                    break;

                // 27
                case "frappuccino":
                    drink = new Espresso();
                    drink = new Half_Milk(drink);
                    drink = new Whip(drink);
                    break;

                // 28
                case "caramel frappuccino":
                    drink = new Espresso();
                    drink = new Half_Milk(drink);
                    drink = new Syrup(drink);
                    drink = new Cream(drink);
                    break;

                // 29
                case "frappe":
                    drink = new Espresso();
                    drink = new Half_Milk(drink);
                    drink = new Ice_cream(drink);
                    break;

                // 30
                case "irish coffee":
                    drink = new Espresso();
                    drink = new Whiskey(drink);
                    drink = new Whip(drink);
                    break;

                default:
                    throw new ArgumentException($"Unknown beverage: {beverageName}");
            }
            drink.Size = size;
            return drink;
        }
    }
}
