﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Generated by TokenGenerator
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.Parsing;

namespace JetBrains.ReSharper.Plugins.Unity.Cg.Psi.Parsing.TokenNodeTypes
{
  public partial class CgTokenNodeTypes
  {
    //Tokens
    public const int LBRACE_NODE_TYPE_INDEX = 1000;
    public static readonly TokenNodeType LBRACE = new CgFixedLengthTokenNodeType("LBRACE", LBRACE_NODE_TYPE_INDEX, representation: "{");
    public const int RBRACE_NODE_TYPE_INDEX = 1001;
    public static readonly TokenNodeType RBRACE = new CgFixedLengthTokenNodeType("RBRACE", RBRACE_NODE_TYPE_INDEX, representation: "}");
    public const int LPAREN_NODE_TYPE_INDEX = 1002;
    public static readonly TokenNodeType LPAREN = new CgFixedLengthTokenNodeType("LPAREN", LPAREN_NODE_TYPE_INDEX, representation: "(");
    public const int RPAREN_NODE_TYPE_INDEX = 1003;
    public static readonly TokenNodeType RPAREN = new CgFixedLengthTokenNodeType("RPAREN", RPAREN_NODE_TYPE_INDEX, representation: ")");
    public const int LBRACKET_NODE_TYPE_INDEX = 1004;
    public static readonly TokenNodeType LBRACKET = new CgFixedLengthTokenNodeType("LBRACKET", LBRACKET_NODE_TYPE_INDEX, representation: "[");
    public const int RBRACKET_NODE_TYPE_INDEX = 1005;
    public static readonly TokenNodeType RBRACKET = new CgFixedLengthTokenNodeType("RBRACKET", RBRACKET_NODE_TYPE_INDEX, representation: "]");
    public const int COMMA_NODE_TYPE_INDEX = 1006;
    public static readonly TokenNodeType COMMA = new CgFixedLengthTokenNodeType("COMMA", COMMA_NODE_TYPE_INDEX, representation: ",");
    public const int DOT_NODE_TYPE_INDEX = 1007;
    public static readonly TokenNodeType DOT = new CgFixedLengthTokenNodeType("DOT", DOT_NODE_TYPE_INDEX, representation: ".");
    public const int SEMICOLON_NODE_TYPE_INDEX = 1008;
    public static readonly TokenNodeType SEMICOLON = new CgFixedLengthTokenNodeType("SEMICOLON", SEMICOLON_NODE_TYPE_INDEX, representation: ";");
    public const int COLON_NODE_TYPE_INDEX = 1009;
    public static readonly TokenNodeType COLON = new CgFixedLengthTokenNodeType("COLON", COLON_NODE_TYPE_INDEX, representation: ":");
    public const int QUESTION_MARK_NODE_TYPE_INDEX = 1010;
    public static readonly TokenNodeType QUESTION_MARK = new CgFixedLengthTokenNodeType("QUESTION_MARK", QUESTION_MARK_NODE_TYPE_INDEX, representation: "?");
    public const int LT_NODE_TYPE_INDEX = 1011;
    public static readonly TokenNodeType LT = new CgFixedLengthTokenNodeType("LT", LT_NODE_TYPE_INDEX, representation: "<");
    public const int GT_NODE_TYPE_INDEX = 1012;
    public static readonly TokenNodeType GT = new CgFixedLengthTokenNodeType("GT", GT_NODE_TYPE_INDEX, representation: ">");
    public const int LTEQ_NODE_TYPE_INDEX = 1013;
    public static readonly TokenNodeType LTEQ = new CgFixedLengthTokenNodeType("LTEQ", LTEQ_NODE_TYPE_INDEX, representation: "<=");
    public const int GTEQ_NODE_TYPE_INDEX = 1014;
    public static readonly TokenNodeType GTEQ = new CgFixedLengthTokenNodeType("GTEQ", GTEQ_NODE_TYPE_INDEX, representation: ">=");
    public const int EQEQ_NODE_TYPE_INDEX = 1015;
    public static readonly TokenNodeType EQEQ = new CgFixedLengthTokenNodeType("EQEQ", EQEQ_NODE_TYPE_INDEX, representation: "==");
    public const int NOTEQ_NODE_TYPE_INDEX = 1016;
    public static readonly TokenNodeType NOTEQ = new CgFixedLengthTokenNodeType("NOTEQ", NOTEQ_NODE_TYPE_INDEX, representation: "!=");
    public const int EQUALS_NODE_TYPE_INDEX = 1017;
    public static readonly TokenNodeType EQUALS = new CgFixedLengthTokenNodeType("EQUALS", EQUALS_NODE_TYPE_INDEX, representation: "=");
    public const int PLUS_NODE_TYPE_INDEX = 1018;
    public static readonly TokenNodeType PLUS = new CgFixedLengthTokenNodeType("PLUS", PLUS_NODE_TYPE_INDEX, representation: "+");
    public const int MINUS_NODE_TYPE_INDEX = 1019;
    public static readonly TokenNodeType MINUS = new CgFixedLengthTokenNodeType("MINUS", MINUS_NODE_TYPE_INDEX, representation: "-");
    public const int MULTIPLY_NODE_TYPE_INDEX = 1020;
    public static readonly TokenNodeType MULTIPLY = new CgFixedLengthTokenNodeType("MULTIPLY", MULTIPLY_NODE_TYPE_INDEX, representation: "*");
    public const int DIVIDE_NODE_TYPE_INDEX = 1021;
    public static readonly TokenNodeType DIVIDE = new CgFixedLengthTokenNodeType("DIVIDE", DIVIDE_NODE_TYPE_INDEX, representation: "/");
    public const int MODULO_NODE_TYPE_INDEX = 1022;
    public static readonly TokenNodeType MODULO = new CgFixedLengthTokenNodeType("MODULO", MODULO_NODE_TYPE_INDEX, representation: "%");
    public const int MULTEQ_NODE_TYPE_INDEX = 1023;
    public static readonly TokenNodeType MULTEQ = new CgFixedLengthTokenNodeType("MULTEQ", MULTEQ_NODE_TYPE_INDEX, representation: "*=");
    public const int DIVEQ_NODE_TYPE_INDEX = 1024;
    public static readonly TokenNodeType DIVEQ = new CgFixedLengthTokenNodeType("DIVEQ", DIVEQ_NODE_TYPE_INDEX, representation: "/=");
    public const int PERCEQ_NODE_TYPE_INDEX = 1025;
    public static readonly TokenNodeType PERCEQ = new CgFixedLengthTokenNodeType("PERCEQ", PERCEQ_NODE_TYPE_INDEX, representation: "%=");
    public const int PLUSEQ_NODE_TYPE_INDEX = 1026;
    public static readonly TokenNodeType PLUSEQ = new CgFixedLengthTokenNodeType("PLUSEQ", PLUSEQ_NODE_TYPE_INDEX, representation: "+=");
    public const int MINUSEQ_NODE_TYPE_INDEX = 1027;
    public static readonly TokenNodeType MINUSEQ = new CgFixedLengthTokenNodeType("MINUSEQ", MINUSEQ_NODE_TYPE_INDEX, representation: "-=");
    public const int TILDE_NODE_TYPE_INDEX = 1028;
    public static readonly TokenNodeType TILDE = new CgFixedLengthTokenNodeType("TILDE", TILDE_NODE_TYPE_INDEX, representation: "~");
    public const int LTLT_NODE_TYPE_INDEX = 1029;
    public static readonly TokenNodeType LTLT = new CgFixedLengthTokenNodeType("LTLT", LTLT_NODE_TYPE_INDEX, representation: "<<");
    public const int GTGT_NODE_TYPE_INDEX = 1030;
    public static readonly TokenNodeType GTGT = new CgFixedLengthTokenNodeType("GTGT", GTGT_NODE_TYPE_INDEX, representation: ">>");
    public const int XOR_NODE_TYPE_INDEX = 1031;
    public static readonly TokenNodeType XOR = new CgFixedLengthTokenNodeType("XOR", XOR_NODE_TYPE_INDEX, representation: "^");
    public const int OR_NODE_TYPE_INDEX = 1032;
    public static readonly TokenNodeType OR = new CgFixedLengthTokenNodeType("OR", OR_NODE_TYPE_INDEX, representation: "|");
    public const int AND_NODE_TYPE_INDEX = 1033;
    public static readonly TokenNodeType AND = new CgFixedLengthTokenNodeType("AND", AND_NODE_TYPE_INDEX, representation: "&");
    public const int ANDAND_NODE_TYPE_INDEX = 1034;
    public static readonly TokenNodeType ANDAND = new CgFixedLengthTokenNodeType("ANDAND", ANDAND_NODE_TYPE_INDEX, representation: "&&");
    public const int OROR_NODE_TYPE_INDEX = 1035;
    public static readonly TokenNodeType OROR = new CgFixedLengthTokenNodeType("OROR", OROR_NODE_TYPE_INDEX, representation: "||");
    public const int NEGATE_NODE_TYPE_INDEX = 1036;
    public static readonly TokenNodeType NEGATE = new CgFixedLengthTokenNodeType("NEGATE", NEGATE_NODE_TYPE_INDEX, representation: "!");
    public const int LTLTEQ_NODE_TYPE_INDEX = 1037;
    public static readonly TokenNodeType LTLTEQ = new CgFixedLengthTokenNodeType("LTLTEQ", LTLTEQ_NODE_TYPE_INDEX, representation: "<<=");
    public const int GTGTEQ_NODE_TYPE_INDEX = 1038;
    public static readonly TokenNodeType GTGTEQ = new CgFixedLengthTokenNodeType("GTGTEQ", GTGTEQ_NODE_TYPE_INDEX, representation: ">>=");
    public const int ANDEQ_NODE_TYPE_INDEX = 1039;
    public static readonly TokenNodeType ANDEQ = new CgFixedLengthTokenNodeType("ANDEQ", ANDEQ_NODE_TYPE_INDEX, representation: "&=");
    public const int XOREQ_NODE_TYPE_INDEX = 1040;
    public static readonly TokenNodeType XOREQ = new CgFixedLengthTokenNodeType("XOREQ", XOREQ_NODE_TYPE_INDEX, representation: "^=");
    public const int OREQ_NODE_TYPE_INDEX = 1041;
    public static readonly TokenNodeType OREQ = new CgFixedLengthTokenNodeType("OREQ", OREQ_NODE_TYPE_INDEX, representation: "|=");
    public const int PLUSPLUS_NODE_TYPE_INDEX = 1042;
    public static readonly TokenNodeType PLUSPLUS = new CgFixedLengthTokenNodeType("PLUSPLUS", PLUSPLUS_NODE_TYPE_INDEX, representation: "++");
    public const int MINUSMINUS_NODE_TYPE_INDEX = 1043;
    public static readonly TokenNodeType MINUSMINUS = new CgFixedLengthTokenNodeType("MINUSMINUS", MINUSMINUS_NODE_TYPE_INDEX, representation: "--");

