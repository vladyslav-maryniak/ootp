namespace StrategyAndObserverExample.Maryniak.Models;

public interface IObserver
{
    void Update(float temperature, float humidity, float pressure);
}
