public class MyVisitor<Result> : SSJBaseVisitor<Result>
{
    public override Result VisitMostrar(SSJParser.MostrarContext context)
    {
        Console.WriteLine("Visitando la regla mostrar: " + context.GetText());
        return base.VisitMostrar(context);
    }

    public override Result VisitProgram(SSJParser.ProgramContext context)
    {
        return VisitChildren(context.GetText());
    }


    public override Result VisitDeclaration(SSJParser.DeclarationContext context)
    {
        return VisitChildren(context);
    }

    public override Result VisitPostDeclaration(SSJParser.PostDeclarationContext context)
    {
        return VisitChildren(context);
    }

    public override Result VisitArithmeticOperations(SSJParser.ArithmeticOperationsContext context)
    {
        return VisitChildren(context);
    }

    public override Result VisitShowCommand(SSJParser.ShowCommandContext context)
    {
        return VisitChildren(context);
    }

    public override Result VisitConditionalCommand(SSJParser.ConditionalCommandContext context)
    {
        return VisitChildren(context);
    }

    public override Result VisitComparison(SSJParser.ComparisonContext context)
    {
        return VisitChildren(context);
    }

    public override Result VisitLogicOperations(SSJParser.LogicOperationsContext context)
    {
        return VisitChildren(context);
    }

    public override Result VisitValue(SSJParser.ValueContext context)
    {
        return VisitChildren(context);
    }

    public override Result VisitVarID(SSJParser.VarIDContext context)
    {
        return VisitChildren(context);
    }

    public override Result VisitBoolLiteral(SSJParser.BoolLiteralContext context)
    {
        return VisitChildren(context);
    }

    public override Result VisitStringLiteral(SSJParser.StringLiteralContext context)
    {
        return VisitChildren(context);
    }

    public override Result VisitNumberLiteral(SSJParser.NumberLiteralContext context)
    {
        return VisitChildren(context);
    }

    public override Result VisitFunctionCall(SSJParser.FunctionCallContext context)
    {
        return VisitChildren(context);
    }

    public override Result VisitFunctionParameters(SSJParser.FunctionParametersContext context)
    {
        return VisitChildren(context);
    }

}
