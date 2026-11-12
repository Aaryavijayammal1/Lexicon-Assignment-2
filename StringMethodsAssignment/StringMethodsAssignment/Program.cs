// PART 1 - STRING METHODS
// QUESTION 1 - Music Instrument

Console.WriteLine();
Console.WriteLine("QUESTION 1 - Music Instrument");

Console.WriteLine("Enter the name of a music instrument:");

string instrument1 = Console.ReadLine();

string instrumentLower1 = instrument1.ToLower();

string result1 = $"Can you play the {instrumentLower1}?";

Console.WriteLine("Actual result: " + result1);

// QUESTION 2 - First Name and Family Name

Console.WriteLine();
Console.WriteLine("QUESTION 2 - Employee Name");

Console.WriteLine("Enter your family name:");
string familyName2 = Console.ReadLine();

Console.WriteLine("Enter your first name:");
string firstName2 = Console.ReadLine();

string result2 = $"{firstName2.ToUpper()} {familyName2.ToUpper()} joined the firm";

Console.WriteLine("Actual result: " + result2);

// QUESTION 3 - Split and Rearrange Full Name

Console.WriteLine();
Console.WriteLine("QUESTION 3 - Full Name");

Console.WriteLine("Enter your first name and family name:");
string fullName3 = Console.ReadLine();

string[] nameParts3 = fullName3.Split(' ');

string firstName3 = nameParts3[0].ToLower();
string familyName3 = nameParts3[1].ToUpper();

string result3 = $"{familyName3}, {firstName3} : present";

Console.WriteLine("Actual result: " + result3);

// PART 2 - IF ELSE CONDITIONS
// QUESTION 1 - Gluten Intolerance

Console.WriteLine();
Console.WriteLine("QUESTION 4 - Gluten Intolerance");

Console.WriteLine("Do you have gluten intolerance? (Yes/No)");

string glutenAnswer4 = Console.ReadLine();

if (glutenAnswer4.ToLower() == "yes")
{
    Console.WriteLine("You will be served gluten free food");
}
else if (glutenAnswer4.ToLower() == "no")
{
    Console.WriteLine("The regular menu will apply");
}
else
{
    Console.WriteLine("Unable to decide preference");
}

// PART 2 - IF ELSE CONDITIONS
// QUESTION 2 - Suspicious Text

Console.WriteLine();
Console.WriteLine("QUESTION 5 - Suspicious Text");

Console.WriteLine("Enter some text:");

string userText5 = Console.ReadLine();

if (userText5.Contains("drop database"))
{
    Console.WriteLine("Error 103: unable to process");
}
else
{
    Console.WriteLine("Text accepted");
}
// QUESTION 4 - Gluten Intolerance

Console.WriteLine();
Console.WriteLine("QUESTION 4 - Gluten Intolerance");

Console.WriteLine("Do you have gluten intolerance? (Yes/No)");
string glutenAnswer = Console.ReadLine();

if (glutenAnswer.ToLower() == "yes")
{
    Console.WriteLine("You have gluten intolerance.");
}
else if (glutenAnswer.ToLower() == "no")
{
    Console.WriteLine("You do not have gluten intolerance.");
}
else
{
    Console.WriteLine("Please enter Yes or No.");
}
// QUESTION 5 - Check for Drop Database

Console.WriteLine();
Console.WriteLine("QUESTION 5 - Text Validation");

Console.WriteLine("Enter some text:");
string textInput5 = Console.ReadLine();

if (textInput5.ToLower().Contains("drop database"))
{
    Console.WriteLine("Error 103: unable to process");
}
else
{
    Console.WriteLine(textInput5);
}
// QUESTION 6 - Sign-up Validation

Console.WriteLine();
Console.WriteLine("QUESTION 6 - Sign-up Validation");

Console.WriteLine("Enter your password:");
string password6 = Console.ReadLine();

Console.WriteLine("Enter your email:");
string email6 = Console.ReadLine();

bool validPassword6 = password6.Length >= 7;

bool validEmail6 = email6.EndsWith(".se") ||
                   email6.EndsWith(".com");

if (validPassword6 && validEmail6)
{
    Console.WriteLine("Account created successfully!");
}
else
{
    if (!validPassword6)
    {
        Console.WriteLine("Password must contain at least 7 characters.");
    }

    if (!validEmail6)
    {
        Console.WriteLine("Email must end with .se or .com.");
    }
}
// QUESTION 7 - Sentence Validation

Console.WriteLine();
Console.WriteLine("QUESTION 7 - Sentence Validation");

Console.WriteLine("Enter a sentence:");
string sentence7 = Console.ReadLine();

string[] words7 = sentence7.Split(
    ' ',
    StringSplitOptions.RemoveEmptyEntries
);

if (words7.Length >= 7)
{
    Console.WriteLine("Sentence accepted");
}
else
{
    Console.WriteLine("Not a correct sentence");
}
// QUESTION 8 - Name Validation

Console.WriteLine();
Console.WriteLine("QUESTION 8 - Name Validation");

Console.WriteLine("Enter your name:");
string name8 = Console.ReadLine();

if (name8.StartsWith("Lord"))
{
    Console.WriteLine("Welcome Your Excellency");
}
else
{
    Console.WriteLine($"Welcome {name8}");
}
// QUESTION 9 - Sum of Array

Console.WriteLine();
Console.WriteLine("QUESTION 9 - Sum of Array");

int[] numbers9 = { 5506, 291, 500, 482, 963 };

int total9 = 0;

for (int i = 0; i < numbers9.Length; i++)
{
    total9 = total9 + numbers9[i];
}

Console.WriteLine("Total: " + total9);
// QUESTION 10 - Alternate Uppercase and Lowercase

Console.WriteLine();
Console.WriteLine("QUESTION 10 - Alternate Words");

Console.WriteLine("Enter a sentence:");
string sentence10 = Console.ReadLine();

string[] words10 = sentence10.Split(
    ' ',
    StringSplitOptions.RemoveEmptyEntries
);

for (int i = 0; i < words10.Length; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(words10[i].ToUpper() + " ");
    }
    else
    {
        Console.Write(words10[i].ToLower() + " ");
    }
}

Console.WriteLine();
// QUESTION 11 - Identify Long Words

Console.WriteLine();
Console.WriteLine("QUESTION 11 - Long Words");

Console.WriteLine("Enter a sentence:");
string sentence11 = Console.ReadLine();

string[] words11 = sentence11.Split(
    ' ',
    StringSplitOptions.RemoveEmptyEntries
);

for (int i = 0; i < words11.Length; i++)
{
    if (words11[i].Length > 6)
    {
        Console.Write(words11[i] + " (long word)");
    }
    else
    {
        Console.Write(words11[i]);
    }

    Console.Write(" ");
}

Console.WriteLine();
// QUESTION 12 - Repeat Words Based on Length

Console.WriteLine();
Console.WriteLine("QUESTION 12 - Repeat Words");

Console.WriteLine("Enter a sentence:");
string sentence12 = Console.ReadLine();

string[] words12 = sentence12.Split(
    ' ',
    StringSplitOptions.RemoveEmptyEntries
);

for (int i = 0; i < words12.Length; i++)
{
    for (int j = 0; j < words12[i].Length; j++)
    {
        Console.WriteLine(words12[i]);
    }
}