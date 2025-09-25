using DecoratorPattern.Beverages;
using DecoratorPattern.Factory;
using DecoratorPattern.Store;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Explicitly typed variables
            SimpleCoffeeFactory factory = new SimpleCoffeeFactory();
            CoffeeStore store = new CoffeeStore();

            // All 30 coffees
            store.OrderCoffee("espresso", Size.TALL);
            store.OrderCoffee("doppio", Size.GRANDE);
            store.OrderCoffee("lungo", Size.VENDI);
            store.OrderCoffee("ristretto", Size.TALL);
            store.OrderCoffee("macchiato", Size.GRANDE);
            store.OrderCoffee("corretto", Size.VENDI);
            store.OrderCoffee("con panna");
            store.OrderCoffee("cappuccino", Size.GRANDE);
            store.OrderCoffee("americano");
            store.OrderCoffee("latte");
            store.OrderCoffee("flat white");
            store.OrderCoffee("romano", Size.TALL);
            store.OrderCoffee("marocchino");
            store.OrderCoffee("mocha");
            store.OrderCoffee("bicerin", Size.VENDI);
            store.OrderCoffee("breve");
            store.OrderCoffee("raf");
            store.OrderCoffee("mead raf", Size.TALL);
            store.OrderCoffee("galao");
            store.OrderCoffee("affogato");
            store.OrderCoffee("vienna", Size.GRANDE);
            store.OrderCoffee("glace");
            store.OrderCoffee("chocolate milk");
            store.OrderCoffee("demi-crème");
            store.OrderCoffee("latte macchiato");
            store.OrderCoffee("freddo", Size.TALL);
            store.OrderCoffee("frappuccino");
            store.OrderCoffee("caramel frappuccino");
            store.OrderCoffee("frappe");
            store.OrderCoffee("irish coffee");
        }
    }
}
