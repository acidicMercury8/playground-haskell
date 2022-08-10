module ParserHelpers where

import Text.Parsec ( ParseError, many, parse, eof )
import Text.Parsec.String ( Parser )

import qualified Text.Parsec.Token as Tok

import Syntax ( Expr, AST )
import Lexer ( lexer, reservedOp )
import Parser ( function, expr )

contents :: Parser a -> Parser a
contents p = do
  Tok.whiteSpace lexer
  r <- p
  eof
  return r

toplevel :: Parser [Expr]
toplevel = many $ do
    def <- function
    reservedOp ";"
    return def

parseExpr :: String -> Either ParseError Expr
parseExpr s = parse (contents expr) "<stdin>" s

parseCode :: String -> Either ParseError AST
parseCode s = parse (contents toplevel) "<stdin>" s