    //FunctionReturnTypeKeywords
    public const int VOID_KEYWORD_NODE_TYPE_INDEX = 1044;
    public static readonly TokenNodeType VOID_KEYWORD = new CgKeywordTokenNodeType("VOID_KEYWORD", VOID_KEYWORD_NODE_TYPE_INDEX, representation: "void");

    //BooleanConstants
    public const int FALSE_KEYWORD_NODE_TYPE_INDEX = 1045;
    public static readonly TokenNodeType FALSE_KEYWORD = new CgKeywordTokenNodeType("FALSE_KEYWORD", FALSE_KEYWORD_NODE_TYPE_INDEX, representation: "false");
    public const int TRUE_KEYWORD_NODE_TYPE_INDEX = 1046;
    public static readonly TokenNodeType TRUE_KEYWORD = new CgKeywordTokenNodeType("TRUE_KEYWORD", TRUE_KEYWORD_NODE_TYPE_INDEX, representation: "true");

    //TypeDeclarationKeywords
    public const int STRUCT_KEYWORD_NODE_TYPE_INDEX = 1047;
    public static readonly TokenNodeType STRUCT_KEYWORD = new CgKeywordTokenNodeType("STRUCT_KEYWORD", STRUCT_KEYWORD_NODE_TYPE_INDEX, representation: "struct");

