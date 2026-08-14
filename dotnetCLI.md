If you're learning **C#/.NET seriously**, the **.NET CLI (`dotnet`)** is worth learning because it lets you create, build, run, test, manage packages, and publish .NET applications entirely from the terminal.

Below is a practical command reference, ordered from **beginner → advanced**.

# .NET CLI Complete Guide

## 1. Check whether .NET is installed

### Check SDK version

```bash
dotnet --version
```

Example:

```text
10.0.100
```

This tells you the active .NET SDK version.

### Get detailed SDK information

```bash
dotnet --info
```

This shows:

* SDK version
* Runtime versions
* OS
* Architecture
* Installed SDKs
* Installed runtimes

### List installed SDKs

```bash
dotnet --list-sdks
```

Example:

```text
8.0.414
9.0.305
10.0.100
```

### List installed runtimes

```bash
dotnet --list-runtimes
```

---

# 2. Get help

The most important command when learning the CLI is:

```bash
dotnet --help
```

You can also get help for a specific command:

```bash
dotnet new --help
```

```bash
dotnet run --help
```

```bash
dotnet build --help
```

You can generally use:

```bash
dotnet <command> --help
```

---

# 3. Create a project

The most important command is:

```bash
dotnet new
```

It creates projects from templates.

See available templates:

```bash
dotnet new list
```

You'll see templates such as:

```text
Console
Class Library
ASP.NET Core Web API
ASP.NET Core Web App
MVC
Razor Class Library
xUnit Test Project
```

---

# 4. Create a Console Application

For your current C# learning:

```bash
dotnet new console
```

This creates a project in the current directory.

Or give it a name:

```bash
dotnet new console -n CSharpLearning
```

You'll get:

```text
CSharpLearning/
├── CSharpLearning.csproj
├── Program.cs
└── ...
```

Then:

```bash
cd CSharpLearning
```

and:

```bash
dotnet run
```

---

# 5. Create a project in a specific directory

You can specify the output directory:

```bash
dotnet new console -o CSharpLearning
```

This is useful when you don't want to create the project in your current directory.

---

# 6. Create a Class Library

Class libraries contain reusable C# code.

```bash
dotnet new classlib -n MyLibrary
```

Result:

```text
MyLibrary/
├── MyLibrary.csproj
├── Class1.cs
└── ...
```

You normally don't execute a class library directly.

It gets used by another project.

---

# 7. Create a Web API

Later, when you learn ASP.NET Core:

```bash
dotnet new webapi -n MyApi
```

Then:

```bash
cd MyApi
dotnet run
```

---

# 8. Create an MVC application

```bash
dotnet new mvc -n MyMvcApp
```

---

# 9. Create a Blazor application

Depending on the installed SDK/templates:

```bash
dotnet new blazor -n MyBlazorApp
```

---

# 10. Create a test project

For unit testing:

```bash
dotnet new xunit -n MyTests
```

Other common templates include:

```bash
dotnet new nunit -n MyTests
```

or:

```bash
dotnet new mstest -n MyTests
```

---

# 11. Create a solution

When applications become larger, you'll work with a **solution (`.sln` / `.slnx`)**.

Create one:

```bash
dotnet new sln -n MyApplication
```

Conceptually:

```text
Solution
│
├── Web/API project
├── Class Library
├── Test project
└── Other projects
```

---

# 12. Add a project to a solution

Suppose you have:

```text
MyApplication.slnx
MyApi/
MyLibrary/
MyTests/
```

Add the API:

```bash
dotnet sln add MyApi/MyApi.csproj
```

Add the library:

```bash
dotnet sln add MyLibrary/MyLibrary.csproj
```

Add tests:

```bash
dotnet sln add MyTests/MyTests.csproj
```

You can also list projects:

```bash
dotnet sln list
```

---

# 13. Build a project

Inside the project:

```bash
dotnet build
```

This:

1. Compiles your C# code
2. Resolves dependencies
3. Produces build output

You may see:

```text
Build succeeded.
```

---

# 14. Build without restoring packages

Normally:

```bash
dotnet build
```

performs restore automatically.

You can skip restore:

```bash
dotnet build --no-restore
```

Useful when dependencies have already been restored.

---

# 15. Run the application

The command you'll use constantly:

