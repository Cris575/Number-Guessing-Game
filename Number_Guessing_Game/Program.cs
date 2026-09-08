
int secretNumber = new Random().Next(1, 101);
int chances, attempts = 0;
int guess;


Console.WriteLine("Welcome to the Number Guessing Game!");
Console.WriteLine("I'm thinking of a number between 1 and 100.");
Console.WriteLine("Please select the difficulty level:");
Console.WriteLine("1. Easy (10 chances)");
Console.WriteLine("2. Medium (5 chances)");
Console.WriteLine("3. Hard (3 chances)");

Console.Write("Enter your choice (1, 2, or 3): ");

int difficultyChoice = Convert.ToInt32(Console.ReadLine());

SetDifficulty(difficultyChoice, out chances);

do
{
    Console.Write("Enter your guess:");
    guess = Convert.ToInt32(Console.ReadLine());

    attempts++;
    
    if(secretNumber == guess)
    {
        Console.WriteLine($"Congratulations! You guessed the correct number in {attempts} attempts.");
        break;
    }

    if (guess < secretNumber)
    {
        Console.WriteLine("Too low! Try again.");
    }
    else
    {
        Console.WriteLine("Too high! Try again.");
    }

    chances--;

    if (chances == 0)
    {
        Console.WriteLine($"Sorry, you've run out of chances. The correct number was {secretNumber}.");
        break;
    }

}
while (true);


void SetDifficulty(int choice, out int chances)
{
    switch (choice)
    {
        case 1:
            chances = 10;
            Console.WriteLine("You have selected Easy difficulty.");
            break;
        case 2:
            chances = 5;
            Console.WriteLine("You have selected Medium difficulty.");
            break;
        case 3:
            chances = 3;
            Console.WriteLine("You have selected Hard difficulty.");
            break;
        default:
            Console.WriteLine("Invalid choice. Defaulting to Medium difficulty.");
            chances = 5;
            break;
    }

    Console.WriteLine("Let's start the game!");
}