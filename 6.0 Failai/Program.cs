using System.Xml;

class Program
{
    public static void Main()
    {
        var mc = new Program();
        // mc.Task1();
        // mc.Task2();
        // mc.Task3();
        // mc.Task4(); //jau patikrinot (atordo?)
        mc.Task5();
        // mc.Task6();
        // mc.Task7();
        mc.Task8();
    }

    private void Task1()
    {
        Console.WriteLine("1. Paprašykite vartotojo įvesti kelias teksto eilutes. Naudokite StreamWriter, kad išsaugoti visas eilutes į notes.txt failą. Jei failas jau egzistuoja, perrašykite jį.");
        var userInput1 = UserInputLine("Įveskite pirmą eilutę: ");
        var userInput2 = UserInputLine("Įveskite antrą eilutę: ");
        var userInput3 = UserInputLine("Įveskite trečią eilutę: ");

        var filePath = "/home/jum/git_projects/TECHIN/dotnet/5.2.Failai/notes.txt";

        var options = new FileStreamOptions
        {
            Mode = FileMode.OpenOrCreate,
            Access = FileAccess.ReadWrite
        };

        using var writer = new StreamWriter(filePath, options);
        {
            writer.WriteLine(userInput1);
            writer.WriteLine(userInput2);
            writer.WriteLine(userInput3);
        }
        ;
    }

    private string UserInputLine(string title)
    {
        Console.WriteLine(title);
        string output = Console.ReadLine();
        return output;
    }

