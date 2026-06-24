Random random = new Random();

if (ShouldPlay())
{
    PlayGame();
}

void PlayGame()
{
    var play = true;

    while (play)
    {
        var target = random.Next(1, 6);
        var roll = random.Next(1, 7);

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(roll, target) ? "You win!" : "You lose!");
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}

bool ShouldPlay()
{
    Console.WriteLine("Would you like to play? (Y/N)");
    string? readResult;
    bool status = false;

    do
    {
        readResult = Console.ReadLine();
        if (readResult != null)
        {
            readResult = readResult.Trim().ToLower();

            status = readResult == "y";
        }
    } while (readResult == null);

    return status;
}

bool WinOrLose(int roll, int target)
{
    return roll > target;
}