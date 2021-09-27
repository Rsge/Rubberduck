﻿using System;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using NLog;
using Rubberduck.Parsing.Grammar;
using Rubberduck.Parsing.Symbols;
using Rubberduck.Parsing.VBA.DeclarationCaching;

namespace Rubberduck.Parsing.Binding
{
    public sealed class TypeBindingContext : IBindingContext
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        private readonly DeclarationFinder _declarationFinder;

        public TypeBindingContext(DeclarationFinder declarationFinder)
        {
            _declarationFinder = declarationFinder;
        }

        public IBoundExpression Resolve(Declaration module, Declaration parent, IParseTree expression, IBoundExpression withBlockVariable, StatementResolutionContext statementContext, bool requiresLetCoercion = false, bool isLetAssignment = false)
        {
            IExpressionBinding bindingTree = BuildTree(module, parent, expression, withBlockVariable, statementContext);
            return bindingTree?.Resolve();
        }

        public IExpressionBinding BuildTree(Declaration module, Declaration parent, IParseTree expression, IBoundExpression withBlockVariable, StatementResolutionContext statementContext, bool requiresLetCoercion = false, bool isLetAssignment = false)
        {
            switch (expression)
            {
                case VBAParser.LExprContext lExprContext:
                    return Visit(module, parent, lExprContext.lExpression());
                case VBAParser.CtLExprContext ctLExprContext:
                    return Visit(module, parent, ctLExprContext.lExpression());
                case VBAParser.BuiltInTypeExprContext builtInTypeExprContext:
                    return Visit(builtInTypeExprContext.builtInType());
                case ParserRuleContext unexpectedContext:
                    return HandleUnexpectedExpressionType(unexpectedContext);
                default:
                    throw new NotSupportedException($"Unexpected expression parse tree type {expression.GetType()}");
            }
        }

        public IExpressionBinding HandleUnexpectedExpressionType(ParserRuleContext expression)
        {
            Logger.Warn($"Unexpected expression context type {expression.GetType()}");
            return new FailedExpressionBinding(expression);
        }

        private IExpressionBinding Visit(VBAParser.BuiltInTypeContext builtInType)
        {
            return new BuiltInTypeDefaultBinding(builtInType);
        }

        private IExpressionBinding Visit(Declaration module, Declaration parent, VBAParser.LExpressionContext expression)
        {
            switch (expression)
            {
                case VBAParser.SimpleNameExprContext simpleNameExprContext:
                    return Visit(module, parent, simpleNameExprContext);
                case VBAParser.MemberAccessExprContext memberAccessExprContext:
                    return Visit(module, parent, memberAccessExprContext);
                case VBAParser.IndexExprContext indexExprContext:
                    return Visit(module, parent, indexExprContext);
                default:
                    return HandleUnexpectedExpressionType(expression);
            }
        }

        private IExpressionBinding Visit(Declaration module, Declaration parent, VBAParser.IndexExprContext expression)
        {
            var lexpr = expression.lExpression();
            return Visit(module, parent, lexpr);
        }

        private IExpressionBinding Visit(Declaration module, Declaration parent, VBAParser.SimpleNameExprContext expression)
        {
            return new SimpleNameTypeBinding(_declarationFinder, Declaration.GetProjectParent(parent), module, parent, expression);
        }

        private IExpressionBinding Visit(Declaration module, Declaration parent, VBAParser.MemberAccessExprContext expression)
        {
            var lExpression = expression.lExpression();
            var lExpressionBinding = Visit(module, parent, lExpression);
            SetPreferProjectOverUdt(lExpressionBinding);
            return new MemberAccessTypeBinding(_declarationFinder, Declaration.GetProjectParent(parent), module, parent, expression, expression.unrestrictedIdentifier(), lExpressionBinding);
        }

        private void SetPreferProjectOverUdt(IExpressionBinding lExpression)
        {
            if (!(lExpression is MemberAccessTypeBinding))
            {
                return;
            }
            var simpleNameBinding = (SimpleNameTypeBinding)((MemberAccessTypeBinding)lExpression).LExpressionBinding;
            simpleNameBinding.PreferProjectOverUdt = true;
        }
    }
}
