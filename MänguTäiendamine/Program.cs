
string folderPath = @"C:\\Users\\Andres\\Desktop\\Minu\\Kool\\TTK\\Programeerimine\\data\\";
string heroFile = "heroes.txt";
string villanFile = "villains.txt";

string[] heroes = File.ReadAllLines(Path.Combine(folderPath, heroFile));
string[] villains = File.ReadAllLines(Path.Combine(folderPath, villanFile));
string[] weapon = { "magic wand", "plastic fork", "banana", "wooden sword", "lego brick" };

string hero = getRandomValuFromArray(heroes);
string heroWeapon = getRandomValuFromArray(weapon);
int heroHP = GetCharecterHP(hero);
int heroStrikesStreght = heroHP; //parandus
Console.WriteLine($"Today {hero} ({heroHP}) with {heroWeapon} saves the day!");

string villian = getRandomValuFromArray(villains);
string villianWeapon = getRandomValuFromArray(weapon);
int villianHP = GetCharecterHP(villian);
int villianStrikesStrenght = villianHP; //parandus
Console.WriteLine($" Today {villian} ({villianHP}) with {villianWeapon} trys to take over the world!");

while(heroHP > 0 && villianHP > 0)
{
    heroHP = heroHP - hit(villian, villianStrikesStrenght);
    villianHP = villianHP - hit(hero, heroStrikesStreght);
}

Console.WriteLine($"Hero {hero} HP: {heroHP}");
Console.WriteLine($"Villian {villian} HP: {villianHP}");

if (heroHP > 0)
{
    Console.WriteLine($"{hero} saves the day!");
}
else if(villianHP > 0)
{
    Console.WriteLine("Dark side wins!");
}
else
{
    Console.WriteLine("Draw");
}

static string getRandomValuFromArray(string[] someArray)
{
    Random rnd = new Random();
    int randomIndex = rnd.Next(0, someArray.Length);
    string randomStringFromArray = someArray[randomIndex];
    return randomStringFromArray;
}

static int GetCharecterHP(string charecterName)
{
    if (charecterName.Length < 10)
    {
        return 10;
    }
    else
    {
        return 10;
    }
}

static int hit(string characterName,int characterHP)
{
    Random rnd = new Random();
    int strike = rnd.Next(0, characterHP);

    if(strike == 0)
    {
        Console.WriteLine($"{characterName} missed the tarrget");
    }
    else if(strike == characterHP - 1)
    {
        Console.WriteLine($"{characterName} made a critical hit!");
    }
    else
    {
        Console.WriteLine($"{characterName} hit {strike}!");
    }
    return strike;
}

