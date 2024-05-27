namespace InterpreterExample.Maryniak.Models;

public class AndExpression(IExpression leftExpression, IExpression rightExpression) : IExpression
{
    public bool Interpret()
        => leftExpression.Interpret() && rightExpression.Interpret();
}
