string first = "The foods we sell are";
string second = "Biscuits, hashbrowns, and pancakes.";

string space = " ";

// Concatenation (using the + operator)
string concatenatedResult = first + space + second;

Console.WriteLine(concatenatedResult);

// Composite Formatting (uses {} and indexes)
string firstName = "Kipper";
string lastName = "Shook";
string middleName = "Dean";

string compositeResult = string.Format("My name is {0} {1}.", firstName, lastName);
Console.WriteLine(compositeResult);

Console.WriteLine("The name is {0}. {0} {2} {1}.", firstName, lastName, middleName);

//String interpolation (The one with the $)
string interpolationResult = $"My name is still {firstName} {lastName}!";
Console.WriteLine(interpolationResult);