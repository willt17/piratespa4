using System;
using piratespa4;
menu menu = new menu();

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
                fighter player1 = FighterSelect();
                // player1.AttackTurn();
                break;
            }
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
                fighter player1 = new WTurner();
                player1.AttackTurn();
                return player1;
                break;
            }
        default:
            {
                System.Console.WriteLine("bad entry");
                fighter player1 = new ErrorFighter();
                player1.AttackTurn();
                return player1;
                break;
            }
    }
    // WTurner turner = new WTurner();
    // return turner;
}
// WTurner Turner = new WTurner();
// Turner.AttackTurn();
