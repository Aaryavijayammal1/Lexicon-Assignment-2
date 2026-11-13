// QUESTION 1 - Password Checking

Console.WriteLine("QUESTION 1 - Password Checking");

Console.WriteLine("Enter your password:");
string password = Console.ReadLine();

bool passwordMatch = CheckPassword(password);

if (passwordMatch)
{
    Console.WriteLine("Success");
}
else
{
    Console.WriteLine("Login failed");
}


// QUESTION 2 - Find User

Console.WriteLine();
Console.WriteLine("QUESTION 2 - Find User");

string[][] users =
[
    ["john", "plate"],
    ["michelle", "bike"],
    ["lisa", "pencil"]
];

// Test 1
Console.WriteLine("Enter username (Test 1):");
string username1 = Console.ReadLine();

int result1 = FindUser(users, username1);
Console.WriteLine("Expected result: 1");
Console.WriteLine("Actual result: " + result1);

Console.WriteLine();

// Test 2
Console.WriteLine("Enter username (Test 2):");
string username2 = Console.ReadLine();

int result2 = FindUser(users, username2);
Console.WriteLine("Expected result: 0");
Console.WriteLine("Actual result: " + result2);

Console.WriteLine();

// Test 3
Console.WriteLine("Enter username (Test 3):");
string username3 = Console.ReadLine();

int result3 = FindUser(users, username3);
Console.WriteLine("Expected result: -1");
Console.WriteLine("Actual result: " + result3);


// METHODS

static bool CheckPassword(string password)
{
    return password.ToLower() == "pencil";
}

static int FindUser(string[][] users, string username)
{
    int userMatch = -1;

    for (int i = 0; i < users.Length; i++)
    {
        if (users[i][0] == username.ToLower())
        {
            userMatch = i;
        }
    }

    return userMatch;
}

// QUESTION 3 - Three Separate Methods

Console.WriteLine();
Console.WriteLine("QUESTION 3 - Login System");

string[][] users3 =
[
    ["john", "plate"],
    ["michelle", "bike"],
    ["lisa", "pencil"]
];

// TEST 1
Console.WriteLine("\nTEST 1");
GetLoginDetails(out string q3username1, out string password1);

bool q3result1 = ValidateLogin(users3, username1, password1);

Console.WriteLine("Expected result: Success");
Console.Write("Actual result: ");
DisplayLoginResult(q3result1);


// TEST 2
Console.WriteLine("\nTEST 2");
GetLoginDetails(out string q3username2, out string password2);

bool q3result2 = ValidateLogin(users3, username2, password2);

Console.WriteLine("Expected result: Login failed");
Console.Write("Actual result: ");
DisplayLoginResult(q3result2);


// TEST 3
Console.WriteLine("\nTEST 3");
GetLoginDetails(out string q3username3, out string password3);

bool q3result3 = ValidateLogin(users3, username3, password3);

Console.WriteLine("Expected result: Login failed");
Console.Write("Actual result: ");
DisplayLoginResult(q3result3);


// METHOD 1 - Get Login Details

static void GetLoginDetails(out string username, out string password)
{
    Console.WriteLine("Enter your username:");
    username = Console.ReadLine();

    Console.WriteLine("Enter your password:");
    password = Console.ReadLine();
}


// METHOD 2 - Validate Login

static bool ValidateLogin(string[][] users, string username, string password)
{
    int userMatch = -1;

    for (int i = 0; i < users.Length; i++)
    {
        if (users[i][0] == username.ToLower())
        {
            userMatch = i;
        }
    }

    bool passwordMatch = false;

    if (userMatch > -1)
    {
        passwordMatch = password.ToLower() == users[userMatch][1];
    }

    return passwordMatch;
}


// METHOD 3 - Display Login Result

static void DisplayLoginResult(bool passwordMatch)
{
    if (passwordMatch)
    {
        Console.WriteLine("Success");
    }
    else
    {
        Console.WriteLine("Login failed");
    }
}

// QUESTION 4 - Find Longest String

Console.WriteLine();
Console.WriteLine("QUESTION 4 - Find Longest String");

string[] names4 = ["John", "Michelle", "Lisa", "Alexander"];

int longestLength = FindLongestString(names4);

Console.WriteLine("Expected result: 9");
Console.WriteLine("Actual result: " + longestLength);


// METHOD - Find Longest String

static int FindLongestString(string[] words)
{
    int maxLength = 0;

    for (int i = 0; i < words.Length; i++)
    {
        if (words[i].Length > maxLength)
        {
            maxLength = words[i].Length;
        }
    }

    return maxLength;
}

// QUESTION 5 - Add and Compare Numbers

Console.WriteLine();
Console.WriteLine("QUESTION 5 - Add and Compare Numbers");

// TEST 1
bool q3test1 = IsSumGreater(10, 20, 25);

Console.WriteLine("\nTEST 1");
Console.WriteLine("Expected result: True");
Console.WriteLine("Actual result: " + q3test1);


// TEST 2
bool q3test2 = IsSumGreater(10, 5, 20);

Console.WriteLine("\nTEST 2");
Console.WriteLine("Expected result: False");
Console.WriteLine("Actual result: " + q3test2);


// TEST 3
bool q3test3 = IsSumGreater(10, 10, 20);

Console.WriteLine("\nTEST 3");
Console.WriteLine("Expected result: False");
Console.WriteLine("Actual result: " + q3test3);



// QUESTION 5 - Add and Compare Numbers

Console.WriteLine();
Console.WriteLine("QUESTION 5 - Add and Compare Numbers");

// TEST 1
bool q5test1 = IsSumGreater(10, 20, 25);

Console.WriteLine("\nTEST 1");
Console.WriteLine("Expected result: True");
Console.WriteLine("Actual result: " + q5test1);


// TEST 2
bool q5test2 = IsSumGreater(10, 5, 20);

Console.WriteLine("\nTEST 2");
Console.WriteLine("Expected result: False");
Console.WriteLine("Actual result: " + q5test2);


// TEST 3
bool q5test3 = IsSumGreater(10, 10, 20);

Console.WriteLine("\nTEST 3");
Console.WriteLine("Expected result: False");
Console.WriteLine("Actual result: " + q5test3);


// METHOD - Add and Compare

static bool IsSumGreater(int a, int b, int c)
{
    int sum = a + b;

    return sum > c;
}
