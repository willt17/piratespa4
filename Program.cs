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
                // player1.AttackTurn(); testing delete
                break;
            }
        case "2":
                player2 = FighterSelect();
                // player2.AttackTurn(); testing delete
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
                int damage = rand.Next(0,startPower); // try to make inline
                int defense = rand.Next(0,startPower); // try to make inline
                fighter newFighter = new WTurner(){health=100, attackStrength=damage,defensivePower=defense,isDebuffed=false, fighterType=1};
                // player1.AttackTurn(); testing delete
                return newFighter;
            }
        case "2":
            {
                int startPower = rand.Next(0,101);
                int damage = rand.Next(0,startPower); // try to make inline
                int defense = rand.Next(0,startPower); // try to make inline
                fighter newFighter = new DJones(){health=100, attackStrength=damage, defensivePower=defense, isDebuffed=false, fighterType=2};
                // player1.AttackTurn(); testing delete
                return newFighter;
            }
        case "3":
            {
                int startPower = rand.Next(0,101);
                int damage = rand.Next(0,startPower); // try to make inline
                int defense = rand.Next(0,startPower); // try to make inline
                fighter newFighter = new JSparrow(){health=100, attackStrength=damage, defensivePower=defense, isDebuffed=false, fighterType=3};
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
