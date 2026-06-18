Random random = new Random();
int heroHealth = 10;
int monsterHealth = 10;

string turn = "Hero";

int attack;

do
{
    attack = random.Next(1, 11);
    switch (turn)
    {
        case "Hero":
            monsterHealth -= attack;
            Console.WriteLine($"Monster was damaged and lost {attack} health and now has {monsterHealth} health.");
            turn = "Monster";
            break;
        case "Monster":
            heroHealth -= attack;
            Console.WriteLine($"Hero was damaged and lost {attack} health and now has {heroHealth} health.");
            turn = "Hero";
            break;
        default:
            continue;
    }

    if (heroHealth <= 0)
    {
        Console.WriteLine("Mosnter Wins!");
        break;
    }
    else if (monsterHealth <= 0)
    {
        Console.WriteLine("Hero Wins!");
        break;
    }
} while (true);
