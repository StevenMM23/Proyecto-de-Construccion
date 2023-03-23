using Antlr4.Runtime.Misc;
using System;
using System.Text;

namespace ProgrammingLanguageANTLR4
{
    class Condition
    {
        public string Variable { get; set; }
        public string ComparisonType { get; set; }
        public string Value { get; set; }
    }

    internal class myVisitor : SSJBaseVisitor<string>
    {
        private readonly StringBuilder _sb = new StringBuilder();

        public override string VisitProgram([NotNull] SSJParser.ProgramContext context)
        {
            VisitChildren(context);
            return _sb.ToString();
        }

        public override string VisitBlock([NotNull] SSJParser.BlockContext context)
        {
            return "no hacer nada";
        }

        public override string VisitConditionalCommand([NotNull] SSJParser.ConditionalCommandContext context)
        {
            Console.WriteLine($"VisitConditionalCommand: {context.GetText()}");
            string cmd = Visit(context.ifCommand());
            string block = Visit(context.block());
            return $"{cmd} entonces {block}";
        }

        public override string VisitIfCommand([NotNull] SSJParser.IfCommandContext context)
        {
            Console.WriteLine($"VisitIfCommand: {context.GetText()}");
            string conditional = Visit(context.ifConditional()[0]);
            return $"si {conditional}";
        }

        public override string VisitIfConditional([NotNull] SSJParser.IfConditionalContext context)
        {
            string var_izq = context.VARIABLE()[0].GetText();
            string var_der = context.VARIABLE()[1].GetText();
            string comparacion = null, diferencia, mayor, menor, menorQue, mayorQue;
            switch (context.OPERADOR_RELACIONAL().GetText())
            {
                case "==":
                    comparacion = "es igual a";
                    break;
                case "!=":
                    diferencia = "es diferente a";
                    break;

                default:
                    throw new NotImplementedException(
                        $"Operador relacional {context.OPERADOR_RELACIONAL().GetText()} no implementado");

            }

            return $"{var_izq} {comparacion} {var_der}";
        }

        public override string VisitMostrar([NotNull] SSJParser.MostrarContext context)
        {
            var content = context.showCommand().VARIABLE().GetText();

            _sb.Append("Console.WriteLine(");
            _sb.Append(content);
            _sb.AppendLine(");");

            return base.VisitMostrar(context);
        }

        public override string VisitArithmeticOperations([NotNull] SSJParser.ArithmeticOperationsContext context)
        {
            return base.VisitArithmeticOperations(context);
        }

        public override string VisitConditionalLoop([NotNull] SSJParser.ConditionalLoopContext context)
        {
            return base.VisitConditionalLoop(context);
        }

        public override string VisitDeclaration([NotNull] SSJParser.DeclarationContext context)
        {
            return base.VisitDeclaration(context);
        }

        public override string VisitDeclarationLoop([NotNull] SSJParser.DeclarationLoopContext context)
        {
            return base.VisitDeclarationLoop(context);
        }

        public override string VisitElseBlock([NotNull] SSJParser.ElseBlockContext context)
        {
            return base.VisitElseBlock(context);
        }

        public override string VisitLoopCommand([NotNull] SSJParser.LoopCommandContext context)
        {
            return base.VisitLoopCommand(context);
        }

        public override string VisitOperationLoop([NotNull] SSJParser.OperationLoopContext context)
        {
            return base.VisitOperationLoop(context);
        }

        public override string VisitPostDeclaration([NotNull] SSJParser.PostDeclarationContext context)
        {
            return base.VisitPostDeclaration(context);
        }

        public override string VisitShowCommand([NotNull] SSJParser.ShowCommandContext context)
        {
            return base.VisitShowCommand(context);
        }

        public override string VisitType([NotNull] SSJParser.TypeContext context)
        {
            return base.VisitType(context);
        }
    }
}