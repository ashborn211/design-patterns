using DecoratorPattern.Beverages;
using DecoratorPattern.Factory;

namespace DecoratorPattern.Store
{
    internal class CoffeeStore
    {
        public CoffeeStore() { }

        private void PrepareCoffee()
        {
            Console.WriteLine("Grinding beans");
        }

        private void BrewCoffee()
        {
            Console.WriteLine("Brewing coffee");
        }

        private void PourInCup()
        {
            Console.WriteLine("Pouring coffee into cup");
        }

        private void AddCondiments()
        {
            Console.WriteLine("Adding condiments");
        }

        private Beverage ServeCoffee(string type, Size size)
        {
            Beverage coffee = BeverageFactory.Create(type, size);

            Console.WriteLine($"\n--- {type.ToUpper()} ---");
            PrepareCoffee();
            BrewCoffee();
            PourInCup();
            AddCondiments();

            Console.WriteLine($"{coffee.GetDescription()} | Size: {coffee.Size} | Price: ${coffee.cost():0.##}");
            Console.WriteLine("-------------------------------------------------");

            return coffee;
        }

        public void OrderCoffee(string type, Size size)
        {
            ServeCoffee(type, size);
        }

        public void ShowAllCoffee(string type)
        {
            Console.WriteLine($"\n--- {type.ToUpper()} MENU ---");

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                Beverage coffee = BeverageFactory.Create(type, size);
                Console.WriteLine($"{coffee.GetDescription()} | Size: {size} | Price: ${coffee.cost():0.##}");
            }

            Console.WriteLine("-------------------------------------------------");
        }
    }
}
