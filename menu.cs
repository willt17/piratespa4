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
            System.Console.WriteLine("3. Fight");
            System.Console.WriteLine("4. View leaderboard");
            System.Console.WriteLine("5. Test fighters");
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
        }
        public string GetFighterMenuChoice()
        {
            DisplayFighterMenu();
            System.Console.WriteLine("Choose your character.");
            return Console.ReadLine();
        }
    }
}