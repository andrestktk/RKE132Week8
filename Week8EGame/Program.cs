
string[] heros = {"Harry Potter", "Luke Skywalker", "Lara Croft", "Bilbo Baggins", "Scooby-Doo"};
string[] villans = {"Voldemort", "Darth Vader", "Dracula", "Joker", "Sauron"};
string[] weapon = {"magic wand", "plastic fork", "banana", "wooden sword", "lego brick"};

string hero = getRandomValuFromArray(heros);
string heroWeapon = getRandomValuFromArray(weapon);
Console.WriteLine($"Today {hero} with {heroWeapon} saves the day!");


string villian = getRandomValuFromArray(villans);
string villianWeapon = getRandomValuFromArray(weapon);
Console.WriteLine($" Today {villian} with {villianWeapon} trys to take over the world!");



static string getRandomValuFromArray(string[] someArray)
{
    Random rnd = new Random();
    int randomIndex = rnd.Next(0, someArray.Length);
    string randomStringFromArray = someArray[randomIndex];
    return randomStringFromArray;
}


