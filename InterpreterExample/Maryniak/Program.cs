using InterpreterExample.Maryniak.Models;

namespace InterpreterExample.Maryniak;

internal class Program
{
    static void Main()
    {
        // (true AND false) OR (NOT false)
        var trueExp = new BooleanExpression(true);
        var falseExp = new BooleanExpression(false);

        var andExp = new AndExpression(trueExp, falseExp);
        var notExp = new NotExpression(falseExp);
        var orExp = new OrExpression(andExp, notExp);

        bool result = orExp.Interpret();

        Console.WriteLine("The expression is: \"(true AND false) OR (NOT false)\"");
        Console.WriteLine($"The result is: {result}");
    }
}
