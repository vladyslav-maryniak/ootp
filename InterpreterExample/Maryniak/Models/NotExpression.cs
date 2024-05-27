namespace InterpreterExample.Maryniak.Models;

public class NotExpression(IExpression expression) : IExpression
{
    public bool Interpret() => !expression.Interpret();
}
