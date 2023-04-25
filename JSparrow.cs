namespace piratespa4
{
    public class JSparrow : fighter
    {
        override public void AttackTurn()
        {
            int damage = this.attackStrength;
            System.Console.WriteLine("Distract opponent");
            System.Console.WriteLine($"you did {damage} damage.");
        }
    }
}