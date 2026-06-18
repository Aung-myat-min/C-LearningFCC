string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

foreach (string myStr in myStrings)
{
    int startIndex = 0;
    int loop = 5;
    string currentString = myStr;
    do
    {
        int periodIndex = currentString.IndexOf(".", startIndex);
        if (periodIndex == -1)
        {
            Console.WriteLine(currentString.Trim());
            break;
        }

        Console.WriteLine(currentString.Substring(startIndex, periodIndex).Trim());
        currentString = currentString.Remove(0, (periodIndex + 1));
        loop--;
    } while (loop > 0);
}
