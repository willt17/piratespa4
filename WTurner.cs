namespace piratespa4
{
    public class WTurner : fighter
    {
        override public void  AttackTurn()
        {
            int damage = this.attackStrength;
            System.Console.WriteLine("Sword slash");
            System.Console.WriteLine($"you did {damage} damage.");
        }
    }
}