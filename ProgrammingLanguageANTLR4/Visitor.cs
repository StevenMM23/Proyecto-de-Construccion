using Antlr4.Runtime.Misc;
using System.Text;

namespace ProgrammingLanguageANTLR4;

internal class Visitor : SSJBaseVisitor<string>
{
    public override string VisitProgram([NotNull] SSJParser.ProgramContext context)
    {
        var stringBuilder = new StringBuilder();

        foreach (var mostrar in context.mostrar())
            stringBuilder.AppendLine(Visit(mostrar));

        var translation = stringBuilder.ToString();
        return translation;
    }

    public override string VisitShowCommand([NotNull] SSJParser.ShowCommandContext context)
    {
        var variable = context.VARIABLE().GetText();
        var show = $"Console.WriteLine({variable});";
        return show;
    }

    public override string VisitConditionalCommand([NotNull] SSJParser.ConditionalCommandContext context)
    {
        var stringBuilder = new StringBuilder();
        var @if = Visit(context.ifCommand());
        var block = Visit(context.block());

        stringBuilder.AppendLine(@if);
        stringBuilder.AppendLine(block);

        if (context.elseBlock() != null)
        {
            var @else = Visit(context.elseBlock());
            stringBuilder.AppendLine(@else);
        }

        var translation = stringBuilder.ToString();
        return translation;
    }

    public override string VisitIfCommand([NotNull] SSJParser.IfCommandContext context)
    {
        var stringBuilder = new StringBuilder();
        stringBuilder.Append("if (");

        foreach (var condicional in context.ifConditional())
            stringBuilder.Append(Visit(condicional));

        stringBuilder.Append(")");
        var translation = stringBuilder.ToString();

        return translation;
    }

    public override string VisitRelationalIf([NotNull] SSJParser.RelationalIfContext context)
    {
        var variable1 = context.VARIABLE()[0].GetText();
        var variable2 = context.VARIABLE()[1].GetText();
        var operador = context.OPERADOR_RELACIONAL().GetText();

        var stringBuilder = new StringBuilder();
        stringBuilder.Append($"{variable1} {operador} {variable2}");

        var translation = stringBuilder.ToString();
        return translation;
    }

    public override string VisitAritmeticoIf([NotNull] SSJParser.AritmeticoIfContext context)
    {
        var variable1 = context.VARIABLE()[0].GetText();
        var variable2 = context.VARIABLE()[1].GetText();
        var operador = context.OPERADOR_RELACIONAL().GetText();

        var aritmeticos = new List<string>();

        foreach (var aritmetico in context.arithmeticOperations())
            aritmeticos.Add(Visit(aritmetico));

        var stringBuilder = new StringBuilder();
        stringBuilder.Append($"{variable1} {aritmeticos.First()} {operador} {variable2}");

        if (aritmeticos.Count() > 1)
            stringBuilder.Append($" {aritmeticos.Last()}");

        var translation = stringBuilder.ToString();
        return translation;
    }

    public override string VisitArithmeticOperations([NotNull] SSJParser.ArithmeticOperationsContext context)
    {
        var operador = context.OPERADOR_ARITMETICO().GetText();
        var variable = context.VARIABLE().GetText();
        var translation = $"{operador} {variable}";
        return translation;
    }

    public override string VisitBlock([NotNull] SSJParser.BlockContext context)
    {
        var stringBuilder = new StringBuilder();
        stringBuilder.AppendLine("{");

        foreach (var mostrar in context.mostrar())
            stringBuilder.AppendLine($"    {Visit(mostrar)}");

        stringBuilder.Append("}");
        var translation = stringBuilder.ToString();
        return translation;
    }

    public override string VisitElseBlock([NotNull] SSJParser.ElseBlockContext context)
    {
        var stringBuilder = new StringBuilder();
        stringBuilder.AppendLine("else");

        var block = Visit(context.block());
        stringBuilder.Append(block);

        var translation = stringBuilder.ToString();
        return translation;
    }

    public override string VisitDeclaration([NotNull] SSJParser.DeclarationContext context)
    {
        var type = Visit(context.type());
        var variable1 = context.VARIABLE()[0].GetText();

        var stringBuilder = new StringBuilder();
        stringBuilder.Append($"{type} {variable1} = ");

        if (context.VARIABLE().Count() > 1)
        {
            var variable2 = context.VARIABLE()[1].GetText();
            stringBuilder.Append($"{variable2}");
        }

        if (context.arithmeticOperations().Count() > 0)
        {
            var aritmeticos = new List<string>();

            foreach (var aritmetico in context.arithmeticOperations())
                aritmeticos.Add(Visit(aritmetico));

            stringBuilder.Append($" {aritmeticos.First()}");

            if (aritmeticos.Count() > 1)
                stringBuilder.Append($" {string.Join(" ", aritmeticos.Skip(1))};");
        }

        var translation = stringBuilder.ToString();
        return translation;
    }

