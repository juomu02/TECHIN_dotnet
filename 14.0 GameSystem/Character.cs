namespace GameSystem
{
    public abstract class Character
    {
        public string Name;
        public int Level;
        public int Health { get; set; }
        public int MaxHealth;
        public int AttackPower;

        public abstract string GetClass();
        public Character(string name, int level, int maxHealth, int attackPower)
        {
            Name = name;
            Level = level;
            Health = maxHealth;
            MaxHealth = maxHealth;
            AttackPower = attackPower;
        }
        public virtual void Attack(Character target)
        {
            if (target == null)
            {
                throw new ArgumentNullException("Attack with null target");
            }
            else
            {
                Console.WriteLine($"{GetClass()} {Name} attacks {target.GetClass()} {target.Name} for {AttackPower} damage.");
                target.TakeDamage(AttackPower);
            }
        }
        public virtual void TakeDamage(int damage)
        {
            Health -= damage;
            Console.WriteLine($"{Name} takes {damage} damage.");
            if (Health < 0)
            {
                Health = 0;
            }
        }
        public bool IsAlive()
        {
            if (Health != 0)
                return true;
            else
            {
                return false;
            }
        }
        public virtual void UseSpecialAbility()
        {
        }
        public abstract void DisplayStats();
    }
}