namespace InterpreterExample.Maryniak.Models;

public class BooleanExpression(bool value) : IExpression
{
    public bool Interpret() => value;
}
