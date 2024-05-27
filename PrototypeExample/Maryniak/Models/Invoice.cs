namespace PrototypeExample.Maryniak.Models;

public class Invoice : FinancialDocument
{
    public decimal Amount { get; set; }
    public string Customer { get; set; }

    public Invoice(string title, DateTime date, decimal amount, string customer)
    {
        Title = title;
        Date = date;
        Amount = amount;
        Customer = customer;
    }

    public override FinancialDocument Clone() => new Invoice(Title, Date, Amount, Customer);

    public override void Print()
    {
        Console.WriteLine($"Invoice - Title: {Title}, Date: {Date}, Amount: {Amount}, Customer: {Customer}");
    }
}
