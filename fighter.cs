using System;
namespace piratespa4
{
    public class fighter : iattack
    {
        public int health {get; set;}
        public int maxPower {get; set;}
        public bool isDebuffed {get; set;}
        public string playerName {get; set;}
        public virtual int fighterType {get; set;} = -1;
        public virtual int naturalEnemy {get; set;} = -1;
        public bool pSelected {get; set;} = false;
        public virtual void AttackTurn()
        {
            int damage = 12;
            System.Console.WriteLine($"you did {damage} damage.");
        }
    }
}