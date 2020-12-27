//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.8
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from TextTemplateParser.g4 by ANTLR 4.8

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
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="ITextTemplateParserVisitor{Result}"/>,
/// which can be extended to create a visitor which only needs to handle a subset
/// of the available methods.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
[System.CLSCompliant(false)]
public partial class TextTemplateParserBaseVisitor<Result> : AbstractParseTreeVisitor<Result>, ITextTemplateParserVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="TextTemplateParser.compilationUnit"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCompilationUnit([NotNull] TextTemplateParser.CompilationUnitContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="TextTemplateParser.subtemplateSection"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitSubtemplateSection([NotNull] TextTemplateParser.SubtemplateSectionContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="TextTemplateParser.subtemplateSpecs"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitSubtemplateSpecs([NotNull] TextTemplateParser.SubtemplateSpecsContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="TextTemplateParser.subtemplateSpec"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitSubtemplateSpec([NotNull] TextTemplateParser.SubtemplateSpecContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="TextTemplateParser.templateContents"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTemplateContents([NotNull] TextTemplateParser.TemplateContentsContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="TextTemplateParser.bullet"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitBullet([NotNull] TextTemplateParser.BulletContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="TextTemplateParser.beginningBullet"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitBeginningBullet([NotNull] TextTemplateParser.BeginningBulletContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="TextTemplateParser.text"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitText([NotNull] TextTemplateParser.TextContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="TextTemplateParser.continuation"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitContinuation([NotNull] TextTemplateParser.ContinuationContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="TextTemplateParser.templateToken"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTemplateToken([NotNull] TextTemplateParser.TemplateTokenContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>braceArrow</c>
	/// labeled alternative in <see cref="TextTemplateParser.bracedOptions"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitBraceArrow([NotNull] TextTemplateParser.BraceArrowContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>braceThinArrow</c>
	/// labeled alternative in <see cref="TextTemplateParser.bracedOptions"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitBraceThinArrow([NotNull] TextTemplateParser.BraceThinArrowContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>braced</c>
	/// labeled alternative in <see cref="TextTemplateParser.bracedOptions"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitBraced([NotNull] TextTemplateParser.BracedContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>bracedPredicate</c>
	/// labeled alternative in <see cref="TextTemplateParser.bracedOptions"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitBracedPredicate([NotNull] TextTemplateParser.BracedPredicateContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="TextTemplateParser.methodInvoked"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitMethodInvoked([NotNull] TextTemplateParser.MethodInvokedContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>condition</c>
	/// labeled alternative in <see cref="TextTemplateParser.predicateExpression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCondition([NotNull] TextTemplateParser.ConditionContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>relationalOperation</c>
	/// labeled alternative in <see cref="TextTemplateParser.predicateExpression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitRelationalOperation([NotNull] TextTemplateParser.RelationalOperationContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>logicalOperator</c>
	/// labeled alternative in <see cref="TextTemplateParser.predicateExpression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitLogicalOperator([NotNull] TextTemplateParser.LogicalOperatorContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>nestedPredicate</c>
	/// labeled alternative in <see cref="TextTemplateParser.predicateExpression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitNestedPredicate([NotNull] TextTemplateParser.NestedPredicateContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>notPredicate</c>
	/// labeled alternative in <see cref="TextTemplateParser.predicateExpression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitNotPredicate([NotNull] TextTemplateParser.NotPredicateContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="TextTemplateParser.relationalOperand"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitRelationalOperand([NotNull] TextTemplateParser.RelationalOperandContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="TextTemplateParser.digits"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitDigits([NotNull] TextTemplateParser.DigitsContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="TextTemplateParser.quoteOperand"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitQuoteOperand([NotNull] TextTemplateParser.QuoteOperandContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="TextTemplateParser.apostropheOperand"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitApostropheOperand([NotNull] TextTemplateParser.ApostropheOperandContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="TextTemplateParser.identifierOperand"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitIdentifierOperand([NotNull] TextTemplateParser.IdentifierOperandContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="TextTemplateParser.identifierCondition"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitIdentifierCondition([NotNull] TextTemplateParser.IdentifierConditionContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="TextTemplateParser.templateContextCommaToken"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTemplateContextCommaToken([NotNull] TextTemplateParser.TemplateContextCommaTokenContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="TextTemplateParser.templateContextToken"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTemplateContextToken([NotNull] TextTemplateParser.TemplateContextTokenContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="TextTemplateParser.contextToken"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitContextToken([NotNull] TextTemplateParser.ContextTokenContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="TextTemplateParser.templateSpec"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTemplateSpec([NotNull] TextTemplateParser.TemplateSpecContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="TextTemplateParser.bracketedTemplateSpec"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitBracketedTemplateSpec([NotNull] TextTemplateParser.BracketedTemplateSpecContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="TextTemplateParser.invokedTemplateSpec"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitInvokedTemplateSpec([NotNull] TextTemplateParser.InvokedTemplateSpecContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="TextTemplateParser.bracedArrow"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitBracedArrow([NotNull] TextTemplateParser.BracedArrowContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="TextTemplateParser.bracedThinArrow"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitBracedThinArrow([NotNull] TextTemplateParser.BracedThinArrowContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="TextTemplateParser.bracedArrowTemplateSpec"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitBracedArrowTemplateSpec([NotNull] TextTemplateParser.BracedArrowTemplateSpecContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>quoteLiteral</c>
	/// labeled alternative in <see cref="TextTemplateParser.methodable"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitQuoteLiteral([NotNull] TextTemplateParser.QuoteLiteralContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>apostropheLiteral</c>
	/// labeled alternative in <see cref="TextTemplateParser.methodable"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitApostropheLiteral([NotNull] TextTemplateParser.ApostropheLiteralContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>methodableTemplateSpec</c>
	/// labeled alternative in <see cref="TextTemplateParser.methodable"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitMethodableTemplateSpec([NotNull] TextTemplateParser.MethodableTemplateSpecContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>identifier</c>
	/// labeled alternative in <see cref="TextTemplateParser.methodable"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitIdentifier([NotNull] TextTemplateParser.IdentifierContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="TextTemplateParser.methodInvocation"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitMethodInvocation([NotNull] TextTemplateParser.MethodInvocationContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="TextTemplateParser.method"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitMethod([NotNull] TextTemplateParser.MethodContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="TextTemplateParser.arguments"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitArguments([NotNull] TextTemplateParser.ArgumentsContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="TextTemplateParser.optionallyInvoked"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitOptionallyInvoked([NotNull] TextTemplateParser.OptionallyInvokedContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>regex</c>
	/// labeled alternative in <see cref="TextTemplateParser.argument"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitRegex([NotNull] TextTemplateParser.RegexContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>optionallyInvokedArgument</c>
	/// labeled alternative in <see cref="TextTemplateParser.argument"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitOptionallyInvokedArgument([NotNull] TextTemplateParser.OptionallyInvokedArgumentContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>predicateArgument</c>
	/// labeled alternative in <see cref="TextTemplateParser.argument"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPredicateArgument([NotNull] TextTemplateParser.PredicateArgumentContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>digitsArgument</c>
	/// labeled alternative in <see cref="TextTemplateParser.argument"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitDigitsArgument([NotNull] TextTemplateParser.DigitsArgumentContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="TextTemplateParser.namedSubtemplate"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitNamedSubtemplate([NotNull] TextTemplateParser.NamedSubtemplateContext context) { return VisitChildren(context); }
}
