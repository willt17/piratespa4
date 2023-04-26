namespace piratespa4
{
    public class ESwann : fighter
    {
        public void AttackTurn()
        {
            System.Console.WriteLine("Sneak attack");
        }
        public override string ToString()
        {
            string nameString = "Elizabeth Swann";
            return nameString;
        }
    }
}