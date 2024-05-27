namespace IteratorAndStateExample.Maryniak.Models;

public interface IIterator<T>
{
    T? Current { get; }
    bool HasNext { get; }
    T? Next();

    void Restart();
}
