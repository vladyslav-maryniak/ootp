namespace StrategyAndObserverExample.Maryniak.Models;

public class WeatherDisplay(IDisplayStrategy displayStrategy) : IObserver
{
    private IDisplayStrategy displayStrategy = displayStrategy;
    
    private float temperature;
    private float humidity;
    private float pressure;

    public void Update(float temperature, float humidity, float pressure)
    {
        this.temperature = temperature;
        this.humidity = humidity;
        this.pressure = pressure;
        Display();
    }

    public void SetDisplayStrategy(IDisplayStrategy displayStrategy)
        => this.displayStrategy = displayStrategy;

    private void Display()
        => displayStrategy.Display(temperature, humidity, pressure);
}
