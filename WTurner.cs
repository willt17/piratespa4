namespace piratespa4
{
    public class WTurner : fighter
    {
        override public void  AttackTurn()
        {
            System.Console.WriteLine("Sword slash");
        }
        public override string ToString()
        {
            string nameString = "Will Turner";
            return nameString;
        }
    }
}