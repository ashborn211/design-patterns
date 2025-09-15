using ObserverPattern.Displays;

namespace ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();
            CurrentConditionDisplay currentDisplay = new CurrentConditionDisplay(weatherData);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
            ForecastDisplay ForecastDisplay = new ForecastDisplay(weatherData);
            // Create instances of displays 

            Console.WriteLine("\nFirst set of measurements:");
            weatherData.SetMeasurements(28, 65, 30.4f);


            Console.WriteLine("\nSecond set of measurements:");
            weatherData.SetMeasurements(39, 40, 30.2f);


            Console.WriteLine("\nThird set of measurements:");
            weatherData.SetMeasurements(30, 90, 29.2f); 

            Console.WriteLine("unsubscriping from forecast display");
            weatherData.RemoveObserver(ForecastDisplay);
        }
    }
}