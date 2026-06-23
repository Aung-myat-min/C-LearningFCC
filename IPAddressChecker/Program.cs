string[] ipv4Input = { "107.31.1.5", "255.0.0.255", "555..0.555", "255...255" };
string[] address;
bool validLength = false;
bool validZeroes = false;
bool validRange = false;

foreach (string ip in ipv4Input)
{
    address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);

    ValidateLength();
    ValidateZeroes();
    ValidateRange();

    if (validLength && validZeroes && validRange)
    {
        Console.WriteLine($"{ip} is a valid IPv4 address");
    }
    else
    {
        Console.WriteLine($"{ip} is an invalid IPv4 address");
    }
}

void ValidateLength()
{
    validLength = address.Length == 4;
}

void ValidateZeroes()
{
    validZeroes = true;
    foreach (string add in address)
    {
        if (add.StartsWith("0")) validZeroes = false; return;
    }
}

void ValidateRange()
{
    validRange = true;
    foreach (string add in address)
    {
        int value = int.Parse(add);
        if (value < 0 || value > 255) validRange = false; return;
    }
}