namespace StrategyAndObserverExample.Maryniak.Models;

public class DetailedDisplayStrategy : IDisplayStrategy
{
    public void Display(float temperature, float humidity, float pressure)
    {
        Console.WriteLine($"Detailed Display: " +
            $"Temp={temperature}°C, " +
            $"Humidity={humidity}%, " +
            $"Pressure={pressure} hPa");
    }
}
