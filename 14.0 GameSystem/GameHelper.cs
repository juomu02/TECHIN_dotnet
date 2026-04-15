namespace GameSystem
{
    public static class GameHelper
    {
        public static List<Character> GetAliveCharacters(List<Character> characters)
        {
            return characters.Where(o => o.Health > 0).ToList();
        }
        public static Character GetStrongest(List<Character> characters)
        {
            if (characters.Count == 0)
            {
                return default;
            }
            var strongestChar = characters[0];
            for (int character = 0; character < characters.Count; character++)
            {
                if (strongestChar.Health < characters[character].Health)
                {
                    strongestChar = characters[character];
                }
            }
            return strongestChar;
        }

        public static void PrintAllStats(List<Character> characters)
        {
            
            for (int character = 0; character < characters.Count; character++)
            {
                characters[character].DisplayStats();
            }
        }
    }
}