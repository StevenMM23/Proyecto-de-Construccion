//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from c:\Users\estev\Desktop\Proyecto de Construccion\SSJ.g4 by ANTLR 4.9.2

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
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.2")]
[System.CLSCompliant(false)]
public partial class SSJLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, PARENTESIS_DERECHO=6, PARENTESIS_IZQUIERDO=7, 
		COMILLAS=8, LLAVE_IZ=9, LLAVE_DR=10, IGUAL=11, OPERADOR_RELACIONAL=12, 
		NUMERO=13, STRING=14, TEXTO=15, WS=16;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "PARENTESIS_DERECHO", "PARENTESIS_IZQUIERDO", 
		"COMILLAS", "LLAVE_IZ", "LLAVE_DR", "IGUAL", "OPERADOR_RELACIONAL", "NUMERO", 
		"STRING", "TEXTO", "WS"
	};


	public SSJLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public SSJLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'show'", "'if'", "'else'", "'int'", "'string'", "')'", "'('", "'\"'", 
		"'{'", "'}'", "'='"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, "PARENTESIS_DERECHO", "PARENTESIS_IZQUIERDO", 
		"COMILLAS", "LLAVE_IZ", "LLAVE_DR", "IGUAL", "OPERADOR_RELACIONAL", "NUMERO", 
		"STRING", "TEXTO", "WS"
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

	public override string GrammarFileName { get { return "SSJ.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static SSJLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '\x12', 'm', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', 
		'\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', 
		'\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', 
		'\t', '\v', '\x4', '\f', '\t', '\f', '\x4', '\r', '\t', '\r', '\x4', '\xE', 
		'\t', '\xE', '\x4', '\xF', '\t', '\xF', '\x4', '\x10', '\t', '\x10', '\x4', 
		'\x11', '\t', '\x11', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', 
		'\x2', '\x3', '\x2', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', 
		'\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x6', '\x3', 
		'\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', 
		'\x6', '\x3', '\a', '\x3', '\a', '\x3', '\b', '\x3', '\b', '\x3', '\t', 
		'\x3', '\t', '\x3', '\n', '\x3', '\n', '\x3', '\v', '\x3', '\v', '\x3', 
		'\f', '\x3', '\f', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', 
		'\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', 
		'\r', '\x3', '\r', '\x5', '\r', 'S', '\n', '\r', '\x3', '\xE', '\x6', 
		'\xE', 'V', '\n', '\xE', '\r', '\xE', '\xE', '\xE', 'W', '\x3', '\xF', 
		'\x3', '\xF', '\a', '\xF', '\\', '\n', '\xF', '\f', '\xF', '\xE', '\xF', 
		'_', '\v', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\x10', '\x3', '\x10', 
		'\a', '\x10', '\x65', '\n', '\x10', '\f', '\x10', '\xE', '\x10', 'h', 
		'\v', '\x10', '\x3', '\x11', '\x3', '\x11', '\x3', '\x11', '\x3', '\x11', 
		'\x2', '\x2', '\x12', '\x3', '\x3', '\x5', '\x4', '\a', '\x5', '\t', '\x6', 
		'\v', '\a', '\r', '\b', '\xF', '\t', '\x11', '\n', '\x13', '\v', '\x15', 
		'\f', '\x17', '\r', '\x19', '\xE', '\x1B', '\xF', '\x1D', '\x10', '\x1F', 
		'\x11', '!', '\x12', '\x3', '\x2', '\b', '\x4', '\x2', '>', '>', '@', 
		'@', '\x3', '\x2', '\x32', ';', '\x3', '\x2', '$', '$', '\x5', '\x2', 
		'\x43', '\\', '\x61', '\x61', '\x63', '|', '\x6', '\x2', '\x32', ';', 
		'\x43', '\\', '\x61', '\x61', '\x63', '|', '\x5', '\x2', '\v', '\f', '\xF', 
		'\xF', '\"', '\"', '\x2', 't', '\x2', '\x3', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x5', '\x3', '\x2', '\x2', '\x2', '\x2', '\a', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\t', '\x3', '\x2', '\x2', '\x2', '\x2', '\v', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\r', '\x3', '\x2', '\x2', '\x2', '\x2', '\xF', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x11', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x13', '\x3', '\x2', '\x2', '\x2', '\x2', '\x15', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x17', '\x3', '\x2', '\x2', '\x2', '\x2', '\x19', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x1B', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x1D', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1F', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '!', '\x3', '\x2', '\x2', '\x2', '\x3', '#', '\x3', '\x2', 
		'\x2', '\x2', '\x5', '(', '\x3', '\x2', '\x2', '\x2', '\a', '+', '\x3', 
		'\x2', '\x2', '\x2', '\t', '\x30', '\x3', '\x2', '\x2', '\x2', '\v', '\x34', 
		'\x3', '\x2', '\x2', '\x2', '\r', ';', '\x3', '\x2', '\x2', '\x2', '\xF', 
		'=', '\x3', '\x2', '\x2', '\x2', '\x11', '?', '\x3', '\x2', '\x2', '\x2', 
		'\x13', '\x41', '\x3', '\x2', '\x2', '\x2', '\x15', '\x43', '\x3', '\x2', 
		'\x2', '\x2', '\x17', '\x45', '\x3', '\x2', '\x2', '\x2', '\x19', 'R', 
		'\x3', '\x2', '\x2', '\x2', '\x1B', 'U', '\x3', '\x2', '\x2', '\x2', '\x1D', 
		'Y', '\x3', '\x2', '\x2', '\x2', '\x1F', '\x62', '\x3', '\x2', '\x2', 
		'\x2', '!', 'i', '\x3', '\x2', '\x2', '\x2', '#', '$', '\a', 'u', '\x2', 
		'\x2', '$', '%', '\a', 'j', '\x2', '\x2', '%', '&', '\a', 'q', '\x2', 
		'\x2', '&', '\'', '\a', 'y', '\x2', '\x2', '\'', '\x4', '\x3', '\x2', 
		'\x2', '\x2', '(', ')', '\a', 'k', '\x2', '\x2', ')', '*', '\a', 'h', 
		'\x2', '\x2', '*', '\x6', '\x3', '\x2', '\x2', '\x2', '+', ',', '\a', 
		'g', '\x2', '\x2', ',', '-', '\a', 'n', '\x2', '\x2', '-', '.', '\a', 
		'u', '\x2', '\x2', '.', '/', '\a', 'g', '\x2', '\x2', '/', '\b', '\x3', 
		'\x2', '\x2', '\x2', '\x30', '\x31', '\a', 'k', '\x2', '\x2', '\x31', 
		'\x32', '\a', 'p', '\x2', '\x2', '\x32', '\x33', '\a', 'v', '\x2', '\x2', 
		'\x33', '\n', '\x3', '\x2', '\x2', '\x2', '\x34', '\x35', '\a', 'u', '\x2', 
		'\x2', '\x35', '\x36', '\a', 'v', '\x2', '\x2', '\x36', '\x37', '\a', 
		't', '\x2', '\x2', '\x37', '\x38', '\a', 'k', '\x2', '\x2', '\x38', '\x39', 
		'\a', 'p', '\x2', '\x2', '\x39', ':', '\a', 'i', '\x2', '\x2', ':', '\f', 
		'\x3', '\x2', '\x2', '\x2', ';', '<', '\a', '+', '\x2', '\x2', '<', '\xE', 
		'\x3', '\x2', '\x2', '\x2', '=', '>', '\a', '*', '\x2', '\x2', '>', '\x10', 
		'\x3', '\x2', '\x2', '\x2', '?', '@', '\a', '$', '\x2', '\x2', '@', '\x12', 
		'\x3', '\x2', '\x2', '\x2', '\x41', '\x42', '\a', '}', '\x2', '\x2', '\x42', 
		'\x14', '\x3', '\x2', '\x2', '\x2', '\x43', '\x44', '\a', '\x7F', '\x2', 
		'\x2', '\x44', '\x16', '\x3', '\x2', '\x2', '\x2', '\x45', '\x46', '\a', 
		'?', '\x2', '\x2', '\x46', '\x18', '\x3', '\x2', '\x2', '\x2', 'G', 'H', 
		'\a', '?', '\x2', '\x2', 'H', 'S', '\a', '?', '\x2', '\x2', 'I', 'J', 
		'\a', '#', '\x2', '\x2', 'J', 'S', '\a', '?', '\x2', '\x2', 'K', 'S', 
		'\t', '\x2', '\x2', '\x2', 'L', 'M', '\a', '@', '\x2', '\x2', 'M', 'S', 
		'\a', '?', '\x2', '\x2', 'N', 'O', '\a', '>', '\x2', '\x2', 'O', 'S', 
		'\a', '?', '\x2', '\x2', 'P', 'Q', '\a', '(', '\x2', '\x2', 'Q', 'S', 
		'\a', '(', '\x2', '\x2', 'R', 'G', '\x3', '\x2', '\x2', '\x2', 'R', 'I', 
		'\x3', '\x2', '\x2', '\x2', 'R', 'K', '\x3', '\x2', '\x2', '\x2', 'R', 
		'L', '\x3', '\x2', '\x2', '\x2', 'R', 'N', '\x3', '\x2', '\x2', '\x2', 
		'R', 'P', '\x3', '\x2', '\x2', '\x2', 'S', '\x1A', '\x3', '\x2', '\x2', 
		'\x2', 'T', 'V', '\t', '\x3', '\x2', '\x2', 'U', 'T', '\x3', '\x2', '\x2', 
		'\x2', 'V', 'W', '\x3', '\x2', '\x2', '\x2', 'W', 'U', '\x3', '\x2', '\x2', 
		'\x2', 'W', 'X', '\x3', '\x2', '\x2', '\x2', 'X', '\x1C', '\x3', '\x2', 
		'\x2', '\x2', 'Y', ']', '\a', '$', '\x2', '\x2', 'Z', '\\', '\n', '\x4', 
		'\x2', '\x2', '[', 'Z', '\x3', '\x2', '\x2', '\x2', '\\', '_', '\x3', 
		'\x2', '\x2', '\x2', ']', '[', '\x3', '\x2', '\x2', '\x2', ']', '^', '\x3', 
		'\x2', '\x2', '\x2', '^', '`', '\x3', '\x2', '\x2', '\x2', '_', ']', '\x3', 
		'\x2', '\x2', '\x2', '`', '\x61', '\a', '$', '\x2', '\x2', '\x61', '\x1E', 
		'\x3', '\x2', '\x2', '\x2', '\x62', '\x66', '\t', '\x5', '\x2', '\x2', 
		'\x63', '\x65', '\t', '\x6', '\x2', '\x2', '\x64', '\x63', '\x3', '\x2', 
		'\x2', '\x2', '\x65', 'h', '\x3', '\x2', '\x2', '\x2', '\x66', '\x64', 
		'\x3', '\x2', '\x2', '\x2', '\x66', 'g', '\x3', '\x2', '\x2', '\x2', 'g', 
		' ', '\x3', '\x2', '\x2', '\x2', 'h', '\x66', '\x3', '\x2', '\x2', '\x2', 
		'i', 'j', '\t', '\a', '\x2', '\x2', 'j', 'k', '\x3', '\x2', '\x2', '\x2', 
		'k', 'l', '\b', '\x11', '\x2', '\x2', 'l', '\"', '\x3', '\x2', '\x2', 
		'\x2', '\a', '\x2', 'R', 'W', ']', '\x66', '\x3', '\b', '\x2', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
