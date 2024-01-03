# What is this
This project allows you to develop and run your code without any dependencies installed or messing with paths. It works by using nuget packages, a ipynb file, vscode and the jupyter + polyglot extensions instead.

# Why
The fsproj file manages the nuget packages and compilation so you don't need to do any CLI commands. 

I have organized the output and input folders to what i think is logical for me. Feel free to change them to something logical for you.

# How
Just remember to add the files that you want to compile to the fsproj. (See comments on what to change there)

Instead of using fsharp interactive or .fsx or program.fs (all valid ways to run it though). I have created a ipynb file, that targets the .NET Runtime. This is done using the polyglot and jupiter extensions in vs code.

The most important thing, is to have a block in the top that looks like the following. This will load all dependencies and should be run when you are making changes or want to test something.

```fsharp
#r "nuget: FsLexYacc.Runtime"
#load "Fun/Absyn.fs"
#load "Fun/Fun.fs"
#load "Fun/FunPar.fs"
#load "Fun/FunLex.fs"
#load "Fun/Parse.fs"
#load "Fun/ParseAndRun.fs"

open Absyn
open Fun
open Parse

```

The cool thing about this approach is that your test a declarative instead of lost in the CLI.

You can also use the other approaches and keep to compilation as the ipynb is a seperate thing, without any coupling to the rest of the project.

