Console.WriteLine("1.");
string s = "aba aba aba aba baba";
while (s.Contains("aba"))
{
    int index = s.LastIndexOf("aba");
    Console.WriteLine(s.Substring(index, 3));
    s = s.Substring(0, index);
}
;

static string StringMax15(string input)
{
    string output;
    if (input.Length > 15)
    {
        output = $"{input.Substring(0, 12)}...";
    }
    else output = input;
    return output;
}

Console.WriteLine("2.");
Console.WriteLine(StringMax15("aaabbbcccddd123"));
Console.WriteLine(StringMax15("aaabbbcccddd123456"));


Console.WriteLine("3.");
string[] nameAgeHeightArr = { "Mantas,29,198", "Tomas,26,176" };
int arrayLength = nameAgeHeightArr.Length;
string[] nameArr = new string[arrayLength];
int[] ageArr = new int[arrayLength];
int[] heightArr = new int[arrayLength];

for (int n = 0; n < arrayLength; n++)
{
    string[] split = nameAgeHeightArr[n].Split(",");
    nameArr[n] = split[0];
    if (Int32.TryParse(split[1], out int age))
    {
        ageArr[n] = age;
    }
    if (Int32.TryParse(split[2], out int height)) { heightArr[n] = height; }
    ;


    Console.WriteLine($"Vardas: {nameArr[n]}, amžius: {ageArr[n]}, ūgis: {heightArr[n]}");
}

