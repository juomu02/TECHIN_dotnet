namespace GameSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Character> heroes = new List<Character>
                {new Warrior("Bonker", 1, 20, 4, 2, 0),
                new Mage("Zapper", 1, 10, 0, 80, 5),
                new Archer("Robbin", 1, 12, 7, 5, 5)};

            List<Character> enemies = new List<Character>
                {new Boss("Gnarlicus", 3, 80, 5, "Destroyer of Worlds")};

            var battle = new Battle(heroes, enemies);
            battle.Start();

            var aliveCharacters = GameHelper.GetAliveCharacters(heroes);
            Console.WriteLine();
            Console.WriteLine("Alive characters:");
            GameHelper.PrintAllStats(aliveCharacters);

            var strongestCharacter = GameHelper.GetStrongest(heroes);
            Console.WriteLine();
            Console.WriteLine("Strongest character:");
            strongestCharacter.DisplayStats();
        }
    }
}