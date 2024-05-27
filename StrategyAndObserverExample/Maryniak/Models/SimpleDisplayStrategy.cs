namespace StrategyAndObserverExample.Maryniak.Models;

public class SimpleDisplayStrategy : IDisplayStrategy
{
    public void Display(float temperature, float humidity, float pressure)
    {
        Console.WriteLine($"Simple Display: " +
            $"Temp={temperature}°C, " +
            $"Humidity={humidity}%");
    }
}
