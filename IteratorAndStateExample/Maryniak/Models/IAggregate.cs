namespace IteratorAndStateExample.Maryniak.Models;

public interface IAggregate<T>
{
    IIterator<T> GetIterator();
}
