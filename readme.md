This project allows you to develop and run your code without any dependencies installed or messing with paths. It works by using nuget packages and a ipynb vscode and the jupyter + polyglot extensions instead.

The fsproj file manages the nuget packages and compilation so you don't need to do any CLI commands.

Just remember to add the files that you want to compile to the fsproj.

```xml
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net7.0</TargetFramework> <!-- comment -->
    <RootNamespace>exan-22</RootNamespace>
  </PropertyGroup>
  <ItemGroup>
    <Compile Include="Fun\Absyn.fs" />
    <Compile Include="Program.fs" />
    <None Include="Fun\FunLex.fsl" />
    <None Include="Fun\FunPar.fsy" />
  </ItemGroup>
  <ItemGroup>
    <PackageReference Include="FsLexYacc" Version="11.2.0" />
    <PackageReference Include="FsLexYacc.Runtime" Version="11.2.0" />
  </ItemGroup>
</Project>

```


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