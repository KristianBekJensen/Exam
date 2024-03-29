// Signature file for parser generated by fsyacc
module FunPar
type token = 
  | EOF
  | LPAR
  | RPAR
  | SEMICOLON
  | COLON
  | CONS
  | NIL
  | HEAD
  | TAIL
  | EQ
  | NE
  | GT
  | LT
  | GE
  | LE
  | SEQAND
  | SEQOR
  | PLUS
  | MINUS
  | TIMES
  | DIV
  | MOD
  | FUN
  | FN
  | RARROW
  | AND
  | TRY
  | WITH
  | EXN
  | RAISE
  | BEGIN
  | ELSE
  | END
  | FALSE
  | IF
  | IN
  | LET
  | VAL
  | NOT
  | THEN
  | TRUE
  | PRIM1 of (string)
  | CSTBOOL of (bool)
  | NAME of (string)
  | CSTINT of (int)
type tokenId = 
    | TOKEN_EOF
    | TOKEN_LPAR
    | TOKEN_RPAR
    | TOKEN_SEMICOLON
    | TOKEN_COLON
    | TOKEN_CONS
    | TOKEN_NIL
    | TOKEN_HEAD
    | TOKEN_TAIL
    | TOKEN_EQ
    | TOKEN_NE
    | TOKEN_GT
    | TOKEN_LT
    | TOKEN_GE
    | TOKEN_LE
    | TOKEN_SEQAND
    | TOKEN_SEQOR
    | TOKEN_PLUS
    | TOKEN_MINUS
    | TOKEN_TIMES
    | TOKEN_DIV
    | TOKEN_MOD
    | TOKEN_FUN
    | TOKEN_FN
    | TOKEN_RARROW
    | TOKEN_AND
    | TOKEN_TRY
    | TOKEN_WITH
    | TOKEN_EXN
    | TOKEN_RAISE
    | TOKEN_BEGIN
    | TOKEN_ELSE
    | TOKEN_END
    | TOKEN_FALSE
    | TOKEN_IF
    | TOKEN_IN
    | TOKEN_LET
    | TOKEN_VAL
    | TOKEN_NOT
    | TOKEN_THEN
    | TOKEN_TRUE
    | TOKEN_PRIM1
    | TOKEN_CSTBOOL
    | TOKEN_NAME
    | TOKEN_CSTINT
    | TOKEN_end_of_input
    | TOKEN_error
type nonTerminalId = 
    | NONTERM__startMain
    | NONTERM_Main
    | NONTERM_Valdecs
    | NONTERM_Valdec
    | NONTERM_AndFunDecs
    | NONTERM_Expr
    | NONTERM_AtExpr
    | NONTERM_AppExpr
    | NONTERM_Const
/// This function maps tokens to integer indexes
val tagOfToken: token -> int

/// This function maps integer indexes to symbolic token ids
val tokenTagToTokenId: int -> tokenId

/// This function maps production indexes returned in syntax errors to strings representing the non terminal that would be produced by that production
val prodIdxToNonTerminal: int -> nonTerminalId

/// This function gets the name of a token as a string
val token_to_string: token -> string
val Main : (FSharp.Text.Lexing.LexBuffer<'cty> -> token) -> FSharp.Text.Lexing.LexBuffer<'cty> -> (Absyn.program<'a>) 
