namespace GameSystem
{
    public class Archer : Character
    {
        public int ArrowCount;
        public int CriticalChance;

        public Archer(string name, int level, int maxHealth, int attackPower,
            int arrowCount, int criticalChance)
            : base(name, level, maxHealth, attackPower)
        {
            ArrowCount = arrowCount;
            CriticalChance = criticalChance;
        }
        public override void Attack(Character target)
        {
            if (target == null)
            {
                throw new ArgumentNullException("Attack with null target");
            }
            else if (ArrowCount == 0)
            {
                throw new InvalidOperationException("No arrows left.");
            }
            else
            {
                ArrowCount -= 1;
                var random = new Random();
                int attackDamage = AttackPower;
                if (random.Next(1, 100) <= CriticalChance)
                {
                    attackDamage = AttackPower * 2;
                }
                ;

                Console.WriteLine($"{GetClass()} {Name} attacks {target.GetClass()} {target.Name} for {attackDamage} damage.");
                target.TakeDamage(attackDamage);
            }
        }
        public new void UseSpecialAbility()
        {
            Console.WriteLine
            ($"Aktyvuotas special ability Rain on Arrows(Attack all enemies).");
        }
        public override string GetClass()
        {
            return "Archer";
        }
        public override void DisplayStats()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Level: {Level}");
            Console.WriteLine($"Class: {GetClass()}");
            Console.WriteLine($"Health: {Health}/{MaxHealth}");
            Console.WriteLine($"AttackPower: {AttackPower}");
            Console.WriteLine($"Arrow count: {ArrowCount}");
            Console.WriteLine($"CriticalChance: {CriticalChance}");
            Console.WriteLine();
        }
    }
}