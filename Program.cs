using DecoratorPattern.Beverages;
using DecoratorPattern.Store;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StarbuzzCoffeeStore store = new StarbuzzCoffeeStore(); // concrete store

            Console.WriteLine("Welcome to Starbuzz");
            Console.WriteLine("Here is our menu with all available coffee types and sizes:");

            store.ShowAllSize("espresso");
            store.ShowAllSize("doppio");
            store.ShowAllSize("lungo");
            store.ShowAllSize("ristretto");
            store.ShowAllSize("macchiato");
            store.ShowAllSize("corretto");
            store.ShowAllSize("con panna");
            store.ShowAllSize("cappuccino");
            store.ShowAllSize("americano");
            store.ShowAllSize("latte");
            store.ShowAllSize("flat white");
            store.ShowAllSize("romano");
            store.ShowAllSize("marocchino");
            store.ShowAllSize("mocha");
            store.ShowAllSize("bicerin");
            store.ShowAllSize("breve");
            store.ShowAllSize("raf");
            store.ShowAllSize("mead raf");
            store.ShowAllSize("galao");
            store.ShowAllSize("affogato");
            store.ShowAllSize("vienna");
            store.ShowAllSize("glace");
            store.ShowAllSize("chocolate milk");
            store.ShowAllSize("demi crème");
            store.ShowAllSize("latte macchiato");
            store.ShowAllSize("freddo");
            store.ShowAllSize("frappuccino");
            store.ShowAllSize("caramel frappuccino");
            store.ShowAllSize("frappe");
            store.ShowAllSize("irish coffee");

            Console.WriteLine("\nNow ordering coffee:\n");
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
