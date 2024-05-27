using StrategyAndObserverExample.Maryniak.Models;

namespace StrategyAndObserverExample.Maryniak;

internal class Program
{
    static void Main()
    {
        // Create WeatherData (subject)
        var weatherData = new WeatherData();

        // Create display strategies
        IDisplayStrategy simpleDisplay = new SimpleDisplayStrategy();
        IDisplayStrategy detailedDisplay = new DetailedDisplayStrategy();

        // Create observers with different display strategies
        var simpleWeatherDisplay = new WeatherDisplay(simpleDisplay);
        var detailedWeatherDisplay = new WeatherDisplay(detailedDisplay);

        // Register observers with the subject
        weatherData.RegisterObserver(simpleWeatherDisplay);
        weatherData.RegisterObserver(detailedWeatherDisplay);

        // Simulate new weather measurements
        weatherData.SetMeasurements(25.0f, 65.0f, 1013.0f);
        weatherData.SetMeasurements(22.0f, 70.0f, 1012.0f);

        // Change strategy at runtime
        simpleWeatherDisplay.SetDisplayStrategy(detailedDisplay);
        weatherData.SetMeasurements(20.0f, 75.0f, 1011.0f);
    }
}
