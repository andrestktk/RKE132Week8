
string folderPath = @"C:\\Users\\Andres\\Desktop\\Minu\\Kool\\TTK\\Programeerimine\\data\\";
string heroFile = "heroes.txt";
string villanFile = "villains.txt";

string[] heroes = File.ReadAllLines(Path.Combine(folderPath, heroFile));
string[] villains = File.ReadAllLines(Path.Combine(folderPath, villanFile));


string[] weapon = { "magic wand", "plastic fork", "banana", "wooden sword", "lego brick" };

string hero = getRandomValuFromArray(heroes);
string heroWeapon = getRandomValuFromArray(weapon);
Console.WriteLine($"Today {hero} with {heroWeapon} saves the day!");


string villian = getRandomValuFromArray(villains);
string villianWeapon = getRandomValuFromArray(weapon);
Console.WriteLine($" Today {villian} with {villianWeapon} trys to take over the world!");


static string getRandomValuFromArray(string[] someArray)
{
    Random rnd = new Random();
    int randomIndex = rnd.Next(0, someArray.Length);
    string randomStringFromArray = someArray[randomIndex];
    return randomStringFromArray;
}


