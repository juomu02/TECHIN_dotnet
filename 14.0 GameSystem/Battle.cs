namespace GameSystem
{
    public class Battle
    {
        public List<Character> Heroes;
        public List<Character> Enemies;

        public Battle(List<Character> heroes, List<Character> enemies)
        {
            Heroes = heroes;
            Enemies = enemies;
        }
        public void Start()
        {
            while (Heroes.Where(o => o.Health > 0).ToList().Count > 0 
                && Enemies.Count > 0)
            {
                HeroesTakeTurn();
                EnemiesTakeTurn();
            }
            Console.WriteLine();
            if (Heroes.Where(o => o.Health > 0).ToList().Count > 0)
            {
                Console.WriteLine("The Heroes have won!");
            }
            else { Console.WriteLine("The Heroes were defeated."); }
        }
        private void HeroesTakeTurn()
        {
            var random = new Random();
            for (int hero = 0; hero < Heroes.Count; hero++)
            {
                try
                {
                    if (Heroes[hero].IsAlive() && Enemies.Count > 0)
                    {
                        int enemyIndex = random.Next(0, Enemies.Count - 1);
                        Heroes[hero].Attack(Enemies[enemyIndex]);
                        if (!Enemies[enemyIndex].IsAlive())
                        {
                            Console.WriteLine($"{Enemies[enemyIndex].Name} died!");
                            Enemies.RemoveAt(enemyIndex);
                        }
                    }
                }
                catch (System.Exception e)
                {
                    Console.WriteLine($"{Heroes[hero].Name}'s attack was unsuccessful. {e.Message}");
                }
            }
        }
        private void EnemiesTakeTurn()
        {
            for (int enemy = 0; enemy < Enemies.Count; enemy++)
            {
                var random = new Random();
                var heroesAlive = Heroes.Where(o => o.Health > 0).ToList();
                if (heroesAlive.Count > 0)
                {
                    int heroIndex = random.Next(0, heroesAlive.Count - 1);
                    Enemies[enemy].Attack(heroesAlive[heroIndex]);
                    if (!heroesAlive[heroIndex].IsAlive())
                    {
                        Console.WriteLine($"{heroesAlive[heroIndex].Name} died!");
                    }
                }
            }
        }
    }
}