    //FlowControlKeywords
    public const int BREAK_KEYWORD_NODE_TYPE_INDEX = 1048;
    public static readonly TokenNodeType BREAK_KEYWORD = new CgKeywordTokenNodeType("BREAK_KEYWORD", BREAK_KEYWORD_NODE_TYPE_INDEX, representation: "break");
    public const int CONTINUE_KEYWORD_NODE_TYPE_INDEX = 1049;
    public static readonly TokenNodeType CONTINUE_KEYWORD = new CgKeywordTokenNodeType("CONTINUE_KEYWORD", CONTINUE_KEYWORD_NODE_TYPE_INDEX, representation: "continue");
    public const int DISCARD_KEYWORD_NODE_TYPE_INDEX = 1050;
    public static readonly TokenNodeType DISCARD_KEYWORD = new CgKeywordTokenNodeType("DISCARD_KEYWORD", DISCARD_KEYWORD_NODE_TYPE_INDEX, representation: "discard");
    public const int DO_KEYWORD_NODE_TYPE_INDEX = 1051;
    public static readonly TokenNodeType DO_KEYWORD = new CgKeywordTokenNodeType("DO_KEYWORD", DO_KEYWORD_NODE_TYPE_INDEX, representation: "do");
    public const int FOR_KEYWORD_NODE_TYPE_INDEX = 1052;
    public static readonly TokenNodeType FOR_KEYWORD = new CgKeywordTokenNodeType("FOR_KEYWORD", FOR_KEYWORD_NODE_TYPE_INDEX, representation: "for");
    public const int IF_KEYWORD_NODE_TYPE_INDEX = 1053;
    public static readonly TokenNodeType IF_KEYWORD = new CgKeywordTokenNodeType("IF_KEYWORD", IF_KEYWORD_NODE_TYPE_INDEX, representation: "if");
    public const int ELSE_KEYWORD_NODE_TYPE_INDEX = 1054;
    public static readonly TokenNodeType ELSE_KEYWORD = new CgKeywordTokenNodeType("ELSE_KEYWORD", ELSE_KEYWORD_NODE_TYPE_INDEX, representation: "else");
    public const int SWITCH_KEYWORD_NODE_TYPE_INDEX = 1055;
    public static readonly TokenNodeType SWITCH_KEYWORD = new CgKeywordTokenNodeType("SWITCH_KEYWORD", SWITCH_KEYWORD_NODE_TYPE_INDEX, representation: "switch");
    public const int WHILE_KEYWORD_NODE_TYPE_INDEX = 1056;
    public static readonly TokenNodeType WHILE_KEYWORD = new CgKeywordTokenNodeType("WHILE_KEYWORD", WHILE_KEYWORD_NODE_TYPE_INDEX, representation: "while");

