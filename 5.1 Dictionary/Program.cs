
using System.Runtime.CompilerServices;

class Program
{
    public static void Main()
    {
        var mc = new Program();

        //1. Nuskaitykite sakinį įvestą vartotojo. Naudokite Dictionary<string, int>, kad suskaičiuoti, kiek kartų pasikartoja kiekvienas žodis. Atvaizduokite rezultatus mažėjančia tvarka.
        mc.Task1();
        //2. Sukurkite paprastą telefonų knygos programą naudodami Dictionary<string, string> (Vardas=>Telefonas). Parašykite pridėjimo, šalinimo, paieškos pagal vardą ir visų konataktų išvedimo į ekraną metodus.
        mc.Task2();
        //3. Naudojant Dictionary<char, int> patikrinkite ar dvi eilutės yra viena kitos anagramos (tie patys simboliai, tie patys skaičiai, bet skirtinga tvarka).
        mc.Task3();

    }

    public void Task1()
    {
        Console.WriteLine("1. Užduotis");
        Console.WriteLine("1. Nuskaitykite sakinį įvestą vartotojo. Naudokite Dictionary<string, int>, kad suskaičiuoti, kiek kartų pasikartoja kiekvienas žodis. Atvaizduokite rezultatus mažėjančia tvarka.");
        Console.WriteLine();
        Console.WriteLine("Įveskite sakinį");
        string userInput = Console.ReadLine();
        string[] words = userInput.Split(" ");
        Dictionary<string, int> wordsDict = new Dictionary<string, int>();
        for (int i = 0; i < words.Length; i++)
        {
            if (wordsDict.ContainsKey(words[i]))
            {
                wordsDict[words[i]]++;
            }
            else wordsDict[words[i]] = 1;
        }

        var arrayToSort = wordsDict.ToList();
        arrayToSort.Sort((b, a) => a.Value.CompareTo(b.Value));

        Console.WriteLine(string.Join(", ", arrayToSort.Select(o => $@"""{o.Key}"" kartojasi {o.Value} kart, ")));

    }

    public void Task2()
    {
        Console.WriteLine("2. Užduotis");
        Console.WriteLine("2. Sukurkite paprastą telefonų knygos programą naudodami Dictionary<string, string> (Vardas=>Telefonas). Parašykite pridėjimo, šalinimo, paieškos pagal vardą ir visų konataktų išvedimo į ekraną metodus.");
        Console.WriteLine();
        Dictionary<string, string> phonebook = new Dictionary<string, string>();


        AddPhonebookContact(phonebook);
        AddPhonebookContact(phonebook);
        AddPhonebookContact(phonebook);

        FindPhonebookContact(phonebook);

        ShowAllPhonebookEntries(phonebook);
    }

    public void AddPhonebookContact(Dictionary<string, string> phonebook)
    {
        Console.WriteLine("Įveskite naujo kontakto vardą: ");
        string userInputName = Console.ReadLine();
        Console.WriteLine("Įveskite naujo kontakto telefono numerį: ");
        string userInputPhone = Console.ReadLine();

        if (!phonebook.TryAdd(userInputName, userInputPhone))
        {
            Console.WriteLine("Kontaktas tokiu vardu jau yra įtrauktas.");
        }
    }
    public void FindPhonebookContact(Dictionary<string, string> phonebook)

    {
        Console.WriteLine("Įveskite ieškomo kontakto vardą: ");
        string userInputName = Console.ReadLine();

        if (phonebook.ContainsKey(userInputName))
        {
            Console.WriteLine($"{userInputName} telefono numeris: {phonebook[userInputName]}");
        }
        else
        {
            Console.WriteLine("Kontaktas tokiu vardu nerastas.");
        }
    }

    public void ShowAllPhonebookEntries(Dictionary<string, string> phonebook)

    {
        Console.WriteLine(string.Join(", ", phonebook));
    }
    public void Task3()
    {
        Console.WriteLine("3. Užduotis");
        Console.WriteLine("3. Naudojant Dictionary<char, int> patikrinkite ar dvi eilutės yra viena kitos anagramos (tie patys simboliai, tie patys skaičiai, bet skirtinga tvarka).");
        Console.WriteLine();

        Dictionary<char, int> firstSentence = NewCharDictionary("Įveskite pirmą eilutę: ");
        Dictionary<char, int> secondSentence = NewCharDictionary("Įveskite antrą eilutę: ");

        var result = firstSentence.OrderBy(o => o.Key).SequenceEqual(secondSentence.OrderBy(o => o.Key));

        Console.WriteLine(result);

    }

    public Dictionary<char, int> NewCharDictionary(string title)
    {
        Console.WriteLine(title);
        string userInput = Console.ReadLine();
        Dictionary<char, int> charsDict = new Dictionary<char, int>();

        for (int i = 0; i < userInput.Length; i++)
        {
            if (charsDict.ContainsKey(userInput[i]))
            {
                charsDict[userInput[i]]++;
            }
            else charsDict[userInput[i]] = 1;
        }

        return charsDict;
    }

}

