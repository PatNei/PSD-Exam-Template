#r "nuget: FsLexYacc.Runtime"
#load "syntax/Absyn.fs"
#load "par/FunPar.fs"
#load "lex/FunLex.fs"
#load "misc/HigherFun.fs"
#load "misc/Parse.fs"
#load "misc/ParseAndRun.fs"

open Absyn
open ParseAndRun


let printo x = printfn "%A" x

let code =
    """
let s1 = {2, 3} in 
    let s2 = {1,4} in 
        s1 ++ s2 = {2,4,3,1} 
    end
end
"""

// let hello = (fromString code)

let hello2 = (fromString code)
printo hello2
let leggo = eval hello2 []

leggo
