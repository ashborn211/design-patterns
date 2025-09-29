using DecoratorPattern.Beverages;
using DecoratorPattern.Store;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CoffeeStore store = new CoffeeStore();

            Console.WriteLine("Welcome to the Coffee Store!");
            Console.WriteLine("Here is our menu with all available coffee types and sizes:\n");
            //menu
            store.ShowAllCoffee("espresso");
            store.ShowAllCoffee("doppio");
            store.ShowAllCoffee("lungo");
            store.ShowAllCoffee("ristretto");
            store.ShowAllCoffee("macchiato");
            store.ShowAllCoffee("corretto");
            store.ShowAllCoffee("con panna");
            store.ShowAllCoffee("cappuccino");
            store.ShowAllCoffee("americano");
            store.ShowAllCoffee("latte");
            store.ShowAllCoffee("flat white");
            store.ShowAllCoffee("romano");
            store.ShowAllCoffee("marocchino");
            store.ShowAllCoffee("mocha");
            store.ShowAllCoffee("bicerin");
            store.ShowAllCoffee("breve");
            store.ShowAllCoffee("raf");
            store.ShowAllCoffee("mead raf");
            store.ShowAllCoffee("galao");
            store.ShowAllCoffee("affogato");
            store.ShowAllCoffee("vienna");
            store.ShowAllCoffee("glace");
            store.ShowAllCoffee("chocolate milk");
            store.ShowAllCoffee("demi crème");
            store.ShowAllCoffee("latte macchiato");
            store.ShowAllCoffee("freddo");
            store.ShowAllCoffee("frappuccino");
            store.ShowAllCoffee("caramel frappuccino");
            store.ShowAllCoffee("frappe");
            store.ShowAllCoffee("irish coffee");

            Console.WriteLine("\nNow ordering coffee:\n");
            Console.WriteLine("-------------------------------------------------");

            // Order
            store.OrderCoffee("espresso", Size.TALL);
            store.OrderCoffee("doppio", Size.GRANDE);
            store.OrderCoffee("lungo", Size.VENDI);
            store.OrderCoffee("ristretto", Size.TALL);
            store.OrderCoffee("macchiato", Size.GRANDE);
            store.OrderCoffee("corretto", Size.VENDI);
            store.OrderCoffee("con panna", Size.TALL);
            store.OrderCoffee("cappuccino", Size.GRANDE);
            store.OrderCoffee("americano", Size.VENDI);
            store.OrderCoffee("latte", Size.TALL);
            store.OrderCoffee("flat white", Size.GRANDE);
            store.OrderCoffee("romano", Size.VENDI);
            store.OrderCoffee("marocchino", Size.TALL);
            store.OrderCoffee("mocha", Size.GRANDE);
            store.OrderCoffee("bicerin", Size.VENDI);
            store.OrderCoffee("breve", Size.TALL);
            store.OrderCoffee("raf", Size.GRANDE);
            store.OrderCoffee("mead raf", Size.VENDI);
            store.OrderCoffee("galao", Size.TALL);
            store.OrderCoffee("affogato", Size.GRANDE);
            store.OrderCoffee("vienna", Size.VENDI);
            store.OrderCoffee("glace", Size.TALL);
            store.OrderCoffee("chocolate milk", Size.GRANDE);
            store.OrderCoffee("demi crème", Size.VENDI);
            store.OrderCoffee("latte macchiato", Size.TALL);
            store.OrderCoffee("freddo", Size.GRANDE);
            store.OrderCoffee("frappuccino", Size.VENDI);
            store.OrderCoffee("caramel frappuccino", Size.TALL);
            store.OrderCoffee("frappe", Size.GRANDE);
            store.OrderCoffee("irish coffee", Size.VENDI);
        }
    }
}
