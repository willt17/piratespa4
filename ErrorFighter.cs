using System;
namespace piratespa4
{
    public class ErrorFighter : fighter
    {
        public void AttackTurn()
        {
            System.Console.WriteLine("bad attack");
        }
    }
}