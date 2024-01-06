(* File Fun/ParseAndRun.fs *)

module ParseAndRun

let fromString = Parse.fromString

let eval = HigherFun.eval

let run e = eval e []

