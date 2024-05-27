namespace MementoExample.Maryniak.Models;

public class Caretaker(Canvas canvas)
{
    private readonly Stack<Memento> undoStack = new();
    private readonly Stack<Memento> redoStack = new();

    public void Save()
    {
        undoStack.Push(canvas.CreateMemento());
        redoStack.Clear();
    }

    public void Undo()
    {
        if (undoStack.Count <= 0)
            return;

        redoStack.Push(undoStack.Pop());
        canvas.RestoreMemento(undoStack.Peek());
    }

    public void Redo()
    {
        if (redoStack.Count <= 0)
            return;

        undoStack.Push(redoStack.Peek());
        canvas.RestoreMemento(redoStack.Pop());
    }
}
