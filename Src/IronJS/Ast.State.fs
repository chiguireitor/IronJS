﻿namespace IronJS.Ast

open IronJS
open IronJS.Aliases

type ParserState = { 
  ScopeChain: FunctionScope list
  GlobalDynamicScopeLevel: int
  LocalDynamicScopeLevels: int list
  FunctionMap : Dict<int, FunctionScope * Node>
} with
  member x.InDynamicScope = x.GlobalDynamicScopeLevel > 0
  member x.Scope = x.ScopeChain.Head
  member x.ParentScopes = x.ScopeChain.Tail
  static member New = {
    ScopeChain = []
    GlobalDynamicScopeLevel = 0
    LocalDynamicScopeLevels = [0]
    FunctionMap = null
  }