//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.3
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\hosch\Documents\Visual Studio 2015\Projects\Rubberduck\Rubberduck.Parsing\Preprocessing\VBADate.g4 by ANTLR 4.3

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591

namespace Rubberduck.Parsing {
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="VBADateParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.3")]
[System.CLSCompliant(false)]
public interface IVBADateVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="VBADateParser.dateValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDateValue([NotNull] VBADateParser.DateValueContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="VBADateParser.dateSeparator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDateSeparator([NotNull] VBADateParser.DateSeparatorContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="VBADateParser.englishMonthAbbreviation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEnglishMonthAbbreviation([NotNull] VBADateParser.EnglishMonthAbbreviationContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="VBADateParser.dateOrTime"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDateOrTime([NotNull] VBADateParser.DateOrTimeContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="VBADateParser.englishMonthName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEnglishMonthName([NotNull] VBADateParser.EnglishMonthNameContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="VBADateParser.monthName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMonthName([NotNull] VBADateParser.MonthNameContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="VBADateParser.timeSeparator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTimeSeparator([NotNull] VBADateParser.TimeSeparatorContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="VBADateParser.timeValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTimeValue([NotNull] VBADateParser.TimeValueContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="VBADateParser.compilationUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCompilationUnit([NotNull] VBADateParser.CompilationUnitContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="VBADateParser.dateValuePart"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDateValuePart([NotNull] VBADateParser.DateValuePartContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="VBADateParser.timeValuePart"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTimeValuePart([NotNull] VBADateParser.TimeValuePartContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="VBADateParser.dateLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDateLiteral([NotNull] VBADateParser.DateLiteralContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="VBADateParser.dateValueNumber"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDateValueNumber([NotNull] VBADateParser.DateValueNumberContext context);
}
} // namespace Rubberduck.Parsing