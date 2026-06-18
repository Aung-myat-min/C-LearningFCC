string? userInput;
int num = 0;

Console.WriteLine("Enter an integer value between 5 and 10");

do
{
    userInput = Console.ReadLine();
    if (userInput != null)
    {
        bool status = int.TryParse(userInput, out num);
        if (!status)
            Console.WriteLine("Sorry, you entered an invalid number, please try again");
        else
            Console.WriteLine($"You entered {num}. Please enter a number between 5 and 10.");
    }
    else Console.WriteLine("You didn't enter anything.");

} while (num < 5 || num > 10);

Console.WriteLine($"Your input value ({num}) has been accepted.");