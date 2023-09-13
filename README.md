# Console Pages (1.0.2 beta)
A lite weight library for create daynamic console applications in dotnet and outher frameworks...      


![Nuget (with prereleases)](https://img.shields.io/nuget/vpre/ConsolePages) ![GitHub tag (with filter)](https://img.shields.io/github/v/tag/AmirMahdyJebreily/console-pages-dot-net) [![License: GPL v3](https://img.shields.io/badge/License-GPLv3-blue.svg)](https://www.gnu.org/licenses/gpl-3.0) [![Conventional Commits](https://img.shields.io/badge/Conventional%20Commits-1.0.0-%23FE5196?logo=conventionalcommits&logoColor=white)](https://conventionalcommits.org)   




## Install
you can install latest version of psckage with this command : 
```ps
dotnet add package ConsolePages
```

## Release Notes
- Fix Bugs of Get Command Component
- Make syntax better

## Why develop applications based on terminal ?
There is no exact answer to this issue, but right now we have a lot of Unix devices in the world and a lot of bad people looking for programs under the terminal. Secondly, a graphical GUI cannot always be the right choice!

## Why use Console Pages ?
Creating multipurpose and large programs with many options under the terminal for C# programmers always requires a lot of money and a code sheet full of `Console` words 😁! But that nightmare of busy .CS program is over!

 New syntax for make a simple app (see [Tests](https://raw.github.com/AmirMahdyJebreily/console-pages-dot-net/blob/main/tests/PagesTest/Program.cs) To get to know more):
```csharp
using ConsolePages;

CApp cApp = new CApp();

cApp.ShowPage(new Page(cApp.Layout, (a) =>
{
    a.Print(("[Error]", a.ErrorColor), "An error occurred in the code...");
    a.Print(("[Success]", a.SuccessColor), "Download Successfully completed...");
    a.Print(("[Info]", a.InfoColor), "App version is", ("0.0.1", a.WarningColor), "...");
    a.Print("You have", ("12$", a.InfoColor), "in your wallet");
}));

```

Raw dotnet syntax (in dotnet) : 

```csharp
Console.ForegroundColor = ConsoleColor.Red;
Console.Write("[Error]");
Console.ResetColor();
Console.WriteLine(" An error occurred in the code...");

Console.ForegroundColor = ConsoleColor.Green;
Console.Write("[Success]");
Console.ResetColor();
Console.WriteLine(" Download Successfully completed...");

Console.ForegroundColor = ConsoleColor.Cyan;
Console.Write("[Info]");
Console.ResetColor();
Console.Write(" App version is");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write(" 0.0.1 ");
Console.RestColor();
Console.WriteLine(" ...");

Console.ResetColor();
Console.WriteLine("You have");
Console.ForegroundColor = ConsoleColor.Cyan;
Console.Write(" 12$ ");
Console.ResetColor();
Console.WriteLine("in your wallet");
```

Both of these will give you this result :   


![result a simple code in console pages](https://raw.githubusercontent.com/AmirMahdyJebreily/console-pages-dot-net/main/docs/Images/res.png)   

In the raw mode of .NET, you say, "Hey, wait, do I have to write so much code and clutter up my page for a colorful output?"
But the Console Pages helps us to have a bigger view of the development of the program under the terminal!
