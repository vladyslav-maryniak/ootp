namespace MementoExample.Maryniak.Models;

public class Canvas
{
    private List<string> shapes = [];

    public void AddShape(string shape)
    {
        shapes.Add(shape);
        Console.WriteLine($"Shape added: {shape}");
    }

    public void ShowShapes()
    {
        Console.WriteLine("Current shapes on the canvas:");
        foreach (var shape in shapes)
            Console.WriteLine($"- {shape}");
    }

    public Memento CreateMemento()
        => new(shapes);

    public void RestoreMemento(Memento memento)
        => shapes = new List<string>(memento.Shapes);
}
