namespace piratespa4
{
    public class DJones : fighter
    {
        override public void AttackTurn()
        {
            int damage = this.attackStrength;
            System.Console.WriteLine("Cannon fire");
            System.Console.WriteLine($"you did {damage} damage.");
        }
    }
}