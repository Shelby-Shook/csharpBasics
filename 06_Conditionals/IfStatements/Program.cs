bool isRaining = false;
bool isGoingOutside = true;

/*
If statement syntax
if (true/false value or expression)
{
    Curly braces on a new line

    Body of code to be executed if the condition is true

}
*/

if (isRaining)
{
    Console.WriteLine("It is raining.");
}

// If is raining AND we are going outside
if (isRaining && isGoingOutside)
{
    Console.WriteLine("Better bring an umbrella.");
}

// Is not raining OR we are not going outside
if (!isRaining || !isGoingOutside)
{
    Console.WriteLine("I do not need an umbrella.");
}

// Exclusively not raining or we are going outside
if (isRaining ^ isGoingOutside)
{
    Console.WriteLine("I will only go outside if it is not raining.");
}
    // If it is not raining cut the grass, if it is raining don't cut the grass

if (isRaining) // True
{
    // ...
}

if (!isRaining)
{
    Console.WriteLine("I will go cut the grass.");
}
else
{
    Console.WriteLine("I will not cut the grass.");
}

Console.WriteLine("How are you feeling on a scale of 1-5?");
string? feelingRating = Console.ReadLine();

if (feelingRating == "5")
{
    Console.WriteLine("That's great to hear!");
}
else if (feelingRating == "4")
{
    Console.WriteLine("Good stuff.");
}

else if (feelingRating == "3")
{
    Console.WriteLine("Hope things improve!");
}
else if (feelingRating == "2")
{
    Console.WriteLine("Oh. Sorry to hear that.");
}
else if (feelingRating == "1")
{
    Console.WriteLine("Dang, we hope your day gets better!");
}
else
{
    Console.WriteLine("Sorry, we don't understand. Please try again later.");
}