```bash
dotnet run
```

For your learning project:

```bash
cd CSharpLearning
dotnet run
```

---

# 16. Run without rebuilding

```bash
dotnet run --no-build
```

Useful when you've already built the project.

---

# 17. Pass arguments to your program

Suppose:

```csharp
Console.WriteLine(args[0]);
```

Run:

```bash
dotnet run -- Hello
```

Output:

```text
Hello
```

The `--` separates `dotnet run` arguments from arguments passed to your application.

For example:

```bash
dotnet run -- Suman 25
```

---

# 18. Restore dependencies

```bash
dotnet restore
```

This downloads/resolves NuGet dependencies defined by your project.

Normally you don't have to run it manually because:

```bash
dotnet build
```

and:

```bash
dotnet run
```

perform restore when necessary.

---

# 19. Clean a project

```bash
dotnet clean
```

This removes build output.

You can think of:

```text
bin/
obj/
```

as generated build folders.

`dotnet clean` cleans generated build artifacts.

---

# 20. Rebuild

There isn't usually a separate `dotnet rebuild` command.

Instead:

```bash
dotnet clean
dotnet build
```

---

# 21. NuGet packages

This becomes very important when you start using libraries.

Search for packages:

```bash
dotnet package search Newtonsoft.Json
```

Add a package:

```bash
dotnet add package Newtonsoft.Json
```

Specify a version:

```bash
dotnet add package Newtonsoft.Json --version 13.0.3
```

Remove a package:

```bash
dotnet remove package Newtonsoft.Json
```

List packages:

```bash
dotnet list package
```

Depending on SDK version, some package-management commands are also available through:

```bash
dotnet package
```

and the exact syntax can vary with newer SDK releases.

---

# 22. Project references

Suppose:

```text
MySolution/
│
├── MyApi/
└── MyLibrary/
```

You want:

```text
MyApi → MyLibrary
```

Add the project reference:

```bash
dotnet add MyApi/MyApi.csproj reference MyLibrary/MyLibrary.csproj
```

Then your API can use classes from the library.

Remove it:

```bash
dotnet remove MyApi/MyApi.csproj reference MyLibrary/MyLibrary.csproj
```

List references:

```bash
dotnet list MyApi/MyApi.csproj reference
```

---

# 23. Unit testing

Run all tests:

```bash
dotnet test
```

This is one of the most important commands you'll learn later.

You can also:

```bash
dotnet test --no-build
```

or:

```bash
dotnet test --no-restore
```

---

# 24. Publish an application

`build` and `publish` are different.

### Build

```bash
dotnet build
```

Primarily prepares the application for development/build output.

### Publish

```bash
dotnet publish
```

Creates output intended for deployment.

For example:

```bash
dotnet publish -c Release
```

---

# 25. Release configuration

Development build:

```bash
dotnet build -c Debug
```

Release build:

```bash
dotnet build -c Release
```

Similarly:

```bash
dotnet publish -c Release
```

For applications you're deploying, `Release` is normally used.

---

# 26. Framework-dependent deployment

You can publish:

```bash
dotnet publish -c Release
```

The target machine needs a compatible .NET runtime.

---

# 27. Self-contained deployment

You can publish the .NET runtime together with your application:

```bash
dotnet publish -c Release --self-contained
```

You generally specify a Runtime Identifier (RID), for example Windows x64:

```bash
dotnet publish -c Release -r win-x64 --self-contained
```

Linux x64:

```bash
dotnet publish -c Release -r linux-x64 --self-contained
```

---

# 28. Single-file executable

You can publish as a single file:

```bash
dotnet publish -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true
```

This is useful when you want a simpler deployment artifact.

---

# 29. Runtime identifiers

Common RIDs include:

```text
win-x64
win-arm64
linux-x64
linux-arm64
osx-x64
osx-arm64
```

For example:

```bash
dotnet publish -c Release -r win-x64
```

---

# 30. Install a .NET tool

.NET has a tool ecosystem.

For example:

```bash
dotnet tool install
```

List installed global tools:

```bash
dotnet tool list --global
```

Update:

```bash
dotnet tool update --global <tool-name>
```

Remove:

```bash
dotnet tool uninstall --global <tool-name>
```

---

# 31. Local tools

