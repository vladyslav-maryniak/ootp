namespace StrategyAndObserverExample.Maryniak.Models;

public interface IDisplayStrategy
{
    void Display(float temperature, float humidity, float pressure);
}
