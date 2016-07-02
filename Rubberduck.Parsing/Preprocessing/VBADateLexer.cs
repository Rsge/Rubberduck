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
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.3")]
[System.CLSCompliant(false)]
public partial class VBADateLexer : Lexer {
	public const int
		AMPM=1, LINE_CONTINUATION=2, JANUARY=3, FEBRUARY=4, MARCH=5, APRIL=6, 
		MAY=7, JUNE=8, JULY=9, AUGUST=10, SEPTEMBER=11, OCTOBER=12, NOVEMBER=13, 
		DECEMBER=14, JAN=15, FEB=16, MAR=17, APR=18, JUN=19, JUL=20, AUG=21, SEP=22, 
		OCT=23, NOV=24, DEC=25, AM=26, PM=27, HASH=28, COMMA=29, DASH=30, SLASH=31, 
		COLON=32, DOT=33, WS=34, DIGIT=35;
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] tokenNames = {
		"'\\u0000'", "'\\u0001'", "'\\u0002'", "'\\u0003'", "'\\u0004'", "'\\u0005'", 
		"'\\u0006'", "'\\u0007'", "'\b'", "'\t'", "'\n'", "'\\u000B'", "'\f'", 
		"'\r'", "'\\u000E'", "'\\u000F'", "'\\u0010'", "'\\u0011'", "'\\u0012'", 
		"'\\u0013'", "'\\u0014'", "'\\u0015'", "'\\u0016'", "'\\u0017'", "'\\u0018'", 
		"'\\u0019'", "'\\u001A'", "'\\u001B'", "'\\u001C'", "'\\u001D'", "'\\u001E'", 
		"'\\u001F'", "' '", "'!'", "'\"'", "'#'"
	};
	public static readonly string[] ruleNames = {
		"AMPM", "LINE_CONTINUATION", "JANUARY", "FEBRUARY", "MARCH", "APRIL", 
		"MAY", "JUNE", "JULY", "AUGUST", "SEPTEMBER", "OCTOBER", "NOVEMBER", "DECEMBER", 
		"JAN", "FEB", "MAR", "APR", "JUN", "JUL", "AUG", "SEP", "OCT", "NOV", 
		"DEC", "AM", "PM", "HASH", "COMMA", "DASH", "SLASH", "COLON", "DOT", "WS", 
		"DIGIT", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", 
		"N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"
	};


	public VBADateLexer(ICharStream input)
		: base(input)
	{
		_interp = new LexerATNSimulator(this,_ATN);
	}

	public override string GrammarFileName { get { return "VBADate.g4"; } }

	public override string[] TokenNames { get { return tokenNames; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x2%\x161\b\x1\x4\x2"+
		"\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b\x4"+
		"\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x4\xE\t\xE\x4\xF\t\xF\x4\x10"+
		"\t\x10\x4\x11\t\x11\x4\x12\t\x12\x4\x13\t\x13\x4\x14\t\x14\x4\x15\t\x15"+
		"\x4\x16\t\x16\x4\x17\t\x17\x4\x18\t\x18\x4\x19\t\x19\x4\x1A\t\x1A\x4\x1B"+
		"\t\x1B\x4\x1C\t\x1C\x4\x1D\t\x1D\x4\x1E\t\x1E\x4\x1F\t\x1F\x4 \t \x4!"+
		"\t!\x4\"\t\"\x4#\t#\x4$\t$\x4%\t%\x4&\t&\x4\'\t\'\x4(\t(\x4)\t)\x4*\t"+
		"*\x4+\t+\x4,\t,\x4-\t-\x4.\t.\x4/\t/\x4\x30\t\x30\x4\x31\t\x31\x4\x32"+
		"\t\x32\x4\x33\t\x33\x4\x34\t\x34\x4\x35\t\x35\x4\x36\t\x36\x4\x37\t\x37"+
		"\x4\x38\t\x38\x4\x39\t\x39\x4:\t:\x4;\t;\x4<\t<\x4=\t=\x4>\t>\x3\x2\x3"+
		"\x2\x3\x2\x3\x2\x5\x2\x82\n\x2\x3\x3\a\x3\x85\n\x3\f\x3\xE\x3\x88\v\x3"+
		"\x3\x3\x3\x3\a\x3\x8C\n\x3\f\x3\xE\x3\x8F\v\x3\x3\x3\x5\x3\x92\n\x3\x3"+
		"\x3\x3\x3\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x5\x3\x5"+
		"\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x6\x3\x6\x3\x6\x3\x6\x3"+
		"\x6\x3\x6\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\b\x3\b\x3\b\x3\b\x3\t\x3\t"+
		"\x3\t\x3\t\x3\t\x3\n\x3\n\x3\n\x3\n\x3\n\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v"+
		"\x3\v\x3\f\x3\f\x3\f\x3\f\x3\f\x3\f\x3\f\x3\f\x3\f\x3\f\x3\r\x3\r\x3\r"+
		"\x3\r\x3\r\x3\r\x3\r\x3\r\x3\xE\x3\xE\x3\xE\x3\xE\x3\xE\x3\xE\x3\xE\x3"+
		"\xE\x3\xE\x3\xF\x3\xF\x3\xF\x3\xF\x3\xF\x3\xF\x3\xF\x3\xF\x3\xF\x3\x10"+
		"\x3\x10\x3\x10\x3\x10\x3\x11\x3\x11\x3\x11\x3\x11\x3\x12\x3\x12\x3\x12"+
		"\x3\x12\x3\x13\x3\x13\x3\x13\x3\x13\x3\x14\x3\x14\x3\x14\x3\x14\x3\x15"+
		"\x3\x15\x3\x15\x3\x15\x3\x16\x3\x16\x3\x16\x3\x16\x3\x17\x3\x17\x3\x17"+
		"\x3\x17\x3\x18\x3\x18\x3\x18\x3\x18\x3\x19\x3\x19\x3\x19\x3\x19\x3\x1A"+
		"\x3\x1A\x3\x1A\x3\x1A\x3\x1B\x3\x1B\x3\x1B\x3\x1C\x3\x1C\x3\x1C\x3\x1D"+
		"\x3\x1D\x3\x1E\x3\x1E\x3\x1F\x3\x1F\x3 \x3 \x3!\x3!\x3\"\x3\"\x3#\x3#"+
		"\x3$\x3$\x3%\x3%\x3&\x3&\x3\'\x3\'\x3(\x3(\x3)\x3)\x3*\x3*\x3+\x3+\x3"+
		",\x3,\x3-\x3-\x3.\x3.\x3/\x3/\x3\x30\x3\x30\x3\x31\x3\x31\x3\x32\x3\x32"+
		"\x3\x33\x3\x33\x3\x34\x3\x34\x3\x35\x3\x35\x3\x36\x3\x36\x3\x37\x3\x37"+
		"\x3\x38\x3\x38\x3\x39\x3\x39\x3:\x3:\x3;\x3;\x3<\x3<\x3=\x3=\x3>\x3>\x2"+
		"\x2\x2?\x3\x2\x3\x5\x2\x4\a\x2\x5\t\x2\x6\v\x2\a\r\x2\b\xF\x2\t\x11\x2"+
		"\n\x13\x2\v\x15\x2\f\x17\x2\r\x19\x2\xE\x1B\x2\xF\x1D\x2\x10\x1F\x2\x11"+
		"!\x2\x12#\x2\x13%\x2\x14\'\x2\x15)\x2\x16+\x2\x17-\x2\x18/\x2\x19\x31"+
		"\x2\x1A\x33\x2\x1B\x35\x2\x1C\x37\x2\x1D\x39\x2\x1E;\x2\x1F=\x2 ?\x2!"+
		"\x41\x2\"\x43\x2#\x45\x2$G\x2%I\x2\x2K\x2\x2M\x2\x2O\x2\x2Q\x2\x2S\x2"+
		"\x2U\x2\x2W\x2\x2Y\x2\x2[\x2\x2]\x2\x2_\x2\x2\x61\x2\x2\x63\x2\x2\x65"+
		"\x2\x2g\x2\x2i\x2\x2k\x2\x2m\x2\x2o\x2\x2q\x2\x2s\x2\x2u\x2\x2w\x2\x2"+
		"y\x2\x2{\x2\x2\x3\x2\x1E\x4\x2\v\v\"\"\x3\x2\x32;\x4\x2\x43\x43\x63\x63"+
		"\x4\x2\x44\x44\x64\x64\x4\x2\x45\x45\x65\x65\x4\x2\x46\x46\x66\x66\x4"+
		"\x2GGgg\x4\x2HHhh\x4\x2IIii\x4\x2JJjj\x4\x2KKkk\x4\x2LLll\x4\x2MMmm\x4"+
		"\x2NNnn\x4\x2OOoo\x4\x2PPpp\x4\x2QQqq\x4\x2RRrr\x4\x2SSss\x4\x2TTtt\x4"+
		"\x2UUuu\x4\x2VVvv\x4\x2WWww\x4\x2XXxx\x4\x2YYyy\x4\x2ZZzz\x4\x2[[{{\x4"+
		"\x2\\\\||\x14C\x2\x3\x3\x2\x2\x2\x2\x5\x3\x2\x2\x2\x2\a\x3\x2\x2\x2\x2"+
		"\t\x3\x2\x2\x2\x2\v\x3\x2\x2\x2\x2\r\x3\x2\x2\x2\x2\xF\x3\x2\x2\x2\x2"+
		"\x11\x3\x2\x2\x2\x2\x13\x3\x2\x2\x2\x2\x15\x3\x2\x2\x2\x2\x17\x3\x2\x2"+
		"\x2\x2\x19\x3\x2\x2\x2\x2\x1B\x3\x2\x2\x2\x2\x1D\x3\x2\x2\x2\x2\x1F\x3"+
		"\x2\x2\x2\x2!\x3\x2\x2\x2\x2#\x3\x2\x2\x2\x2%\x3\x2\x2\x2\x2\'\x3\x2\x2"+
		"\x2\x2)\x3\x2\x2\x2\x2+\x3\x2\x2\x2\x2-\x3\x2\x2\x2\x2/\x3\x2\x2\x2\x2"+
		"\x31\x3\x2\x2\x2\x2\x33\x3\x2\x2\x2\x2\x35\x3\x2\x2\x2\x2\x37\x3\x2\x2"+
		"\x2\x2\x39\x3\x2\x2\x2\x2;\x3\x2\x2\x2\x2=\x3\x2\x2\x2\x2?\x3\x2\x2\x2"+
		"\x2\x41\x3\x2\x2\x2\x2\x43\x3\x2\x2\x2\x2\x45\x3\x2\x2\x2\x2G\x3\x2\x2"+
		"\x2\x3\x81\x3\x2\x2\x2\x5\x86\x3\x2\x2\x2\a\x95\x3\x2\x2\x2\t\x9D\x3\x2"+
		"\x2\x2\v\xA6\x3\x2\x2\x2\r\xAC\x3\x2\x2\x2\xF\xB2\x3\x2\x2\x2\x11\xB6"+
		"\x3\x2\x2\x2\x13\xBB\x3\x2\x2\x2\x15\xC0\x3\x2\x2\x2\x17\xC7\x3\x2\x2"+
		"\x2\x19\xD1\x3\x2\x2\x2\x1B\xD9\x3\x2\x2\x2\x1D\xE2\x3\x2\x2\x2\x1F\xEB"+
		"\x3\x2\x2\x2!\xEF\x3\x2\x2\x2#\xF3\x3\x2\x2\x2%\xF7\x3\x2\x2\x2\'\xFB"+
		"\x3\x2\x2\x2)\xFF\x3\x2\x2\x2+\x103\x3\x2\x2\x2-\x107\x3\x2\x2\x2/\x10B"+
		"\x3\x2\x2\x2\x31\x10F\x3\x2\x2\x2\x33\x113\x3\x2\x2\x2\x35\x117\x3\x2"+
		"\x2\x2\x37\x11A\x3\x2\x2\x2\x39\x11D\x3\x2\x2\x2;\x11F\x3\x2\x2\x2=\x121"+
		"\x3\x2\x2\x2?\x123\x3\x2\x2\x2\x41\x125\x3\x2\x2\x2\x43\x127\x3\x2\x2"+
		"\x2\x45\x129\x3\x2\x2\x2G\x12B\x3\x2\x2\x2I\x12D\x3\x2\x2\x2K\x12F\x3"+
		"\x2\x2\x2M\x131\x3\x2\x2\x2O\x133\x3\x2\x2\x2Q\x135\x3\x2\x2\x2S\x137"+
		"\x3\x2\x2\x2U\x139\x3\x2\x2\x2W\x13B\x3\x2\x2\x2Y\x13D\x3\x2\x2\x2[\x13F"+
		"\x3\x2\x2\x2]\x141\x3\x2\x2\x2_\x143\x3\x2\x2\x2\x61\x145\x3\x2\x2\x2"+
		"\x63\x147\x3\x2\x2\x2\x65\x149\x3\x2\x2\x2g\x14B\x3\x2\x2\x2i\x14D\x3"+
		"\x2\x2\x2k\x14F\x3\x2\x2\x2m\x151\x3\x2\x2\x2o\x153\x3\x2\x2\x2q\x155"+
		"\x3\x2\x2\x2s\x157\x3\x2\x2\x2u\x159\x3\x2\x2\x2w\x15B\x3\x2\x2\x2y\x15D"+
		"\x3\x2\x2\x2{\x15F\x3\x2\x2\x2}\x82\x5\x35\x1B\x2~\x82\x5\x37\x1C\x2\x7F"+
		"\x82\x5I%\x2\x80\x82\x5g\x34\x2\x81}\x3\x2\x2\x2\x81~\x3\x2\x2\x2\x81"+
		"\x7F\x3\x2\x2\x2\x81\x80\x3\x2\x2\x2\x82\x4\x3\x2\x2\x2\x83\x85\t\x2\x2"+
		"\x2\x84\x83\x3\x2\x2\x2\x85\x88\x3\x2\x2\x2\x86\x84\x3\x2\x2\x2\x86\x87"+
		"\x3\x2\x2\x2\x87\x89\x3\x2\x2\x2\x88\x86\x3\x2\x2\x2\x89\x8D\a\x61\x2"+
		"\x2\x8A\x8C\t\x2\x2\x2\x8B\x8A\x3\x2\x2\x2\x8C\x8F\x3\x2\x2\x2\x8D\x8B"+
		"\x3\x2\x2\x2\x8D\x8E\x3\x2\x2\x2\x8E\x91\x3\x2\x2\x2\x8F\x8D\x3\x2\x2"+
		"\x2\x90\x92\a\xF\x2\x2\x91\x90\x3\x2\x2\x2\x91\x92\x3\x2\x2\x2\x92\x93"+
		"\x3\x2\x2\x2\x93\x94\a\f\x2\x2\x94\x6\x3\x2\x2\x2\x95\x96\x5[.\x2\x96"+
		"\x97\x5I%\x2\x97\x98\x5\x63\x32\x2\x98\x99\x5q\x39\x2\x99\x9A\x5I%\x2"+
		"\x9A\x9B\x5k\x36\x2\x9B\x9C\x5y=\x2\x9C\b\x3\x2\x2\x2\x9D\x9E\x5S*\x2"+
		"\x9E\x9F\x5Q)\x2\x9F\xA0\x5K&\x2\xA0\xA1\x5k\x36\x2\xA1\xA2\x5q\x39\x2"+
		"\xA2\xA3\x5I%\x2\xA3\xA4\x5k\x36\x2\xA4\xA5\x5y=\x2\xA5\n\x3\x2\x2\x2"+
		"\xA6\xA7\x5\x61\x31\x2\xA7\xA8\x5I%\x2\xA8\xA9\x5k\x36\x2\xA9\xAA\x5M"+
		"\'\x2\xAA\xAB\x5W,\x2\xAB\f\x3\x2\x2\x2\xAC\xAD\x5I%\x2\xAD\xAE\x5g\x34"+
		"\x2\xAE\xAF\x5k\x36\x2\xAF\xB0\x5Y-\x2\xB0\xB1\x5_\x30\x2\xB1\xE\x3\x2"+
		"\x2\x2\xB2\xB3\x5\x61\x31\x2\xB3\xB4\x5I%\x2\xB4\xB5\x5y=\x2\xB5\x10\x3"+
		"\x2\x2\x2\xB6\xB7\x5[.\x2\xB7\xB8\x5q\x39\x2\xB8\xB9\x5\x63\x32\x2\xB9"+
		"\xBA\x5Q)\x2\xBA\x12\x3\x2\x2\x2\xBB\xBC\x5[.\x2\xBC\xBD\x5q\x39\x2\xBD"+
		"\xBE\x5_\x30\x2\xBE\xBF\x5y=\x2\xBF\x14\x3\x2\x2\x2\xC0\xC1\x5I%\x2\xC1"+
		"\xC2\x5q\x39\x2\xC2\xC3\x5U+\x2\xC3\xC4\x5q\x39\x2\xC4\xC5\x5m\x37\x2"+
		"\xC5\xC6\x5o\x38\x2\xC6\x16\x3\x2\x2\x2\xC7\xC8\x5m\x37\x2\xC8\xC9\x5"+
		"Q)\x2\xC9\xCA\x5g\x34\x2\xCA\xCB\x5o\x38\x2\xCB\xCC\x5Q)\x2\xCC\xCD\x5"+
		"\x61\x31\x2\xCD\xCE\x5K&\x2\xCE\xCF\x5Q)\x2\xCF\xD0\x5k\x36\x2\xD0\x18"+
		"\x3\x2\x2\x2\xD1\xD2\x5\x65\x33\x2\xD2\xD3\x5M\'\x2\xD3\xD4\x5o\x38\x2"+
		"\xD4\xD5\x5\x65\x33\x2\xD5\xD6\x5K&\x2\xD6\xD7\x5Q)\x2\xD7\xD8\x5k\x36"+
		"\x2\xD8\x1A\x3\x2\x2\x2\xD9\xDA\x5\x63\x32\x2\xDA\xDB\x5\x65\x33\x2\xDB"+
		"\xDC\x5s:\x2\xDC\xDD\x5Q)\x2\xDD\xDE\x5\x61\x31\x2\xDE\xDF\x5K&\x2\xDF"+
		"\xE0\x5Q)\x2\xE0\xE1\x5k\x36\x2\xE1\x1C\x3\x2\x2\x2\xE2\xE3\x5O(\x2\xE3"+
		"\xE4\x5Q)\x2\xE4\xE5\x5M\'\x2\xE5\xE6\x5Q)\x2\xE6\xE7\x5\x61\x31\x2\xE7"+
		"\xE8\x5K&\x2\xE8\xE9\x5Q)\x2\xE9\xEA\x5k\x36\x2\xEA\x1E\x3\x2\x2\x2\xEB"+
		"\xEC\x5[.\x2\xEC\xED\x5I%\x2\xED\xEE\x5\x63\x32\x2\xEE \x3\x2\x2\x2\xEF"+
		"\xF0\x5S*\x2\xF0\xF1\x5Q)\x2\xF1\xF2\x5K&\x2\xF2\"\x3\x2\x2\x2\xF3\xF4"+
		"\x5\x61\x31\x2\xF4\xF5\x5I%\x2\xF5\xF6\x5k\x36\x2\xF6$\x3\x2\x2\x2\xF7"+
		"\xF8\x5I%\x2\xF8\xF9\x5g\x34\x2\xF9\xFA\x5k\x36\x2\xFA&\x3\x2\x2\x2\xFB"+
		"\xFC\x5[.\x2\xFC\xFD\x5q\x39\x2\xFD\xFE\x5\x63\x32\x2\xFE(\x3\x2\x2\x2"+
		"\xFF\x100\x5[.\x2\x100\x101\x5q\x39\x2\x101\x102\x5_\x30\x2\x102*\x3\x2"+
		"\x2\x2\x103\x104\x5I%\x2\x104\x105\x5q\x39\x2\x105\x106\x5U+\x2\x106,"+
		"\x3\x2\x2\x2\x107\x108\x5m\x37\x2\x108\x109\x5Q)\x2\x109\x10A\x5g\x34"+
		"\x2\x10A.\x3\x2\x2\x2\x10B\x10C\x5\x65\x33\x2\x10C\x10D\x5M\'\x2\x10D"+
		"\x10E\x5o\x38\x2\x10E\x30\x3\x2\x2\x2\x10F\x110\x5\x63\x32\x2\x110\x111"+
		"\x5\x65\x33\x2\x111\x112\x5s:\x2\x112\x32\x3\x2\x2\x2\x113\x114\x5O(\x2"+
		"\x114\x115\x5Q)\x2\x115\x116\x5M\'\x2\x116\x34\x3\x2\x2\x2\x117\x118\x5"+
		"I%\x2\x118\x119\x5\x61\x31\x2\x119\x36\x3\x2\x2\x2\x11A\x11B\x5g\x34\x2"+
		"\x11B\x11C\x5\x61\x31\x2\x11C\x38\x3\x2\x2\x2\x11D\x11E\a%\x2\x2\x11E"+
		":\x3\x2\x2\x2\x11F\x120\a.\x2\x2\x120<\x3\x2\x2\x2\x121\x122\a/\x2\x2"+
		"\x122>\x3\x2\x2\x2\x123\x124\a\x31\x2\x2\x124@\x3\x2\x2\x2\x125\x126\a"+
		"<\x2\x2\x126\x42\x3\x2\x2\x2\x127\x128\a\x30\x2\x2\x128\x44\x3\x2\x2\x2"+
		"\x129\x12A\t\x2\x2\x2\x12A\x46\x3\x2\x2\x2\x12B\x12C\t\x3\x2\x2\x12CH"+
		"\x3\x2\x2\x2\x12D\x12E\t\x4\x2\x2\x12EJ\x3\x2\x2\x2\x12F\x130\t\x5\x2"+
		"\x2\x130L\x3\x2\x2\x2\x131\x132\t\x6\x2\x2\x132N\x3\x2\x2\x2\x133\x134"+
		"\t\a\x2\x2\x134P\x3\x2\x2\x2\x135\x136\t\b\x2\x2\x136R\x3\x2\x2\x2\x137"+
		"\x138\t\t\x2\x2\x138T\x3\x2\x2\x2\x139\x13A\t\n\x2\x2\x13AV\x3\x2\x2\x2"+
		"\x13B\x13C\t\v\x2\x2\x13CX\x3\x2\x2\x2\x13D\x13E\t\f\x2\x2\x13EZ\x3\x2"+
		"\x2\x2\x13F\x140\t\r\x2\x2\x140\\\x3\x2\x2\x2\x141\x142\t\xE\x2\x2\x142"+
		"^\x3\x2\x2\x2\x143\x144\t\xF\x2\x2\x144`\x3\x2\x2\x2\x145\x146\t\x10\x2"+
		"\x2\x146\x62\x3\x2\x2\x2\x147\x148\t\x11\x2\x2\x148\x64\x3\x2\x2\x2\x149"+
		"\x14A\t\x12\x2\x2\x14A\x66\x3\x2\x2\x2\x14B\x14C\t\x13\x2\x2\x14Ch\x3"+
		"\x2\x2\x2\x14D\x14E\t\x14\x2\x2\x14Ej\x3\x2\x2\x2\x14F\x150\t\x15\x2\x2"+
		"\x150l\x3\x2\x2\x2\x151\x152\t\x16\x2\x2\x152n\x3\x2\x2\x2\x153\x154\t"+
		"\x17\x2\x2\x154p\x3\x2\x2\x2\x155\x156\t\x18\x2\x2\x156r\x3\x2\x2\x2\x157"+
		"\x158\t\x19\x2\x2\x158t\x3\x2\x2\x2\x159\x15A\t\x1A\x2\x2\x15Av\x3\x2"+
		"\x2\x2\x15B\x15C\t\x1B\x2\x2\x15Cx\x3\x2\x2\x2\x15D\x15E\t\x1C\x2\x2\x15E"+
		"z\x3\x2\x2\x2\x15F\x160\t\x1D\x2\x2\x160|\x3\x2\x2\x2\a\x2\x81\x86\x8D"+
		"\x91\x2";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace Rubberduck.Parsing