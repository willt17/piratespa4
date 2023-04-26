namespace piratespa4
{
    public class JSparrow : fighter
    {
        override public void AttackTurn()
        {
            System.Console.WriteLine("Distract opponent");
        }
        public override string ToString()
        {
            string nameString = "Jack Sparrow";
            return nameString;
        }
    }
}