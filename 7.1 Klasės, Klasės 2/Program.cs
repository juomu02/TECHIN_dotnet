using System.ComponentModel.Design;

public class Tasks
{
    public static void Main()
    {
        var mc = new Tasks();
        var fp = new FilterPerson();
        var op = new OrderPerson();
        //1. Užduotis
        //Aprašykite klasę Person. Pridėkite FirstName, LastName, Age, City savybes. 
        //--aprašiau Person.cs faile;

        //Sukurkite List<Person>. 
        List<Person> personList = new List<Person>();
        personList.Add(new Person("Jonas", "Mickevičius", DateTime.Parse("01/01/2006"), "Vilnius"));
        personList.Add(new Person("Tomas", "Stankevičius", DateTime.Parse("01/01/2001"), "Kaunas"));
        personList.Add(new Person("Petras", "Jankauskas", DateTime.Parse("01/01/2011"), "Vilnius"));
        personList.Add(new Person("Ignas", "Žukauskas", DateTime.Parse("01/01/1991"), "Klaipėda"));
        personList.Add(new Person("Marius", "Butkus", DateTime.Parse("01/01/1981"), "Alytus"));
        personList.Add(new Person("Gabija", "Mickevičiūtė", DateTime.Parse("01/01/2006"), "Vilnius"));
        personList.Add(new Person("Emilija", "Stankevičiūtė", DateTime.Parse("01/01/2006"), "Kaunas"));
        personList.Add(new Person("Kamilė", "Jankauskaitė", DateTime.Parse("01/01/1991"), "Vilnius"));
        personList.Add(new Person("Gabrielė", "Žukauskė", DateTime.Parse("01/01/1991"), "Vilnius"));
        personList.Add(new Person("Kamilė", "Butkienė", DateTime.Parse("01/01/1983"), "Vilnius"));
        personList.Add(new Person("Tomas", "Mickevičius", DateTime.Parse("01/01/2006"), "Vilnius"));
        personList.Add(new Person("Tomas", "Stankevičius", DateTime.Parse("01/01/2001"), "Vilnius"));
        personList.Add(new Person("Petras", "Jankauskas", DateTime.Parse("01/01/2010"), "Vilnius"));
        personList.Add(new Person("Ignas", "Žukauskas", DateTime.Parse("01/01/1991"), "Vilnius"));
        personList.Add(new Person("Marius", "Butkus", DateTime.Parse("01/01/1981"), "Vilnius"));
        personList.Add(new Person("Gabija", "Mickevičiūtė", DateTime.Parse("01/01/2007"), "Vilnius"));
        personList.Add(new Person("Emilija", "Stankevičiūtė", DateTime.Parse("01/01/2006"), "Vilnius"));
        personList.Add(new Person("Kamilė", "Jankauskienė", DateTime.Parse("01/01/1991"), "Vilnius"));
        personList.Add(new Person("Gabrielė", "Žukauskienė", DateTime.Parse("01/01/1991"), "Vilnius"));
        personList.Add(new Person("Austėja", "Butkienė", DateTime.Parse("01/01/1981"), "Vilnius"));

        //Surikiuokite sąrašą pagal amžių nuo didžiausios reikšmės 
        var listSortedAge = op.SortAgeDesc(personList);
        // ir išveskite į ekraną top 5;
        mc.PrintTop5(listSortedAge);


        //2. Sukurkite failą, kuriame yra sąrašas Person. Pvz.: Vardas Pavardenis 25 Vilnius...
        var filePath = "/home/jum/git_projects/TECHIN/dotnet/7.1 Klasės, Klasės 2/person.txt";
        mc.ExportPersonListToFile(personList, filePath);


        //3. Parašykite metodą, kuris nuskaito duomenis iš failo į List<Person> sąrašą iš pirmo punkto;
        mc.ImportPersonListFromFile(personList, filePath);


        //4. Padarykite galimybę filtruoti elementus pagal miestą. Miesto pavadinimas įvedamas vartotojo.
        var filteredList = fp.FilterPersonListByCity(personList);
        mc.PrintPersonList(filteredList);


        //5. Padarykite galimybę vartotojui pasirinkti pagal kokią savybę (FirstName, LastName, Age arba City) jis nori filtruoti duomenis.
        var filteredBySelectionList = fp.FilterPersonsBySelection(personList);
        mc.PrintPersonList(filteredBySelectionList);


        // 6. Padarykite galimybę vartotojui pasirinkti pagal kokią savybę (FirstName, LastName, Age arba City) jis nori rikiuoti duomenis.
        var sortedBySelectionList = op.SortPersonsBySelection(personList);
        mc.PrintPersonList(sortedBySelectionList);
        
    }
    private void PrintTop5(List<Person> inputList)
    {
        int maxPeopleToList = (inputList.Count >= 5) ? 5 : inputList.Count;

        Console.WriteLine($"Top 5, surikiuoti pagal amžių, žmonės: ");
        for (int listIndex = 0; listIndex < maxPeopleToList; listIndex++)
        {
            var currentPerson = inputList[listIndex];
            Console.WriteLine($"{currentPerson.FirstName} {currentPerson.LastName}, Age: {currentPerson.Age}, {currentPerson.City};");
        }
        Console.WriteLine();
    }
    private void PrintPersonList(List<Person> inputList)
    {
        int maxPeopleToList = inputList.Count;

        for (int listIndex = 0; listIndex < maxPeopleToList; listIndex++)
        {
            var currentPerson = inputList[listIndex];
            Console.WriteLine($"{currentPerson.FirstName} {currentPerson.LastName}, Age: {currentPerson.Age}, {currentPerson.City};");
        }
        Console.WriteLine();
    }
    private void ExportPersonListToFile(List<Person> personList, string filePath)
    {
        var options = new FileStreamOptions
        {
            Mode = FileMode.OpenOrCreate,
            Access = FileAccess.ReadWrite
        };
        using var writer = new StreamWriter(filePath, options);
        {
            for (int index = 0; index < personList.Count; index++)
            {
                writer.WriteLine($"{personList[index].FirstName}; {personList[index].LastName}; {personList[index].Bitrhtday}; {personList[index].City}");
            }
        }
        ;
    }
    private void ImportPersonListFromFile(List<Person> personList, string filePath)
    {
        var options = new FileStreamOptions
        {
            Mode = FileMode.OpenOrCreate,
        };

        personList.Clear();

        using (var reader = new StreamReader(filePath, options))
        {
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                if (line != null)
                {
                    string[] words = line.Split("; ");
                    personList.Add(new Person(words[0], words[1], DateTime.Parse(words[2]), words[3]));
                }
            }
        }
    }
    public string UserInputCity()
    {
        Console.Write("Įveskite ieškomo miesto pavadinimą: ");
        var userSearchphrase = Console.ReadLine();

        while (userSearchphrase.Length == 0)
        {
            Console.WriteLine("Nieko neįvedėte.");
            Console.Write("Įveskite ieškomo miesto pavadinimą: ");
            userSearchphrase = Console.ReadLine();
        }
        return userSearchphrase;
    }
    public int UserInputOption(string question, SortedDictionary<int, string> searchOptions)
    {
        Console.WriteLine(question);
        foreach (var kvp in searchOptions)
        {
            Console.WriteLine($"{kvp.Key} - {kvp.Value};");
        }
        Console.Write("Įveskite skaičių: ");
        var userOption = Console.ReadLine();

        while (!int.TryParse(userOption, out int option) || !searchOptions.ContainsKey(option))
        {
            Console.WriteLine("Tokio pasirinkimo nėra.");
            Console.Write("Įveskite skaičių: ");
            userOption = Console.ReadLine();
        }
        return int.Parse(userOption);
    }
    public string UserInputSearchWord()
    {
        Console.Write($"Įveskite paieškos parametrą: ");
        var userSearchphrase = Console.ReadLine();

        while (userSearchphrase.Length == 0)
        {
            Console.WriteLine($"Nieko neįvedėte.");
            Console.Write($"Įveskite paieškos parametrą: ");
            userSearchphrase = Console.ReadLine();
        }
        return userSearchphrase;
    }
    public int UserInputSortOrder()
    {
        Console.WriteLine($"Pasirinkite kaip norite rikiuoti sąrašą: ");
        Console.WriteLine($"1 - Ascending;");
        Console.WriteLine($"2 - Descending;");
        Console.Write("Įveskite skaičių: ");
        var userOptionAsc = Console.ReadLine();

        while (!int.TryParse(userOptionAsc, out int userOptAsc) || !(userOptAsc == 1 || userOptAsc == 2))
        {
            Console.WriteLine("Tokio pasirinkimo nėra.");
            Console.Write("Įveskite skaičių: ");
            userOptionAsc = Console.ReadLine();
        }
        return int.Parse(userOptionAsc);
    }
}