string[] values = { "12.3", "45", "ABC", "11", "DEF" };
string message = "";
float total = 0.0f;

foreach (string str in values)
{
    float num = 0.0f;
    if (float.TryParse(str, out num))
    {
        total += num;
    }
    else
    {
        message += str;
    }
}

Console.WriteLine($"Message: {message}\nTotal: {total}");