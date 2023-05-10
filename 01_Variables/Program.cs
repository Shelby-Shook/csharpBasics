// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Command Palette:
// Windows: ctrl + shift + p

// >OmniSharp: Restart OmniSharp 

// Declaring Variables
// JavaScript: let name = "value"

// C#: type name = "value";
string firstName = "Harold";

// 1. The type is string
// 2. The variable name is firstname
// 3. = is the assignment operatpr
// 4. the value is "Charlie"

// ctrl + . is our quick fix shortcut

Console.WriteLine(firstName);
// Can change the value, not the type
firstName = "George";
Console.WriteLine(firstName);

// Prompt the user for the input
Console.WriteLine("What is your favorite color?");

// Capture the user's input/response 
// ? indicates that the type is nullable (can be null)
string? color = Console.ReadLine();
Console.WriteLine("You said your favorite color is " + color);