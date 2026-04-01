using System.Collections.Immutable;

class Program
{
    public static void Main()
    {
        var mc = new Program();

        mc.Task1();
    }

    private void Task1()
    {
        Console.WriteLine("1. Nuskaitykite sveikūjų skaičių sąrašą iš vartotojo. Naudokite HashSet<int>, kad pašalinti visus pasikartojimus ir atvaizduoti tik unikalias reikšmes.");
        Console.WriteLine();

        Console.Write("Įveskite sveikūjų skaičių seką, atskiriant skaičius tarpais: ");
        string userInput = Console.ReadLine();
        string[] numbers = userInput.Split(" ");
        HashSet<int> numbersHashSet = new HashSet<int>();

        for (int i = 0; i < numbers.Length; i++)
        {
            if (Int32.TryParse(numbers[i], out int number))
            {
                numbersHashSet.Add(number);
            }
        }
        Console.WriteLine($"Įvedėte tokius unikalius skaičius: {string.Join(", ", numbersHashSet)}");
        Console.WriteLine();
    }
}
