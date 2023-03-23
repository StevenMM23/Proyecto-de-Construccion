//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from /Users/omar.nunez/Downloads/Proyecto-de-Construccion/ProgrammingLanguageANTLR4/Grammar/SSJ.g4 by ANTLR 4.9.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="SSJParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.2")]
[System.CLSCompliant(false)]
public interface ISSJVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="SSJParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProgram([NotNull] SSJParser.ProgramContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SSJParser.mostrar"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMostrar([NotNull] SSJParser.MostrarContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SSJParser.declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDeclaration([NotNull] SSJParser.DeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SSJParser.postDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPostDeclaration([NotNull] SSJParser.PostDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SSJParser.arithmeticOperations"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArithmeticOperations([NotNull] SSJParser.ArithmeticOperationsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SSJParser.showCommand"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitShowCommand([NotNull] SSJParser.ShowCommandContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SSJParser.conditionalCommand"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConditionalCommand([NotNull] SSJParser.ConditionalCommandContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SSJParser.ifCommand"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIfCommand([NotNull] SSJParser.IfCommandContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>relationalIf</c>
	/// labeled alternative in <see cref="SSJParser.ifConditional"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRelationalIf([NotNull] SSJParser.RelationalIfContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>aritmeticoIf</c>
	/// labeled alternative in <see cref="SSJParser.ifConditional"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAritmeticoIf([NotNull] SSJParser.AritmeticoIfContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>for</c>
	/// labeled alternative in <see cref="SSJParser.loopCommand"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFor([NotNull] SSJParser.ForContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>while</c>
	/// labeled alternative in <see cref="SSJParser.loopCommand"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWhile([NotNull] SSJParser.WhileContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>relationalLoop</c>
	/// labeled alternative in <see cref="SSJParser.conditionalLoop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRelationalLoop([NotNull] SSJParser.RelationalLoopContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>aritmeticoLoop</c>
	/// labeled alternative in <see cref="SSJParser.conditionalLoop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAritmeticoLoop([NotNull] SSJParser.AritmeticoLoopContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SSJParser.operationLoop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOperationLoop([NotNull] SSJParser.OperationLoopContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SSJParser.elseBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitElseBlock([NotNull] SSJParser.ElseBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SSJParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBlock([NotNull] SSJParser.BlockContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SSJParser.type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitType([NotNull] SSJParser.TypeContext context);
}
