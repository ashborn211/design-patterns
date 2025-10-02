namespace SingletonPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChocolateBoiler boiler1 = ChocolateBoiler.GetInstance();
            ChocolateBoiler boiler2 = ChocolateBoiler.GetInstance();

            // Use the boiler
            boiler1.Fill();
            boiler1.Boil();
            boiler1.Drain();

            // Verify both references point to the same instance
            Console.WriteLine(Object.ReferenceEquals(boiler1, boiler2));
        }
    }
}