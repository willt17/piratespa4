namespace piratespa4
{
    public class DJones : fighter
    {
        override public void AttackTurn()
        {
            System.Console.WriteLine("Cannon fire");
        }
        public override string ToString()
        {
            string nameString = "Davy Jones";
            return nameString;
        }
    }
}