    private void Task2()
    {
        Console.WriteLine("2. Naudokite StreamReader, kad nuskaityti ir atvaizduoti tekstinio failo turinį eilutė po eilutės. Apdorokite atvejį, kai failas neegzistuoja.");
        var filePath = "/home/jum/git_projects/TECHIN/dotnet/5.2.Failai/notes.txt";

        var options = new FileStreamOptions
        {
            Mode = FileMode.OpenOrCreate,
        };

        using (var reader = new StreamReader(filePath, options))
        {
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                Console.WriteLine(line);
            }
        }

    }

    private void Task3()
    {
        Console.WriteLine("3. Naudokite StreamReader, kad nuskaityti tekstinį failą ir suskaičiuoti bendrą eilučių, žodžių ir simbolių skaičių. Ekrane atvaizduokite statistiką.");
        var filePath = "/home/jum/git_projects/TECHIN/dotnet/5.2.Failai/notes.txt";
        List<string> fileTextLines = new List<string>();

        var options = new FileStreamOptions
        {
            Mode = FileMode.OpenOrCreate,
        };

        using (var reader = new StreamReader(filePath, options))
        {
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                fileTextLines.Add(line);
            }
        }

        var lineCount = fileTextLines.Count();
        Console.WriteLine($"Eilučių skaičius: {lineCount}.");

        int wordCount = WordCount(fileTextLines);
        Console.WriteLine($"Žodžių skaičius: {wordCount}.");

        var charCount = CharCount(fileTextLines);
        Console.WriteLine($"Simbolių skaičius: {charCount}.");

    }

    private int WordCount(List<string> inputList)
    {
        int output = 0;

        for (int listIndex = 0; listIndex < inputList.Count(); listIndex++)
        {
            string[] words = inputList[listIndex].Split(" ");
            for (int wordIndex = 0; wordIndex < words.Length; wordIndex++)
            {
                output++;
            }
        }

        return output;
    }

    private int CharCount(List<string> inputList)
    {
        int output = 0;

        for (int listIndex = 0; listIndex < inputList.Count(); listIndex++)
        {
            string fullLine = inputList[listIndex];
            output += fullLine.Length;
        }

        return output;
    }

    private void Task4()
    {
        Console.WriteLine("4. Imituokite programos žurnalą (angl.logs): kiekvieną kartą paleidus programą, pridėkite naują laiko žymą į log.txt naudodami StreamWriter pridėjimo rėžimu.");
        var filePath = "/home/jum/git_projects/TECHIN/dotnet/5.2.Failai/log.txt";

        var options = new FileStreamOptions
        {
            Mode = FileMode.OpenOrCreate,
            Access = FileAccess.ReadWrite
        };

        using var writer = new StreamWriter(filePath, true);
        {
            writer.WriteLine($"[{DateTime.Now}] Program start.");
        }
        ;
    }

    private void Task5()
    {
        Console.WriteLine("5. Nuskaitykite tekstinį failą naudodami StreamReader. Naudokite Dictionary<string, int>, kad suskaičiuoti žodžių dažnius ir atvaizduokite 5 dažniausiai pasitaikančius žodžius.");

        var filePath = "/home/jum/git_projects/TECHIN/dotnet/5.2.Failai/notes.txt";
        string textLines = "";

        var options = new FileStreamOptions
        {
            Mode = FileMode.OpenOrCreate,
        };

        using (var reader = new StreamReader(filePath, options))
        {
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                textLines += $" {line}";
            }
        }

        var topWords = Top5Words(textLines);
        Console.WriteLine($"Penki dažniausiai pasikartojantys žodžiai: {topWords}");
    }

    private string Top5Words(string inputText)
    {
        Dictionary<string, int> wordsDict = new Dictionary<string, int>();
        string[] words = inputText.Trim().Split(" ");
        string output = "";

        for (int i = 0; i < words.Length; i++)
        {
            if (wordsDict.ContainsKey(words[i]))
            {
                wordsDict[words[i]]++;
            }
            else wordsDict[words[i]] = 1;
        }

        var listToSort = wordsDict.ToList();
        listToSort.Sort((b, a) => a.Value.CompareTo(b.Value));

        int maxWords = 5;

        if (listToSort.Count < 5) { maxWords = listToSort.Count; }
        ;

        var sortedListWords = listToSort.Select(o => o.Key).ToList();

        for (int listIndex = 0; listIndex < maxWords; listIndex++)
        {
            if (listIndex != 4) { output += $@"""{sortedListWords[listIndex]}"", "; }
            else { output += $@"""{sortedListWords[listIndex]}"""; }
        }
        return output;
    }

    private void Task6()
    {
        Console.WriteLine("6. Paprašykite vartotojo įvesti paieškos žodį ir atvaizduokite visus eilučių numerius ir eilutės turinį, kuriose yra paieškos žodis.");

        Console.Write("Įveskite paieškos žodį: ");
        string searchWord = Console.ReadLine();

        var filePath = "/home/jum/git_projects/TECHIN/dotnet/5.2.Failai/notes.txt";

        var options = new FileStreamOptions
        {
            Mode = FileMode.OpenOrCreate,
        };

        using (var reader = new StreamReader(filePath, options))
        {
            var lineNumber = 0;
            while (!reader.EndOfStream)
            {
                lineNumber++;
                var line = reader.ReadLine();
                if (line != null && line.Contains(searchWord))
                {
                    Console.WriteLine($"{lineNumber} {line}");
                }
            }
        }

    }

    private void Task7()
    {
        Console.WriteLine("7. Faile išsaugotas darbuotojų sąrašas. Kiekvienoje eilutėje yra darbuotojo vardas ir pavardė. Parašykite programą kuti nuskaitys failą, pakeis vardą ir pavardę į inicialus (pvz.J.J.) ir rezultatą išsaugos į naują failą.");

        List<string> initialList = new List<string>();
        var filePath = "/home/jum/git_projects/TECHIN/dotnet/5.2.Failai/names.txt";
        var fileOutputPath = "/home/jum/git_projects/TECHIN/dotnet/5.2.Failai/initials.txt";

        var options = new FileStreamOptions
        {
            Mode = FileMode.OpenOrCreate,
        };

        using (var reader = new StreamReader(filePath, options))
        {
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                if (line != null)
                {
                    string initials = "";
                    string[] words = line.Split(" ");
                    for (int word = 0; word < words.Length; word++)
                    {
                        initials += $"{words[word][0]}. ";
                    }
                    initialList.Add(initials);
                }
            }
        }

        using var writer = new StreamWriter(fileOutputPath, true);
        {
            for (int index = 0; index < initialList.Count; index++)
            {
                writer.WriteLine(initialList[index]);
            }
        }
        ;

    }

    private void Task8()
    {
        Console.WriteLine("8. Nuskaitykite tekstinį failą naudodami StreamReader. Užšifruokite jo turinį naudodami paprastą Cezario šifrą (pastumkite kivkeiną simbolį per N pozicijų) ir išsaugokite rezultatą į naują failą naudodami StramWriter. Pridėkite ir dešifravimo metodą.");
        char[] abc = { 'a', 'ą', 'b', 'c', 'č', 'd', 'e', 'ę', 'ė', 'f', 'g', 'h', 'i', 'į', 'y', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'r', 's', 'š', 't', 'u', 'ų', 'ū', 'v', 'z', 'ž' };

        int charShift = 5;
        var filePath = "/home/jum/git_projects/TECHIN/dotnet/5.2.Failai/names.txt";
        var fileOutputPath = "/home/jum/git_projects/TECHIN/dotnet/5.2.Failai/names_cyphered.txt";
        var fileOutputPath2 = "/home/jum/git_projects/TECHIN/dotnet/5.2.Failai/names_decyphered.txt";

        CypherFile(filePath, fileOutputPath, abc, charShift);
        DecypherFile(fileOutputPath, fileOutputPath2, abc, charShift);

    }

    private void CypherFile(string filePath, string fileOutputPath, char[] abc, int charShift)
    {
        var options = new FileStreamOptions
        {
            Mode = FileMode.OpenOrCreate,
        };

        using (var reader = new StreamReader(filePath, options))
        {
            while (!reader.EndOfStream)
            {
                using var writer = new StreamWriter(fileOutputPath, true);
                {
                    var line = reader.ReadLine();
                    if (line != null)
                    {
                        string outputLine = "";
                        for (int symbolIndex = 0; symbolIndex < line.Length; symbolIndex++)
                        {
                            var character = line[symbolIndex];
                            if (abc.Contains(character))
                            {
                                character = CypherCharacter(character, charShift, abc);
                            }
                            outputLine += character;
                        }
                        writer.WriteLine(outputLine);
                    }
                }

            }
        }
    }

    private void DecypherFile(string filePath, string fileOutputPath, char[] abc, int charShift)
    {
        var options = new FileStreamOptions
        {
            Mode = FileMode.OpenOrCreate,
        };

        using (var reader = new StreamReader(filePath, options))
        {
            while (!reader.EndOfStream)
            {
                using var writer = new StreamWriter(fileOutputPath, true);
                {
                    var line = reader.ReadLine();
                    if (line != null)
                    {
                        string outputLine = "";
                        for (int symbolIndex = 0; symbolIndex < line.Length; symbolIndex++)
                        {
                            var character = line[symbolIndex];
                            if (abc.Contains(character))
                            {
                                character = DecypherCharacter(character, charShift, abc);
                            }
                            outputLine += character;
                        }

                        writer.WriteLine(outputLine);
                    }
                }

            }
        }
    }
    private char CypherCharacter(char character, int shiftAmount, char[] abc)
    {
        var inputChatIndex = abc.IndexOf(character);
        int outputCharIndex = inputChatIndex + shiftAmount;
        if (outputCharIndex > abc.Length - 1) { outputCharIndex -= abc.Length; }
        ;

        return abc[outputCharIndex];
    }

    private char DecypherCharacter(char character, int shiftAmount, char[] abc)
    {
        var inputChatIndex = abc.IndexOf(character);
        int outputCharIndex = inputChatIndex - shiftAmount;
        if (outputCharIndex < 0) { outputCharIndex += abc.Length; }
    ;

        return abc[outputCharIndex];
    }

}
