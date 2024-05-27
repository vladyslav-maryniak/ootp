using MementoExample.Maryniak.Models;

namespace MementoExample.Maryniak;

internal class Program
{
    static void Main()
    {
        var canvas = new Canvas();
        var caretaker = new Caretaker(canvas);

        canvas.AddShape("Circle");
        caretaker.Save();

        canvas.AddShape("Square");
        caretaker.Save();

        canvas.AddShape("Triangle");
        caretaker.Save();

        Console.WriteLine();
        canvas.ShowShapes();

        caretaker.Undo();
        Console.WriteLine("\n[After Undo] ");
        canvas.ShowShapes();

        caretaker.Undo();
        Console.WriteLine("\n[After Undo] ");
        canvas.ShowShapes();

        caretaker.Redo();
        Console.WriteLine("\n[After Redo]");
        canvas.ShowShapes();

        caretaker.Undo();
        Console.WriteLine("\n[After Undo] ");
        canvas.ShowShapes();

        caretaker.Redo();
        Console.WriteLine("\n[After Redo]");
        canvas.ShowShapes();

        caretaker.Redo();
        Console.WriteLine("\n[After Redo]");
        canvas.ShowShapes();
    }
}
