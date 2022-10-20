string[] names = new[]
    {"Bobby", "Sarah", "Marc", "Taylor", "Rushi"};
string[] homeTown = new[]
    {"White Lake", "Canton", "Royal Oak", "Shelby Township", "West Bloomfield"};
string[] favoriteFood = new[]
    {"Pizza", "Spicy Chicken Sandwich", "Tacos", "Hamburger", "Sushi"};

bool goAgain = true;

while (goAgain)
{
    Console.WriteLine(
        $"Welcome! Which student would you like to learn more about? Enter a number 1-{names.Length}! or 0 to see all students! {Environment.NewLine}");
     int studentNumber;
     bool isValid = int.TryParse(Console.ReadLine(), out studentNumber);
     bool validCategory = false;
     string userCategory = "";
     if (studentNumber == 0)
     {
         foreach (var name  in names)
         {
             studentNumber++;
             Console.WriteLine($"{studentNumber} - { name}");
         }

         Console.WriteLine(
             $"Welcome! Which student would you like to learn more about? Enter a number 1-{names.Length}!{Environment.NewLine}");
         
         isValid = int.TryParse(Console.ReadLine(), out studentNumber);
        Console.WriteLine(
             $"Student {studentNumber} is {names.ElementAt(studentNumber - 1)}. What would you like to know? Enter hometown or favorite food{Environment.NewLine}");
         userCategory = Console.ReadLine()!.ToLower().Trim().Replace(" ", "");
         validCategory = StudentCategoryValid(userCategory);

     }
     else if (studentNumber >= 1 || studentNumber <= names.Length)
     {
         Console.WriteLine(
             $"Welcome! Which student would you like to learn more about? Enter a number 1-{names.Length}!{Environment.NewLine}");

         isValid = int.TryParse(Console.ReadLine(), out studentNumber);
        Console.WriteLine(
             $"Student {studentNumber} is {names.ElementAt(studentNumber - 1)}. What would you like to know? Enter hometown or favorite food{Environment.NewLine}");
         userCategory = Console.ReadLine()!.ToLower().Trim().Replace(" ", "");
         validCategory = StudentCategoryValid(userCategory);
     }
     else
     {
         while (studentNumber < 1 || studentNumber > names.Length)
         {
             Console.WriteLine(
                 $"Your Number {studentNumber} is not within the correct range of numbers{Environment.NewLine}");
             Console.WriteLine(
                 $"Welcome! Which student would you like to learn more about? Enter a number 1-{names.Length}! {Environment.NewLine}");
             bool isValidAgain = int.TryParse(Console.ReadLine(), out studentNumber);
         }

    }
     

    ;

    while (!validCategory)
    {
        Console.Write(
            $"You entered an invalid category please enter hometown or favorite food {Environment.NewLine}");
        userCategory = Console.ReadLine()!.ToLower().Trim().Replace(" ", "");
        validCategory = StudentCategoryValid(userCategory);
    }

    if (userCategory == "hometown")
    {
        Console.WriteLine(
            $"{names.ElementAt(studentNumber - 1)} is from {homeTown.ElementAt(studentNumber - 1)}{Environment.NewLine} ");
        Console.WriteLine("Would you like to learn about another student? Enter y or n!");
        string tryAgain = Console.ReadLine()!.ToLower().Trim();
        goAgain = GetStudent(tryAgain);
    }
    else
    {
        Console.WriteLine(
            $"{names.ElementAt(studentNumber - 1)}'s favorite food is {favoriteFood.ElementAt(studentNumber - 1)}{Environment.NewLine}");
        Console.WriteLine("Would you like to learn about another student? Enter y or n!");
        string tryAgain = Console.ReadLine()!.ToLower().Trim();
        goAgain = GetStudent(tryAgain);
    }

}

Console.WriteLine("Thanks!");
Environment.Exit(0);



bool StudentCategoryValid(string userSelection)
{
    if (userSelection == "hometown" || userSelection == "favoritefood")
    {
        return true;
    }

    return false;
}

bool GetStudent(string userInputRunAgain)
{
    if (userInputRunAgain == "y")
    {
        return true;
    }

    return false;
}