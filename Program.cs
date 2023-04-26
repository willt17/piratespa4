using System.Runtime.CompilerServices;
using System;
using piratespa4;
menu menu = new menu();
Random rand = new Random();
fighter player1 = new fighter();
fighter player2 = new fighter();

string userInput = menu.GetMainMenuChoice();
while(userInput!="6")
{
    RouteEm(userInput);
    userInput = menu.GetMainMenuChoice();
}

void RouteEm(string userInput)
{
    switch (userInput)
    {
        case "1":
            {
                player1 = FighterSelect();
                System.Console.WriteLine("Enter your name and press enter.");
                player1.playerName = Console.ReadLine();
                player1.pSelected = true;
                // player1.AttackTurn(); testing delete
                break;
            }
        case "2":
                player2 = FighterSelect();
                System.Console.WriteLine("Enter your name and press enter");
                player2.playerName = Console.ReadLine();
                player2.pSelected = true;
                // player2.AttackTurn(); testing delete
                break;
        case "3":
                if(player1.pSelected == true && player2.pSelected == true)
                {
                    NewGame();
                }
                else
                {
                    System.Console.WriteLine("You need to select both characters");
                }
                break;
        case "5":
                player1.AttackTurn();
                player2.AttackTurn();
                break;
        default:
            {
                System.Console.WriteLine("bad entry");
                break;
            }
    }
}

fighter FighterSelect()
{
    string fighterChoice = menu.GetFighterMenuChoice();
    switch (fighterChoice)
    {
        case "1":
            {
                int startPower = rand.Next(0,101);
                fighter newFighter = new WTurner(){health=100, maxPower=startPower, isDebuffed=false, fighterType=1, naturalEnemy=3};
                // player1.AttackTurn(); testing delete
                return newFighter;
            }
        case "2":
            {
                int startPower = rand.Next(0,101);
                fighter newFighter = new DJones(){health=100, maxPower=startPower, isDebuffed=false, fighterType=2, naturalEnemy=1};
                // player1.AttackTurn(); testing delete
                return newFighter;
            }
        case "3":
            {
                int startPower = rand.Next(0,101);
                fighter newFighter = new JSparrow(){health=100, maxPower=startPower, isDebuffed=false, fighterType=3, naturalEnemy=2};
                // player1.AttackTurn(); testing delete
                return newFighter;
            }
        default:
            {
                System.Console.WriteLine("bad entry");
                return player1;
            }
    }
    // WTurner turner = new WTurner();
    // return turner;
}
// WTurner Turner = new WTurner();
// Turner.AttackTurn();
void NewGame()
{
    System.Console.WriteLine("You have started a new game");
    System.Console.WriteLine($"your fighter is {player1.ToString()} with a health of {player1.health} and your opponent is {player2.ToString()} with a health of {player2.health}");
    CheckOffsets(player1, player2);
    while(player1.health > 0 && player2.health > 0)
    {
        GameTurn();
    }
}
void GameTurn()
{
    System.Console.WriteLine($"It's {player1.playerName} turn to attack");
    System.Console.WriteLine("Press any key to attack");
    Console.ReadKey();
    int damageTotal = DoDamage(player1, player2);
    if(damageTotal > 0)
    {
        player2.health = (player2.health - damageTotal);
        System.Console.WriteLine($"You hit for {damageTotal}, Their current health is {player2.health}");
    }
    else
    {
        System.Console.WriteLine("your attack missed");
    }
    System.Console.WriteLine($"{player2.playerName} will go next");
    System.Console.WriteLine("press any key to attack");
    Console.ReadKey();
    damageTotal = DoDamage(player2, player1);
    if(damageTotal > 0)
    {
        player1.health = (player1.health - damageTotal);
        System.Console.WriteLine($"You hit for {damageTotal}, Their current health is {player1.health}");
    }
    else
    {
        System.Console.WriteLine("Your atack missed.");
    }
}
int DoDamage(fighter aggressor, fighter defender) // should check for damage offsets between the characters
{
    int tempAttack = rand.Next(0, aggressor.maxPower);
    if(defender.isDebuffed == true)
    {
        double betweenDamage = (tempAttack * 1.2);
        int AttackStrength = Convert.ToInt32(betweenDamage);
        int damageResistance = rand.Next(0, defender.maxPower);
        int trueDamage = (AttackStrength - damageResistance);
        return trueDamage;
    }
    else
    {
        int damageResistance = rand.Next(0, defender.maxPower);
        int trueDamage = (tempAttack - damageResistance);
        return trueDamage;
    }
}
void CheckOffsets(fighter f1, fighter f2)
{
    if(f1.naturalEnemy == f2.fighterType && f2.naturalEnemy == f1.fighterType)
    {
        f1.isDebuffed = true;
        f2.isDebuffed = true;
    }
    else if(f1.naturalEnemy == f2.fighterType)
    {
        f1.isDebuffed = true;
    }
    else if(f2.naturalEnemy == f1.fighterType)
    {
        f2.isDebuffed = true;
    }
    else
    {
        System.Console.WriteLine(" ");
    }
}