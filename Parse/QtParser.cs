//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Qt.g4 by ANTLR 4.7.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.2")]
[System.CLSCompliant(false)]
public partial class QtParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, ID=13, WS=14;
	public const int
		RULE_unit = 0, RULE_def = 1, RULE_ctxExt = 2, RULE_expr = 3, RULE_letExpr = 4, 
		RULE_idExpr = 5, RULE_elimExpr = 6, RULE_elimCase = 7;
	public static readonly string[] ruleNames = {
		"unit", "def", "ctxExt", "expr", "letExpr", "idExpr", "elimExpr", "elimCase"
	};

	private static readonly string[] _LiteralNames = {
		null, "'def'", "':'", "':='", "'('", "')'", "'let'", "'in'", "'elim'", 
		"'as'", "'into'", "'|'", "'=>'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, "ID", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Qt.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static QtParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public QtParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public QtParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	public partial class UnitContext : ParserRuleContext {
		public DefContext[] def() {
			return GetRuleContexts<DefContext>();
		}
		public DefContext def(int i) {
			return GetRuleContext<DefContext>(i);
		}
		public UnitContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_unit; } }
		public override void EnterRule(IParseTreeListener listener) {
			IQtListener typedListener = listener as IQtListener;
			if (typedListener != null) typedListener.EnterUnit(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IQtListener typedListener = listener as IQtListener;
			if (typedListener != null) typedListener.ExitUnit(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IQtVisitor<TResult> typedVisitor = visitor as IQtVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitUnit(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public UnitContext unit() {
		UnitContext _localctx = new UnitContext(Context, State);
		EnterRule(_localctx, 0, RULE_unit);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 19;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==T__0) {
				{
				{
				State = 16; def();
				}
				}
				State = 21;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class DefContext : ParserRuleContext {
		public IToken name;
		public ExprContext retTy;
		public ExprContext body;
		public ITerminalNode ID() { return GetToken(QtParser.ID, 0); }
		public ExprContext[] expr() {
			return GetRuleContexts<ExprContext>();
		}
		public ExprContext expr(int i) {
			return GetRuleContext<ExprContext>(i);
		}
		public CtxExtContext[] ctxExt() {
			return GetRuleContexts<CtxExtContext>();
		}
		public CtxExtContext ctxExt(int i) {
			return GetRuleContext<CtxExtContext>(i);
		}
		public DefContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_def; } }
		public override void EnterRule(IParseTreeListener listener) {
			IQtListener typedListener = listener as IQtListener;
			if (typedListener != null) typedListener.EnterDef(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IQtListener typedListener = listener as IQtListener;
			if (typedListener != null) typedListener.ExitDef(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IQtVisitor<TResult> typedVisitor = visitor as IQtVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitDef(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public DefContext def() {
		DefContext _localctx = new DefContext(Context, State);
		EnterRule(_localctx, 2, RULE_def);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 22; Match(T__0);
			State = 23; _localctx.name = Match(ID);
			State = 27;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==T__3) {
				{
				{
				State = 24; ctxExt();
				}
				}
				State = 29;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 30; Match(T__1);
			State = 31; _localctx.retTy = expr(0);
			State = 32; Match(T__2);
			State = 33; _localctx.body = expr(0);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class CtxExtContext : ParserRuleContext {
		public IToken names;
		public ExprContext ty;
		public ExprContext expr() {
			return GetRuleContext<ExprContext>(0);
		}
		public ITerminalNode[] ID() { return GetTokens(QtParser.ID); }
		public ITerminalNode ID(int i) {
			return GetToken(QtParser.ID, i);
		}
		public CtxExtContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_ctxExt; } }
		public override void EnterRule(IParseTreeListener listener) {
			IQtListener typedListener = listener as IQtListener;
			if (typedListener != null) typedListener.EnterCtxExt(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IQtListener typedListener = listener as IQtListener;
			if (typedListener != null) typedListener.ExitCtxExt(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IQtVisitor<TResult> typedVisitor = visitor as IQtVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitCtxExt(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public CtxExtContext ctxExt() {
		CtxExtContext _localctx = new CtxExtContext(Context, State);
		EnterRule(_localctx, 4, RULE_ctxExt);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 35; Match(T__3);
			State = 37;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			do {
				{
				{
				State = 36; _localctx.names = Match(ID);
				}
				}
				State = 39;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			} while ( _la==ID );
			State = 41; Match(T__1);
			State = 42; _localctx.ty = expr(0);
			State = 43; Match(T__4);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ExprContext : ParserRuleContext {
		public ExprContext fun;
		public ExprContext parenthesized;
		public LetExprContext let;
		public IdExprContext id;
		public ElimExprContext elim;
		public ExprContext arg;
		public ExprContext[] expr() {
			return GetRuleContexts<ExprContext>();
		}
		public ExprContext expr(int i) {
			return GetRuleContext<ExprContext>(i);
		}
		public LetExprContext letExpr() {
			return GetRuleContext<LetExprContext>(0);
		}
		public IdExprContext idExpr() {
			return GetRuleContext<IdExprContext>(0);
		}
		public ElimExprContext elimExpr() {
			return GetRuleContext<ElimExprContext>(0);
		}
		public ExprContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_expr; } }
		public override void EnterRule(IParseTreeListener listener) {
			IQtListener typedListener = listener as IQtListener;
			if (typedListener != null) typedListener.EnterExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IQtListener typedListener = listener as IQtListener;
			if (typedListener != null) typedListener.ExitExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IQtVisitor<TResult> typedVisitor = visitor as IQtVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitExpr(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ExprContext expr() {
		return expr(0);
	}

	private ExprContext expr(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		ExprContext _localctx = new ExprContext(Context, _parentState);
		ExprContext _prevctx = _localctx;
		int _startState = 6;
		EnterRecursionRule(_localctx, 6, RULE_expr, _p);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 53;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case T__3:
				{
				State = 46; Match(T__3);
				State = 47; _localctx.parenthesized = expr(0);
				State = 48; Match(T__4);
				}
				break;
			case T__5:
				{
				State = 50; _localctx.let = letExpr();
				}
				break;
			case ID:
				{
				State = 51; _localctx.id = idExpr();
				}
				break;
			case T__7:
				{
				State = 52; _localctx.elim = elimExpr();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
			Context.Stop = TokenStream.LT(-1);
			State = 59;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,4,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					{
					_localctx = new ExprContext(_parentctx, _parentState);
					_localctx.fun = _prevctx;
					PushNewRecursionContext(_localctx, _startState, RULE_expr);
					State = 55;
					if (!(Precpred(Context, 1))) throw new FailedPredicateException(this, "Precpred(Context, 1)");
					State = 56; _localctx.arg = expr(2);
					}
					} 
				}
				State = 61;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,4,Context);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			UnrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	public partial class LetExprContext : ParserRuleContext {
		public IToken varName;
		public ExprContext ty;
		public ExprContext val;
		public ExprContext body;
		public ITerminalNode ID() { return GetToken(QtParser.ID, 0); }
		public ExprContext[] expr() {
			return GetRuleContexts<ExprContext>();
		}
		public ExprContext expr(int i) {
			return GetRuleContext<ExprContext>(i);
		}
		public LetExprContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_letExpr; } }
		public override void EnterRule(IParseTreeListener listener) {
			IQtListener typedListener = listener as IQtListener;
			if (typedListener != null) typedListener.EnterLetExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IQtListener typedListener = listener as IQtListener;
			if (typedListener != null) typedListener.ExitLetExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IQtVisitor<TResult> typedVisitor = visitor as IQtVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitLetExpr(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public LetExprContext letExpr() {
		LetExprContext _localctx = new LetExprContext(Context, State);
		EnterRule(_localctx, 8, RULE_letExpr);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 62; Match(T__5);
			State = 63; _localctx.varName = Match(ID);
			State = 64; Match(T__1);
			State = 65; _localctx.ty = expr(0);
			State = 66; Match(T__2);
			State = 67; _localctx.val = expr(0);
			State = 68; Match(T__6);
			State = 69; _localctx.body = expr(0);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class IdExprContext : ParserRuleContext {
		public ITerminalNode ID() { return GetToken(QtParser.ID, 0); }
		public IdExprContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_idExpr; } }
		public override void EnterRule(IParseTreeListener listener) {
			IQtListener typedListener = listener as IQtListener;
			if (typedListener != null) typedListener.EnterIdExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IQtListener typedListener = listener as IQtListener;
			if (typedListener != null) typedListener.ExitIdExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IQtVisitor<TResult> typedVisitor = visitor as IQtVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitIdExpr(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public IdExprContext idExpr() {
		IdExprContext _localctx = new IdExprContext(Context, State);
		EnterRule(_localctx, 10, RULE_idExpr);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 71; Match(ID);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ElimExprContext : ParserRuleContext {
		public ExprContext discriminee;
		public IToken varName;
		public ExprContext intoTy;
		public ExprContext[] expr() {
			return GetRuleContexts<ExprContext>();
		}
		public ExprContext expr(int i) {
			return GetRuleContext<ExprContext>(i);
		}
		public ITerminalNode ID() { return GetToken(QtParser.ID, 0); }
		public CtxExtContext[] ctxExt() {
			return GetRuleContexts<CtxExtContext>();
		}
		public CtxExtContext ctxExt(int i) {
			return GetRuleContext<CtxExtContext>(i);
		}
		public ElimCaseContext[] elimCase() {
			return GetRuleContexts<ElimCaseContext>();
		}
		public ElimCaseContext elimCase(int i) {
			return GetRuleContext<ElimCaseContext>(i);
		}
		public ElimExprContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_elimExpr; } }
		public override void EnterRule(IParseTreeListener listener) {
			IQtListener typedListener = listener as IQtListener;
			if (typedListener != null) typedListener.EnterElimExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IQtListener typedListener = listener as IQtListener;
			if (typedListener != null) typedListener.ExitElimExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IQtVisitor<TResult> typedVisitor = visitor as IQtVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitElimExpr(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ElimExprContext elimExpr() {
		ElimExprContext _localctx = new ElimExprContext(Context, State);
		EnterRule(_localctx, 12, RULE_elimExpr);
		int _la;
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 73; Match(T__7);
			State = 74; _localctx.discriminee = expr(0);
			State = 75; Match(T__8);
			State = 76; _localctx.varName = Match(ID);
			State = 77; Match(T__9);
			State = 81;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==T__3) {
				{
				{
				State = 78; ctxExt();
				}
				}
				State = 83;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 84; Match(T__1);
			State = 85; _localctx.intoTy = expr(0);
			State = 89;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,6,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					State = 86; elimCase();
					}
					} 
				}
				State = 91;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,6,Context);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ElimCaseContext : ParserRuleContext {
		public ExprContext caseTy;
		public ExprContext body;
		public ExprContext[] expr() {
			return GetRuleContexts<ExprContext>();
		}
		public ExprContext expr(int i) {
			return GetRuleContext<ExprContext>(i);
		}
		public CtxExtContext[] ctxExt() {
			return GetRuleContexts<CtxExtContext>();
		}
		public CtxExtContext ctxExt(int i) {
			return GetRuleContext<CtxExtContext>(i);
		}
		public ElimCaseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_elimCase; } }
		public override void EnterRule(IParseTreeListener listener) {
			IQtListener typedListener = listener as IQtListener;
			if (typedListener != null) typedListener.EnterElimCase(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IQtListener typedListener = listener as IQtListener;
			if (typedListener != null) typedListener.ExitElimCase(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IQtVisitor<TResult> typedVisitor = visitor as IQtVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitElimCase(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ElimCaseContext elimCase() {
		ElimCaseContext _localctx = new ElimCaseContext(Context, State);
		EnterRule(_localctx, 14, RULE_elimCase);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 92; Match(T__10);
			State = 96;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==T__3) {
				{
				{
				State = 93; ctxExt();
				}
				}
				State = 98;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 99; Match(T__1);
			State = 100; _localctx.caseTy = expr(0);
			State = 101; Match(T__11);
			State = 102; _localctx.body = expr(0);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public override bool Sempred(RuleContext _localctx, int ruleIndex, int predIndex) {
		switch (ruleIndex) {
		case 3: return expr_sempred((ExprContext)_localctx, predIndex);
		}
		return true;
	}
	private bool expr_sempred(ExprContext _localctx, int predIndex) {
		switch (predIndex) {
		case 0: return Precpred(Context, 1);
		}
		return true;
	}

	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x3', '\x10', 'k', '\x4', '\x2', '\t', '\x2', '\x4', '\x3', 
		'\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', '\x5', '\x4', 
		'\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', '\t', '\b', 
		'\x4', '\t', '\t', '\t', '\x3', '\x2', '\a', '\x2', '\x14', '\n', '\x2', 
		'\f', '\x2', '\xE', '\x2', '\x17', '\v', '\x2', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\a', '\x3', '\x1C', '\n', '\x3', '\f', '\x3', '\xE', '\x3', 
		'\x1F', '\v', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x4', '\x3', '\x4', '\x6', '\x4', '(', '\n', 
		'\x4', '\r', '\x4', '\xE', '\x4', ')', '\x3', '\x4', '\x3', '\x4', '\x3', 
		'\x4', '\x3', '\x4', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', 
		'\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x5', 
		'\x5', '\x38', '\n', '\x5', '\x3', '\x5', '\x3', '\x5', '\a', '\x5', '<', 
		'\n', '\x5', '\f', '\x5', '\xE', '\x5', '?', '\v', '\x5', '\x3', '\x6', 
		'\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', 
		'\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\a', '\x3', '\a', '\x3', 
		'\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', 
		'\a', '\b', 'R', '\n', '\b', '\f', '\b', '\xE', '\b', 'U', '\v', '\b', 
		'\x3', '\b', '\x3', '\b', '\x3', '\b', '\a', '\b', 'Z', '\n', '\b', '\f', 
		'\b', '\xE', '\b', ']', '\v', '\b', '\x3', '\t', '\x3', '\t', '\a', '\t', 
		'\x61', '\n', '\t', '\f', '\t', '\xE', '\t', '\x64', '\v', '\t', '\x3', 
		'\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', 
		'\x2', '\x3', '\b', '\n', '\x2', '\x4', '\x6', '\b', '\n', '\f', '\xE', 
		'\x10', '\x2', '\x2', '\x2', 'l', '\x2', '\x15', '\x3', '\x2', '\x2', 
		'\x2', '\x4', '\x18', '\x3', '\x2', '\x2', '\x2', '\x6', '%', '\x3', '\x2', 
		'\x2', '\x2', '\b', '\x37', '\x3', '\x2', '\x2', '\x2', '\n', '@', '\x3', 
		'\x2', '\x2', '\x2', '\f', 'I', '\x3', '\x2', '\x2', '\x2', '\xE', 'K', 
		'\x3', '\x2', '\x2', '\x2', '\x10', '^', '\x3', '\x2', '\x2', '\x2', '\x12', 
		'\x14', '\x5', '\x4', '\x3', '\x2', '\x13', '\x12', '\x3', '\x2', '\x2', 
		'\x2', '\x14', '\x17', '\x3', '\x2', '\x2', '\x2', '\x15', '\x13', '\x3', 
		'\x2', '\x2', '\x2', '\x15', '\x16', '\x3', '\x2', '\x2', '\x2', '\x16', 
		'\x3', '\x3', '\x2', '\x2', '\x2', '\x17', '\x15', '\x3', '\x2', '\x2', 
		'\x2', '\x18', '\x19', '\a', '\x3', '\x2', '\x2', '\x19', '\x1D', '\a', 
		'\xF', '\x2', '\x2', '\x1A', '\x1C', '\x5', '\x6', '\x4', '\x2', '\x1B', 
		'\x1A', '\x3', '\x2', '\x2', '\x2', '\x1C', '\x1F', '\x3', '\x2', '\x2', 
		'\x2', '\x1D', '\x1B', '\x3', '\x2', '\x2', '\x2', '\x1D', '\x1E', '\x3', 
		'\x2', '\x2', '\x2', '\x1E', ' ', '\x3', '\x2', '\x2', '\x2', '\x1F', 
		'\x1D', '\x3', '\x2', '\x2', '\x2', ' ', '!', '\a', '\x4', '\x2', '\x2', 
		'!', '\"', '\x5', '\b', '\x5', '\x2', '\"', '#', '\a', '\x5', '\x2', '\x2', 
		'#', '$', '\x5', '\b', '\x5', '\x2', '$', '\x5', '\x3', '\x2', '\x2', 
		'\x2', '%', '\'', '\a', '\x6', '\x2', '\x2', '&', '(', '\a', '\xF', '\x2', 
		'\x2', '\'', '&', '\x3', '\x2', '\x2', '\x2', '(', ')', '\x3', '\x2', 
		'\x2', '\x2', ')', '\'', '\x3', '\x2', '\x2', '\x2', ')', '*', '\x3', 
		'\x2', '\x2', '\x2', '*', '+', '\x3', '\x2', '\x2', '\x2', '+', ',', '\a', 
		'\x4', '\x2', '\x2', ',', '-', '\x5', '\b', '\x5', '\x2', '-', '.', '\a', 
		'\a', '\x2', '\x2', '.', '\a', '\x3', '\x2', '\x2', '\x2', '/', '\x30', 
		'\b', '\x5', '\x1', '\x2', '\x30', '\x31', '\a', '\x6', '\x2', '\x2', 
		'\x31', '\x32', '\x5', '\b', '\x5', '\x2', '\x32', '\x33', '\a', '\a', 
		'\x2', '\x2', '\x33', '\x38', '\x3', '\x2', '\x2', '\x2', '\x34', '\x38', 
		'\x5', '\n', '\x6', '\x2', '\x35', '\x38', '\x5', '\f', '\a', '\x2', '\x36', 
		'\x38', '\x5', '\xE', '\b', '\x2', '\x37', '/', '\x3', '\x2', '\x2', '\x2', 
		'\x37', '\x34', '\x3', '\x2', '\x2', '\x2', '\x37', '\x35', '\x3', '\x2', 
		'\x2', '\x2', '\x37', '\x36', '\x3', '\x2', '\x2', '\x2', '\x38', '=', 
		'\x3', '\x2', '\x2', '\x2', '\x39', ':', '\f', '\x3', '\x2', '\x2', ':', 
		'<', '\x5', '\b', '\x5', '\x4', ';', '\x39', '\x3', '\x2', '\x2', '\x2', 
		'<', '?', '\x3', '\x2', '\x2', '\x2', '=', ';', '\x3', '\x2', '\x2', '\x2', 
		'=', '>', '\x3', '\x2', '\x2', '\x2', '>', '\t', '\x3', '\x2', '\x2', 
		'\x2', '?', '=', '\x3', '\x2', '\x2', '\x2', '@', '\x41', '\a', '\b', 
		'\x2', '\x2', '\x41', '\x42', '\a', '\xF', '\x2', '\x2', '\x42', '\x43', 
		'\a', '\x4', '\x2', '\x2', '\x43', '\x44', '\x5', '\b', '\x5', '\x2', 
		'\x44', '\x45', '\a', '\x5', '\x2', '\x2', '\x45', '\x46', '\x5', '\b', 
		'\x5', '\x2', '\x46', 'G', '\a', '\t', '\x2', '\x2', 'G', 'H', '\x5', 
		'\b', '\x5', '\x2', 'H', '\v', '\x3', '\x2', '\x2', '\x2', 'I', 'J', '\a', 
		'\xF', '\x2', '\x2', 'J', '\r', '\x3', '\x2', '\x2', '\x2', 'K', 'L', 
		'\a', '\n', '\x2', '\x2', 'L', 'M', '\x5', '\b', '\x5', '\x2', 'M', 'N', 
		'\a', '\v', '\x2', '\x2', 'N', 'O', '\a', '\xF', '\x2', '\x2', 'O', 'S', 
		'\a', '\f', '\x2', '\x2', 'P', 'R', '\x5', '\x6', '\x4', '\x2', 'Q', 'P', 
		'\x3', '\x2', '\x2', '\x2', 'R', 'U', '\x3', '\x2', '\x2', '\x2', 'S', 
		'Q', '\x3', '\x2', '\x2', '\x2', 'S', 'T', '\x3', '\x2', '\x2', '\x2', 
		'T', 'V', '\x3', '\x2', '\x2', '\x2', 'U', 'S', '\x3', '\x2', '\x2', '\x2', 
		'V', 'W', '\a', '\x4', '\x2', '\x2', 'W', '[', '\x5', '\b', '\x5', '\x2', 
		'X', 'Z', '\x5', '\x10', '\t', '\x2', 'Y', 'X', '\x3', '\x2', '\x2', '\x2', 
		'Z', ']', '\x3', '\x2', '\x2', '\x2', '[', 'Y', '\x3', '\x2', '\x2', '\x2', 
		'[', '\\', '\x3', '\x2', '\x2', '\x2', '\\', '\xF', '\x3', '\x2', '\x2', 
		'\x2', ']', '[', '\x3', '\x2', '\x2', '\x2', '^', '\x62', '\a', '\r', 
		'\x2', '\x2', '_', '\x61', '\x5', '\x6', '\x4', '\x2', '`', '_', '\x3', 
		'\x2', '\x2', '\x2', '\x61', '\x64', '\x3', '\x2', '\x2', '\x2', '\x62', 
		'`', '\x3', '\x2', '\x2', '\x2', '\x62', '\x63', '\x3', '\x2', '\x2', 
		'\x2', '\x63', '\x65', '\x3', '\x2', '\x2', '\x2', '\x64', '\x62', '\x3', 
		'\x2', '\x2', '\x2', '\x65', '\x66', '\a', '\x4', '\x2', '\x2', '\x66', 
		'g', '\x5', '\b', '\x5', '\x2', 'g', 'h', '\a', '\xE', '\x2', '\x2', 'h', 
		'i', '\x5', '\b', '\x5', '\x2', 'i', '\x11', '\x3', '\x2', '\x2', '\x2', 
		'\n', '\x15', '\x1D', ')', '\x37', '=', 'S', '[', '\x62',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