    public override string VisitPostDeclaration([NotNull] SSJParser.PostDeclarationContext context)
    {
        var variable1 = context.VARIABLE()[0].GetText();

        var stringBuilder = new StringBuilder();
        stringBuilder.Append($"{variable1} = ");

        if (context.VARIABLE().Count() > 1)
        {
            var variable2 = context.VARIABLE()[1].GetText();
            stringBuilder.Append($"{variable2}");
        }

        if (context.arithmeticOperations().Count() > 0)
        {
            var aritmeticos = new List<string>();

            foreach (var aritmetico in context.arithmeticOperations())
                aritmeticos.Add(Visit(aritmetico));

            stringBuilder.Append($" {aritmeticos.First()}");

            if (aritmeticos.Count() > 1)
                stringBuilder.Append($" {string.Join(" ", aritmeticos.Skip(1))};");
        }

        var translation = stringBuilder.ToString();
        return translation;
    }

    public override string VisitType([NotNull] SSJParser.TypeContext context)
    {
        var type = context.GetText();
        return type;
    }

    public override string VisitFor([NotNull] SSJParser.ForContext context)
    {
        var declaration = Visit(context.declaration()) ?? Visit(context.postDeclaration());
        var conditionalLoop = Visit(context.conditionalLoop());
        var operationLoop = Visit(context.operationLoop());

        var stringBuilder = new StringBuilder();
        stringBuilder.Append($"for ({declaration}; {conditionalLoop}; {operationLoop})");

        var translation = stringBuilder.ToString();
        return translation;
    }

    public override string VisitWhile([NotNull] SSJParser.WhileContext context)
    {
        return base.VisitWhile(context);
    }

    public override string VisitOperationLoop([NotNull] SSJParser.OperationLoopContext context)
    {
        var variable1 = context.VARIABLE()[0].GetText();
        var stringBuilder = new StringBuilder();

        stringBuilder.Append($"{variable1}");

        if (context.OPERADOR_ARITMETICO() != null)
        {
            foreach (var operador in context.OPERADOR_ARITMETICO())
            {
                stringBuilder.Append($"{operador}");
                var igual = context.IGUAL().GetText();
                if (igual != null)
                    stringBuilder.Append($"{igual}");
            }
        }

        if (context.VARIABLE().Count() > 1)
        {
            var variable2 = context.VARIABLE()[1].GetText();
            stringBuilder.Append($" {variable2}");
        }

        var translation = stringBuilder.ToString();
        return translation;
    }

    public override string VisitRelationalLoop([NotNull] SSJParser.RelationalLoopContext context)
    {
        var variable1 = context.VARIABLE()[0].GetText();
        var stringBuilder = new StringBuilder();

        stringBuilder.Append($"{variable1}");

        if (context.OPERADOR_RELACIONAL() != null)
        {
            var operador = context.OPERADOR_RELACIONAL().GetText();
            stringBuilder.Append($" {operador}");
            var variable2 = context.VARIABLE()[1].GetText();
            stringBuilder.Append($" {variable2}");
        }

        var translation = stringBuilder.ToString();
        return translation;
    }

    public override string VisitAritmeticoLoop([NotNull] SSJParser.AritmeticoLoopContext context)
    {
        var variable1 = context.VARIABLE()[0].GetText();
        var stringBuilder = new StringBuilder();

        stringBuilder.Append($"{variable1}");

        if (context.OPERADOR_RELACIONAL() != null)
        {
            var operador = context.OPERADOR_RELACIONAL().GetText();
            stringBuilder.Append($" {operador}");
            var variable2 = context.VARIABLE()[1].GetText();
            stringBuilder.Append($" {variable2}");
        }

        if (context.arithmeticOperations().Count() > 0)
        {
            var aritmeticos = new List<string>();

            foreach (var aritmetico in context.arithmeticOperations())
                aritmeticos.Add(Visit(aritmetico));

            stringBuilder.Append($" {aritmeticos.First()}");

            if (aritmeticos.Count() > 1)
                stringBuilder.Append($" {string.Join(" ", aritmeticos.Skip(1))}");
        }

        var translation = stringBuilder.ToString();
        return translation;
    }
}
