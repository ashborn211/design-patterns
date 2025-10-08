using DecoratorPattern.Beverages;

namespace DecoratorPattern.Store
{
    internal abstract class CoffeeStore
    {
        // Template Method
        public Beverage OrderCoffee(string type, Size size)
        {
            Beverage beverage = CreateBeverage(type, size);

            Console.WriteLine($"\n--- {type.ToUpper()} ---");
            PrepareCoffee();
            BrewCoffee();
            PourInCup();
            AddCondiments();

            Console.WriteLine($"{beverage.GetDescription()} | Size: {beverage.Size} | Price: ${beverage.cost():0.##}");
            Console.WriteLine("-------------------------------------------------");

            return beverage;
        }

        // Abstract factory method
        protected abstract Beverage CreateBeverage(string type, Size size);

        // Workflow steps with full method bodies
        protected void PrepareCoffee()
        {
            Console.WriteLine("Grinding beans...");
        }

        protected void BrewCoffee()
        {
            Console.WriteLine("Brewing coffee...");
        }

        protected void PourInCup()
        {
            Console.WriteLine("Pouring coffee into cup...");
        }

        protected virtual void AddCondiments()
        {
            Console.WriteLine("Adding condiments...");
        }

        // Show all sizes without serving
        public void ShowAllSize(string type)
        {
            Console.WriteLine($"\n### {type.ToUpper()} MENU ###");

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                Beverage coffee = CreateBeverage(type, size);
                Console.WriteLine($"{coffee.GetDescription()} | Size: {size} | Price: ${coffee.cost():0.##}");
            }

            Console.WriteLine("-------------------------------------------------");
        }
    }
}
