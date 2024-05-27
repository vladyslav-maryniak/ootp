namespace MementoExample.Maryniak.Models;

public class Memento(List<string> shapes)
{
    public List<string> Shapes { get; } = new(shapes);
}
