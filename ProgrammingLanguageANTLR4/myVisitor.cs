namespace ProgrammingLanguageANTLR4
{
    public class myVisitor : SSJBaseVisitor<object>
    {
        public override object VisitProgram(SSJParser.ProgramContext context)
        {
            return base.VisitProgram(context);
        }

        public override object VisitMostrar(SSJParser.MostrarContext context)
        {
            return base.VisitMostrar(context);
        }

        public override object VisitDeclaration(SSJParser.DeclarationContext context)
        {
            return base.VisitDeclaration(context);
        }

        public override object VisitPostDeclaration(SSJParser.PostDeclarationContext context)
        {
            return base.VisitPostDeclaration(context);
        }

        public override object VisitArithmeticOperations(SSJParser.ArithmeticOperationsContext context)
        {
            return base.VisitArithmeticOperations(context);
        }

        public override object VisitShowCommand(SSJParser.ShowCommandContext context)
        {
            return base.VisitShowCommand(context);
        }

        public override object VisitConditionalCommand(SSJParser.ConditionalCommandContext context)
        {
            return base.VisitConditionalCommand(context);
        }

        public override object VisitIfCommand(SSJParser.IfCommandContext context)
        {
            return base.VisitIfCommand(context);
        }

        public override object VisitIfConditional(SSJParser.IfConditionalContext context)
        {
            return base.VisitIfConditional(context);
        }

        public override object VisitLoopCommand(SSJParser.LoopCommandContext context)
        {
            return base.VisitLoopCommand(context);
        }

        public override object VisitDeclarationLoop(SSJParser.DeclarationLoopContext context)
        {
            return base.VisitDeclarationLoop(context);
        }

        public override object VisitConditionalLoop(SSJParser.ConditionalLoopContext context)
        {
            return base.VisitConditionalLoop(context);
        }

        public override object VisitOperationLoop(SSJParser.OperationLoopContext context)
        {
            return base.VisitOperationLoop(context);
        }

        public override object VisitElseBlock(SSJParser.ElseBlockContext context)
        {
            return base.VisitElseBlock(context);
        }

        public override object VisitBlock(SSJParser.BlockContext context)
        {
            return base.VisitBlock(context);
        }

        public override object VisitType(SSJParser.TypeContext context)
        {
            return base.VisitType(context);
        }
    }
}