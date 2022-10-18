﻿string[] names = new[]
    {"Bobby", "Sarah", "Marc", "Taylor", "Rushi"};
string[] homeTown = new[]
    {"Detroit", "Utica", "Farmington Hills", "Shelby Township", "West Bloomfield"};
string[] favoriteFood = new[]
    {"Pizza", "Spicy Chicken Sandwich", "Tacos", "Hamburger", "Sushi"};

bool goAgain = true;

while (goAgain)
{
    Console.WriteLine(
        $"Welcome! Which student would you like to learn more about? Enter a number 1-{names.Length}! {Environment.NewLine}");
    int studentNumber;
    bool isValid = int.TryParse(Console.ReadLine(), out studentNumber);

    while (studentNumber < 1 || studentNumber > names.Length)
    {
        Console.WriteLine($"Your Number {studentNumber} is not within the correct range of numbers{Environment.NewLine}");
        Console.WriteLine(
            $"Welcome! Which student would you like to learn more about? Enter a number 1-{names.Length}! {Environment.NewLine}");
        studentNumber = Convert.ToInt32(Console.ReadLine());
    }


    Console.WriteLine(
        $"Student {studentNumber} is {names.ElementAt(studentNumber - 1)}. What would you like to know? Enter hometown or favorite food{Environment.NewLine}");
    string userCategory = Console.ReadLine().ToLower().Trim().Replace(" ", "");
    bool validCategory = StudentCategoryValid(userCategory);

    while (!validCategory)
    {
        Console.Write($"You entered an invalid category please enter hometown or favorite food {Environment.NewLine}");
        userCategory = Console.ReadLine().ToLower().Trim().Replace(" ", "");
        validCategory = StudentCategoryValid(userCategory);
    }

    if (userCategory == "hometown")
    {
        Console.WriteLine(
            $"{names.ElementAt(studentNumber - 1)} is from {homeTown.ElementAt(studentNumber - 1)}{Environment.NewLine} ");
        Console.WriteLine("Would you like to learn about another student? Enter y or n!");
        string tryAgain = Console.ReadLine().ToLower().Trim();
        goAgain = getStudent(tryAgain);
    }
    else
    {
        Console.WriteLine(
            $"{names.ElementAt(studentNumber - 1)}'s favorite food is {favoriteFood.ElementAt(studentNumber - 1)}{Environment.NewLine}");
        Console.WriteLine("Would you like to learn about another student? Enter y or n!");
        string tryAgain = Console.ReadLine().ToLower().Trim();
        goAgain = getStudent(tryAgain);
    }

    Console.WriteLine("Thanks!");
    Environment.Exit(0);
}



bool StudentCategoryValid(string userSelection)
{
    if (userSelection == "hometown" || userSelection == "favoritefood")
    {
        return true;
    }

    return false;
}

bool getStudent(string userInputYN)
{
    if (userInputYN == "y")
    {
        return true;
    }

    return false;
}