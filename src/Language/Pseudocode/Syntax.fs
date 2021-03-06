﻿namespace Language.Pseudocode.Syntax

type Lit =
  | NumLit of float
  | BoolLit of bool
  | StringLit of string

type PrimType =
  | Int
  | Float
  | Bool
  | String

type TypeName =
  | Prim of PrimType
  | Array of PrimType
  | InlineCSharpType of string

type LValue =
  | Ident of string
  | Subscript of string * Expr

and FuncCall =
  | FuncCall of string * Expr list

and Expr =
  | Lit of Lit
  | LValue of LValue
  | FuncCallExpr of FuncCall
  | NewArray of TypeName * Expr
  | UnOp of string * Expr
  | BinOp of Expr * string * Expr
  | InlineCSharpExpr of string

type Statement =
  | FuncCallStatement of FuncCall
  | Assignment of LValue * Expr
  | Read of LValue * TypeName
  | Write of Expr list
  | If of Expr
  | ElseIf of Expr
  | Else
  | While of Expr
  | DoWhile of Expr
  | Until of Expr
  | Do
  | For of string * Expr * Expr * Expr option
  | Break
  | Continue
  | End
  | Empty
  | InlineCSharpStatement of string
  | Subalgorithm of string * (string * TypeName) list * TypeName option
  | Return of Expr option
  | Import of string

type Program = Program of Statement list
