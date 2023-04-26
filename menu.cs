namespace piratespa4
{
    public class menu
    {
        private void DisplayMainMenu()
        {
            System.Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
            System.Console.WriteLine("1. Choose your character");
            System.Console.WriteLine("2. Choose your opponent");
            System.Console.WriteLine("3. Player fight");
            System.Console.WriteLine("4. Computer fight");
            System.Console.WriteLine("5. Learn the rules");
            System.Console.WriteLine("6. Exit");
        }
        public string GetMainMenuChoice()
        {
            DisplayMainMenu();
            System.Console.WriteLine("Enter menu choice");
            return Console.ReadLine();
        }
        private void DisplayFighterMenu()
        {
            System.Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
            System.Console.WriteLine("1. Will Turner");
            System.Console.WriteLine("2. Davy Jones");
            System.Console.WriteLine("3. Jack Sparrow");
            System.Console.WriteLine("4. Elizabeth Swann");
        }
        public string GetFighterMenuChoice()
        {
            DisplayFighterMenu();
            System.Console.WriteLine("Choose your character.");
            return Console.ReadLine();
        }
        public string Help()
        {
            DisplayHelpMenu();
            DisplayMainMenu();
            System.Console.WriteLine("Enter menu choice");
            return Console.ReadLine();
        }
        private void DisplayHelpMenu()
        {
            System.Console.WriteLine("In the first menu selection you choose player 1's fighter.");
            System.Console.WriteLine("in the second menu selesction you choose player 2's fighter.");
            System.Console.WriteLine("Keep in mind when selecting your characters that every fighter has a natural enemy that does 20 percent more damage to them on each hit.");
            System.Console.WriteLine("For Will Turner this is Jack Sparrow, Davy Jones is Will Turner, Jack Sparrows is Davy Jones, and Elizabeth Swanns is Davy Jones as well.");
            System.Console.WriteLine("The third menu option is for the standard game mode,");
            System.Console.WriteLine("In this game mode player 1 squares off with player 2 in alternating turns.");
            System.Console.WriteLine("The third menu choice is for the computer fight mode,");
            System.Console.WriteLine("In this mode player 1 squares off with the compouter but with a twist,");
            System.Console.WriteLine("The computer has to anticipate your attack if they don't then you get a free hit on them.");
            System.Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }
    }
}