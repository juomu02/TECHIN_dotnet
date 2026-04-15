namespace GameSystem
{
    public class Warrior : Character
    {
        public int ArmorRating;
        public int Rage;

        public Warrior(string name, int level, int maxHealth, int attackPower,
            int armorRating, int rage)
            : base(name, level, maxHealth, attackPower)
        {
            ArmorRating = armorRating;
            Rage = rage;
        }
        public override void TakeDamage(int damage)
        {
            Health -= damage - ArmorRating;
            Console.WriteLine($"{Name} takes {damage - ArmorRating} damage.");
            if (Health < 0)
            {
                Health = 0;
            }
        }
        public new void UseSpecialAbility()
        {
            AttackPower += AttackPower;
            Console.WriteLine
            ($"Aktyvuotas special ability Berserker Rage(2xAttackPower 3 ėjimams).");
        }
        public override string GetClass()
        {
            return "Warrior";
        }
        public override void DisplayStats()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Level: {Level}");
            Console.WriteLine($"Class: {GetClass()}");
            Console.WriteLine($"Health: {Health}/{MaxHealth}");
            Console.WriteLine($"AttackPower: {AttackPower}");
            Console.WriteLine($"ArmorRating: {ArmorRating}");
            Console.WriteLine($"Rage: {Rage}");
            Console.WriteLine();
        }
    }
}