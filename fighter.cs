using System;
namespace piratespa4
{
    public class fighter : iattack
    {
        public int health {get; set;}
        public int attackStrength {get; set;}
        public bool isDebuffed {get; set;}
        public int defensivePower {get; set;}
        public void AttackTurn()
        {
            int damage = 12;
            System.Console.WriteLine($"you did {damage} damage");
        }
    }
}