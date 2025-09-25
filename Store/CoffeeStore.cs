namespace DecoratorPattern.Store
{
    using DecoratorPattern.Beverages;
    using DecoratorPattern.Factory;

    internal class CoffeeStore
    {
        public Beverage OrderCoffee(string type, Size size = Size.TALL)
        {
            Beverage coffee = BeverageFactory.Create(type, size);

            Console.WriteLine($"{coffee.GetDescription()} Size: {coffee.Size} Price: ${coffee.cost():0.##}");
            Console.WriteLine("-------------------------------------------------");

            return coffee;
        }
    }
}