    //VariableStorageClassKeywords
    public const int EXTERN_KEYWORD_NODE_TYPE_INDEX = 1057;
    public static readonly TokenNodeType EXTERN_KEYWORD = new CgKeywordTokenNodeType("EXTERN_KEYWORD", EXTERN_KEYWORD_NODE_TYPE_INDEX, representation: "extern");
    public const int NOINTERPOLATION_KEYWORD_NODE_TYPE_INDEX = 1058;
    public static readonly TokenNodeType NOINTERPOLATION_KEYWORD = new CgKeywordTokenNodeType("NOINTERPOLATION_KEYWORD", NOINTERPOLATION_KEYWORD_NODE_TYPE_INDEX, representation: "nointerpolation");
    public const int PRECISE_KEYWORD_NODE_TYPE_INDEX = 1059;
    public static readonly TokenNodeType PRECISE_KEYWORD = new CgKeywordTokenNodeType("PRECISE_KEYWORD", PRECISE_KEYWORD_NODE_TYPE_INDEX, representation: "precise");
    public const int SHARED_KEYWORD_NODE_TYPE_INDEX = 1060;
    public static readonly TokenNodeType SHARED_KEYWORD = new CgKeywordTokenNodeType("SHARED_KEYWORD", SHARED_KEYWORD_NODE_TYPE_INDEX, representation: "shared");
    public const int GROUPSHARED_KEYWORD_NODE_TYPE_INDEX = 1061;
    public static readonly TokenNodeType GROUPSHARED_KEYWORD = new CgKeywordTokenNodeType("GROUPSHARED_KEYWORD", GROUPSHARED_KEYWORD_NODE_TYPE_INDEX, representation: "groupshared");
    public const int STATIC_KEYWORD_NODE_TYPE_INDEX = 1062;
    public static readonly TokenNodeType STATIC_KEYWORD = new CgKeywordTokenNodeType("STATIC_KEYWORD", STATIC_KEYWORD_NODE_TYPE_INDEX, representation: "static");
    public const int UNIFORM_KEYWORD_NODE_TYPE_INDEX = 1063;
    public static readonly TokenNodeType UNIFORM_KEYWORD = new CgKeywordTokenNodeType("UNIFORM_KEYWORD", UNIFORM_KEYWORD_NODE_TYPE_INDEX, representation: "uniform");
    public const int VOLATILE_KEYWORD_NODE_TYPE_INDEX = 1064;
    public static readonly TokenNodeType VOLATILE_KEYWORD = new CgKeywordTokenNodeType("VOLATILE_KEYWORD", VOLATILE_KEYWORD_NODE_TYPE_INDEX, representation: "volatile");

