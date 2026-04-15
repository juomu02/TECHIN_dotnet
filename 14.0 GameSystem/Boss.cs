using System.Runtime.CompilerServices;

namespace GameSystem
{
    public class Boss : Character
    {
        public string BossTitle;
        public int Phase;

        public Boss(string name, int level, int maxHealth, int attackPower,
            string bossTitle)
            : base(name, level, maxHealth, attackPower)
        {
            BossTitle = bossTitle;
            Phase = 1;
        }

        public override void TakeDamage(int damage)
        {
            Health -= damage;
            if (Phase == 1 && Health < MaxHealth / 2)
            {
                Phase = 2;
                AttackPower = AttackPower*2;
            }

            else if (Health < 0)
            {
                Health = 0;
            }
        }
        public new void UseSpecialAbility()
        {
                Console.WriteLine
                ($"Aktyvuotas special ability ...");
        }
        public override string GetClass()
        {
            return $"Boss-{BossTitle}";
        }
        public override void DisplayStats()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Level: {Level}");
            Console.WriteLine($"Class: {GetClass()}");
            Console.WriteLine($"Health: {Health}/{MaxHealth}");
            Console.WriteLine($"AttackPower: {AttackPower}");
            Console.WriteLine();
        }
    }
}