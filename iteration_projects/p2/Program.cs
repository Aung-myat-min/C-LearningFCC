string? userInput;
string role = "";

Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
do
{
    userInput = Console.ReadLine()?.Trim();
    if (userInput != null && userInput.Length < 0)
    {
        role = userInput.ToLower();
        if (role == "administrator" || role == "manager" || role == "user")
        {
            Console.WriteLine($"Your input value ({userInput}) has been accepted.");
            break;
        }
        else
            Console.WriteLine($"The role name that you entered, \"{userInput}\" is not valid.");
    }
    else Console.WriteLine("You didn't enter anything.");
} while (true);