    //TypeModifierKeywords
    public const int CONST_KEYWORD_NODE_TYPE_INDEX = 1065;
    public static readonly TokenNodeType CONST_KEYWORD = new CgKeywordTokenNodeType("CONST_KEYWORD", CONST_KEYWORD_NODE_TYPE_INDEX, representation: "const");
    public const int ROW_MAJOR_KEYWORD_NODE_TYPE_INDEX = 1066;
    public static readonly TokenNodeType ROW_MAJOR_KEYWORD = new CgKeywordTokenNodeType("ROW_MAJOR_KEYWORD", ROW_MAJOR_KEYWORD_NODE_TYPE_INDEX, representation: "row_major");
    public const int COLUMN_MAJOR_KEYWORD_NODE_TYPE_INDEX = 1067;
    public static readonly TokenNodeType COLUMN_MAJOR_KEYWORD = new CgKeywordTokenNodeType("COLUMN_MAJOR_KEYWORD", COLUMN_MAJOR_KEYWORD_NODE_TYPE_INDEX, representation: "column_major");

    //FunctionStorageClassKeywords
    public const int INLINE_KEYWORD_NODE_TYPE_INDEX = 1068;
    public static readonly TokenNodeType INLINE_KEYWORD = new CgKeywordTokenNodeType("INLINE_KEYWORD", INLINE_KEYWORD_NODE_TYPE_INDEX, representation: "inline");

    //MiscKeywords
    public const int RETURN_KEYWORD_NODE_TYPE_INDEX = 1069;
    public static readonly TokenNodeType RETURN_KEYWORD = new CgKeywordTokenNodeType("RETURN_KEYWORD", RETURN_KEYWORD_NODE_TYPE_INDEX, representation: "return");
    public const int REGISTER_KEYWORD_NODE_TYPE_INDEX = 1070;
    public static readonly TokenNodeType REGISTER_KEYWORD = new CgKeywordTokenNodeType("REGISTER_KEYWORD", REGISTER_KEYWORD_NODE_TYPE_INDEX, representation: "register");
    public const int PACKOFFSET_KEYWORD_NODE_TYPE_INDEX = 1071;
    public static readonly TokenNodeType PACKOFFSET_KEYWORD = new CgKeywordTokenNodeType("PACKOFFSET_KEYWORD", PACKOFFSET_KEYWORD_NODE_TYPE_INDEX, representation: "packoffset");
    public const int ASM_KEYWORD_NODE_TYPE_INDEX = 1072;
    public static readonly TokenNodeType ASM_KEYWORD = new CgKeywordTokenNodeType("ASM_KEYWORD", ASM_KEYWORD_NODE_TYPE_INDEX, representation: "asm");

