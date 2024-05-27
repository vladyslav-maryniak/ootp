namespace InterpreterExample.Maryniak.Models;

public class OrExpression(IExpression leftExpression, IExpression rightExpression) : IExpression
{
    public bool Interpret()
        => leftExpression.Interpret() || rightExpression.Interpret();
}
