using DecoratorPattern.Beverages;
using DecoratorPattern.Factory;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintBeverage(BeverageFactory.Create("espresso", Size.TALL));
            PrintBeverage(BeverageFactory.Create("doppio", Size.GRANDE));
            PrintBeverage(BeverageFactory.Create("lungo", Size.VENDI));
            PrintBeverage(BeverageFactory.Create("ristretto", Size.TALL));
            PrintBeverage(BeverageFactory.Create("macchiato", Size.GRANDE));
            PrintBeverage(BeverageFactory.Create("corretto", Size.VENDI));
            PrintBeverage(BeverageFactory.Create("con panna"));
            PrintBeverage(BeverageFactory.Create("cappuccino", Size.GRANDE));
            PrintBeverage(BeverageFactory.Create("americano"));
            PrintBeverage(BeverageFactory.Create("latte"));
            PrintBeverage(BeverageFactory.Create("flat white"));
            PrintBeverage(BeverageFactory.Create("romano", Size.TALL));
            PrintBeverage(BeverageFactory.Create("marocchino"));
            PrintBeverage(BeverageFactory.Create("mocha"));
            PrintBeverage(BeverageFactory.Create("bicerin", Size.VENDI));
            PrintBeverage(BeverageFactory.Create("breve"));
            PrintBeverage(BeverageFactory.Create("raf"));
            PrintBeverage(BeverageFactory.Create("mead raf", Size.TALL));
            PrintBeverage(BeverageFactory.Create("galao"));
            PrintBeverage(BeverageFactory.Create("affogato"));
            PrintBeverage(BeverageFactory.Create("vienna", Size.GRANDE));
            PrintBeverage(BeverageFactory.Create("glace"));
            PrintBeverage(BeverageFactory.Create("chocolate milk"));
            PrintBeverage(BeverageFactory.Create("demi-crème"));
            PrintBeverage(BeverageFactory.Create("latte macchiato"));
            PrintBeverage(BeverageFactory.Create("freddo", Size.TALL));
            PrintBeverage(BeverageFactory.Create("frappuccino"));
            PrintBeverage(BeverageFactory.Create("caramel frappuccino"));
            PrintBeverage(BeverageFactory.Create("frappe"));
            PrintBeverage(BeverageFactory.Create("irish coffee"));
        }

        static void PrintBeverage(Beverage beverage)
        {
            Console.WriteLine($"{beverage.GetDescription()} Size:{beverage.Size} ${beverage.cost():0.##}");
        }
    }
}