    //TextureTypeKeywords
    public const int TEXTURE_KEYWORD_NODE_TYPE_INDEX = 1073;
    public static readonly TokenNodeType TEXTURE_KEYWORD = new CgKeywordTokenNodeType("TEXTURE_KEYWORD", TEXTURE_KEYWORD_NODE_TYPE_INDEX, representation: "texture");
    public const int TEXTURE1D_KEYWORD_NODE_TYPE_INDEX = 1074;
    public static readonly TokenNodeType TEXTURE1D_KEYWORD = new CgKeywordTokenNodeType("TEXTURE1D_KEYWORD", TEXTURE1D_KEYWORD_NODE_TYPE_INDEX, representation: "Texture1D");
    public const int TEXTURE1DARRAY_KEYWORD_NODE_TYPE_INDEX = 1075;
    public static readonly TokenNodeType TEXTURE1DARRAY_KEYWORD = new CgKeywordTokenNodeType("TEXTURE1DARRAY_KEYWORD", TEXTURE1DARRAY_KEYWORD_NODE_TYPE_INDEX, representation: "Texture1DArray");
    public const int TEXTURE2D_KEYWORD_NODE_TYPE_INDEX = 1076;
    public static readonly TokenNodeType TEXTURE2D_KEYWORD = new CgKeywordTokenNodeType("TEXTURE2D_KEYWORD", TEXTURE2D_KEYWORD_NODE_TYPE_INDEX, representation: "Texture2D");
    public const int TEXTURE2DARRAY_KEYWORD_NODE_TYPE_INDEX = 1077;
    public static readonly TokenNodeType TEXTURE2DARRAY_KEYWORD = new CgKeywordTokenNodeType("TEXTURE2DARRAY_KEYWORD", TEXTURE2DARRAY_KEYWORD_NODE_TYPE_INDEX, representation: "Texture2DArray");
    public const int TEXTURE3D_KEYWORD_NODE_TYPE_INDEX = 1078;
    public static readonly TokenNodeType TEXTURE3D_KEYWORD = new CgKeywordTokenNodeType("TEXTURE3D_KEYWORD", TEXTURE3D_KEYWORD_NODE_TYPE_INDEX, representation: "Texture3D");
    public const int TEXTURECUBE_KEYWORD_NODE_TYPE_INDEX = 1079;
    public static readonly TokenNodeType TEXTURECUBE_KEYWORD = new CgKeywordTokenNodeType("TEXTURECUBE_KEYWORD", TEXTURECUBE_KEYWORD_NODE_TYPE_INDEX, representation: "TextureCube");

    //InputModifierKeywords
    public const int IN_KEYWORD_NODE_TYPE_INDEX = 1080;
    public static readonly TokenNodeType IN_KEYWORD = new CgKeywordTokenNodeType("IN_KEYWORD", IN_KEYWORD_NODE_TYPE_INDEX, representation: "in");
    public const int INOUT_KEYWORD_NODE_TYPE_INDEX = 1081;
    public static readonly TokenNodeType INOUT_KEYWORD = new CgKeywordTokenNodeType("INOUT_KEYWORD", INOUT_KEYWORD_NODE_TYPE_INDEX, representation: "inout");
    public const int OUT_KEYWORD_NODE_TYPE_INDEX = 1082;
    public static readonly TokenNodeType OUT_KEYWORD = new CgKeywordTokenNodeType("OUT_KEYWORD", OUT_KEYWORD_NODE_TYPE_INDEX, representation: "out");

    private const int LAST_GENERATED_TOKEN_TYPE_INDEX = 1083;  }
}
