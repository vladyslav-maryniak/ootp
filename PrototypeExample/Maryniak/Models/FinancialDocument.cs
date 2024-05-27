namespace PrototypeExample.Maryniak.Models;

public abstract class FinancialDocument
{
    public string Title { get; set; } = string.Empty;
    public DateTime Date { get; set; }

    public abstract FinancialDocument Clone();
    public abstract void Print();
}
