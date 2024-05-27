namespace PrototypeExample.Maryniak.Models;

public class Report : FinancialDocument
{
    public string Content { get; set; }
    public string Author { get; set; }

    public Report(string title, DateTime date, string content, string author)
    {
        Title = title;
        Date = date;
        Content = content;
        Author = author;
    }

    public override FinancialDocument Clone() => new Report(Title, Date, Content, Author);

    public override void Print()
    {
        Console.WriteLine($"Report - Title: {Title}, Date: {Date}, Content: {Content}, Author: {Author}");
    }
}