You can create a tool manifest:

```bash
dotnet new tool-manifest
```

Install a tool locally:

```bash
dotnet tool install <tool-name>
```

Restore local tools:

```bash
dotnet tool restore
```

---

# 32. Watch mode

One of the most useful development commands:

```bash
dotnet watch
```

It monitors your files and automatically reruns/rebuilds when they change.

For example:

```bash
dotnet watch run
```

This becomes especially useful in ASP.NET Core development.

---

# 33. Get environment information

```bash
dotnet --info
```

You can also inspect the environment through your application using .NET APIs, but for CLI troubleshooting, `dotnet --info` is usually the first thing to run.

---

# 34. List SDKs

```bash
dotnet --list-sdks
```

Example:

```text
8.0.408
9.0.305
10.0.100
```

This tells you what SDKs are installed.

---

# 35. List runtimes

```bash
dotnet --list-runtimes
```

Example:

```text
Microsoft.NETCore.App
Microsoft.AspNetCore.App
```

Remember:

**SDK ≠ Runtime**

The SDK is used for developing/building .NET applications.

The runtime is used for running them.

---

# 36. Check project information

You can inspect project information using:

```bash
dotnet list package
```

and:

```bash
dotnet list reference
```

For newer SDKs, there are also `dotnet package` and related commands.

---

# 37. Restore a solution

If you have:

```text
MyApplication.slnx
```

you can run:

```bash
dotnet restore MyApplication.slnx
```

Build:

```bash
dotnet build MyApplication.slnx
```

Test:

```bash
dotnet test MyApplication.slnx
```

---

# 38. Run a specific project

Suppose:

```text
MySolution/
│
├── Api/
│   └── Api.csproj
│
├── Library/
│   └── Library.csproj
│
└── Tests/
    └── Tests.csproj
```

You can run:

```bash
dotnet run --project Api/Api.csproj
```

Build:

```bash
dotnet build Api/Api.csproj
```

Test:

```bash
dotnet test Tests/Tests.csproj
```

---

# 39. Specify the framework

If your project targets a particular framework:

```bash
dotnet build --framework net10.0
```

or:

```bash
dotnet run --framework net10.0
```

The exact framework depends on your installed SDK/project.

---

# 40. Specify configuration

```bash
dotnet run --configuration Release
```

or:

```bash
dotnet build --configuration Release
```

Short form:

```bash
dotnet build -c Release
```

---

# 41. Generate documentation XML

C# projects can generate XML documentation:

```bash
dotnet build -p:GenerateDocumentationFile=true
```

This becomes useful when building libraries.

---

# 42. Important commands to memorize

You **do not need to memorize every command**.

For your current C# learning, concentrate on these:

```bash
dotnet --version
dotnet --info
dotnet --help

dotnet new
dotnet new list
dotnet new console

dotnet restore

dotnet build
dotnet run
dotnet clean

dotnet test

dotnet add package
dotnet remove package
dotnet list package

dotnet add reference
dotnet remove reference
dotnet list reference

dotnet publish

dotnet watch
```

---

# Your C# learning workflow

For your `CSharpLearning` project, your everyday workflow can be extremely simple:

### Create once

```bash
dotnet new console -n CSharpLearning
```

### Enter the project

```bash
cd CSharpLearning
```

### Work on your code

```text
Program.cs
Basics/
ControlFlow/
Arrays/
Methods/
OOP/
```

### Run

```bash
dotnet run
```

### Build

```bash
dotnet build
```

### Clean

```bash
dotnet clean
```

That's enough for the majority of your **C# fundamentals**.

Later, when you start building real applications:

```text
                 .NET CLI
                    │
        ┌───────────┼───────────┐
        ↓           ↓           ↓
     Create       Build       Run
     dotnet new   dotnet      dotnet run
                  build
        │
        ├── Packages
        │   ├── dotnet add package
        │   └── dotnet remove package
        │
        ├── Testing
        │   └── dotnet test
        │
        ├── Development
        │   └── dotnet watch
        │
        └── Deployment
            └── dotnet publish
```

**If you're learning C# now, don't try to memorize the entire CLI.** Learn `new → run → build → add package → test → publish` as your core workflow, and use `dotnet <command> --help` whenever you encounter something new.
