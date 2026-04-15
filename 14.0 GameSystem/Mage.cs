namespace GameSystem
{
    public class Mage : Character
    {
        public int ManaPoints;
        public int MaxMana;
        public int SpellPower;

        public Mage(string name, int level, int maxHealth, int attackPower,
             int maxMana, int spellPower)
            : base(name, level, maxHealth, attackPower)
        {
            ManaPoints = maxMana;
            MaxMana = maxMana;
            SpellPower = spellPower;
        }
        public override void Attack(Character target)
        {
            if (target == null)
            {
                throw new ArgumentNullException("Attack with null target");
            }
            else
            {
                Console.WriteLine($"{GetClass()} {Name} attacks {target.GetClass()} {target.Name} for {SpellPower} damage.");
                target.TakeDamage(SpellPower);
            }
        }
        public new void UseSpecialAbility()
        {
            if (ManaPoints >= 50)
            {
                ManaPoints -= 50;
                Console.WriteLine
                ($"Aktyvuotas special ability Fireball(3x damage).");
            }
            else
            {
                throw new InvalidOperationException("Not enough mana.");
            }
        }
        public override string GetClass()
        {
            return "Mage";
        }
        public override void DisplayStats()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Level: {Level}");
            Console.WriteLine($"Class: {GetClass()}");
            Console.WriteLine($"Health: {Health}/{MaxHealth}");
            Console.WriteLine($"Mana: {ManaPoints}/{MaxMana}");
            Console.WriteLine($"SpellPower: {SpellPower}");
            Console.WriteLine();
        }
    }
}