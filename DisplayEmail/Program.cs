string[,] corporate =
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external =
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";

for (int i = 0; i < corporate.GetLength(0); i++)
{
    string firstName = corporate[i, 0];
    string lastName = corporate[i, 1];

    DisplayEmail(firstName, lastName, "contoso.com");
}

for (int i = 0; i < external.GetLength(0); i++)
{
    string firstName = corporate[i, 0];
    string lastName = corporate[i, 1];

    DisplayEmail(firstName, lastName);
}

void DisplayEmail(string firstName, string lastName, string domain = "contoso.com")
{
    firstName = firstName.Substring(0, 2).ToLower();
    lastName = lastName.ToLower();
    Console.WriteLine($"{firstName}{lastName}@{domain}");
}