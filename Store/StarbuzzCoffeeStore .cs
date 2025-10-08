using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;

namespace DecoratorPattern.Store
{
    internal class StarbuzzCoffeeStore : CoffeeStore
    {
        protected override Beverage CreateBeverage(string type, Size size)
        {
            Beverage drink;

            switch (type.ToLower())
            {
                case "espresso":
                    drink = new Espresso();
                    drink.Size = size;
                    break;
                case "doppio":
                    drink = new Espresso();
                    drink = new Espresso(drink);
                    break;
                case "lungo":
                    drink = new Espresso();
                    drink = new Water(drink);
                    break;
                case "ristretto":
                    drink = new Espresso();
                    break;
                case "macchiato":
                    drink = new Espresso();
                    drink = new Milk_Foam(drink);
                    break;
                case "corretto":
                    drink = new Espresso();
                    drink = new Liqour(drink);
                    break;
                case "con panna":
                    drink = new Espresso();
                    drink = new Whip(drink);
                    break;
                case "cappuccino":
                    drink = new Espresso();
                    drink = new Half_Milk(drink);
                    drink = new Milk_Foam(drink);
                    break;
                case "americano":
                    drink = new Espresso();
                    drink = new Water(drink);
                    drink = new Water(drink);
                    break;
                case "latte":
                    drink = new Espresso();
                    drink = new Half_Milk(drink);
                    drink = new Milk_Foam(drink);
                    break;
                case "flat white":
                    drink = new Espresso();
                    drink = new Half_Milk(drink);
                    break;
                case "romano":
                    drink = new Espresso();
                    drink = new Lemon(drink);
                    break;
                case "marocchino":
                    drink = new Espresso();
                    drink = new Chocolate(drink);
                    drink = new Milk_Foam(drink);
                    break;
                case "mocha":
                    drink = new Espresso();
                    drink = new Chocolate(drink);
                    drink = new Half_Milk(drink);
                    drink = new Whip(drink);
                    break;
                case "bicerin":
                    drink = new Espresso();
                    drink = new Chocolate(drink);
                    drink = new Whip(drink);
                    break;
                case "breve":
                    drink = new Espresso();
                    drink = new Half_Milk(drink);
                    drink = new Milk_Foam(drink);
                    break;
                case "raf":
                    drink = new Espresso();
                    drink = new Cream(drink);
                    drink = new Vanilla_Sugar(drink);
                    break;
                case "mead raf":
                    drink = new Espresso();
                    drink = new Cream(drink);
                    drink = new Honey(drink);
                    break;
                case "galao":
                    drink = new Espresso();
                    drink = new Milk_Foam(drink);
                    break;
                case "affogato":
                    drink = new Espresso();
                    drink = new Ice_cream(drink);
                    break;
                case "vienna":
                    drink = new Espresso();
                    drink = new Whip(drink);
                    break;
                case "glace":
                    drink = new Espresso();
                    drink = new Ice_cream(drink);
                    break;
                case "chocolate milk":
                    drink = new Espresso();
                    drink = new Half_Milk(drink);
                    drink = new Black_chocolate(drink);
                    break;
                case "demi crème":
                    drink = new Espresso();
                    drink = new Cream(drink);
                    break;
                case "latte macchiato":
                    drink = new Espresso();
                    drink = new Half_Milk(drink);
                    drink = new Milk_Foam(drink);
                    break;
                case "freddo":
                    drink = new Espresso();
                    drink = new Liqour(drink);
                    drink = new Ice(drink);
                    break;
                case "frappuccino":
                    drink = new Espresso();
                    drink = new Half_Milk(drink);
                    drink = new Whip(drink);
                    break;
                case "caramel frappuccino":
                    drink = new Espresso();
                    drink = new Half_Milk(drink);
                    drink = new Syrup(drink);
                    drink = new Cream(drink);
                    break;
                case "frappe":
                    drink = new Espresso();
                    drink = new Half_Milk(drink);
                    drink = new Ice_cream(drink);
                    break;
                case "irish coffee":
                    drink = new Espresso();
                    drink = new Whiskey(drink);
                    drink = new Whip(drink);
                    break;
                default:
                    throw new ArgumentException($"Unknown beverage: {type}");
            }

            drink.Size = size;
            return drink;
        }
    }
}
