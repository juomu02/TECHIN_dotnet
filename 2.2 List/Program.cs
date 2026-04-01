
using System.Collections.Immutable;
using System.Xml;

class Program
{
    public static void Main()
    {
        var mc = new Program();
        //1.
        mc.ExamResults();
    }

    //1.
    public void ExamResults()
    {
        Console.WriteLine("1. Užduotis");
        //Saugokite studentų pažymius List<int>.
        var newResultList = NewExamResultList();

        //Pridėkite/pašalinkite įrašus
        SaveExamResult(newResultList, 10);
        SaveExamResult(newResultList, 5);
        SaveExamResult(newResultList, 8);
        RemoveExamResult(newResultList, 1);
        SaveExamResult(newResultList, 5);

        //ir apskaičiuokite min, max ir vidurkį
        double[] statistics = ExamResultStatistics(newResultList);

        //  Rūšiuokite 
        newResultList.Sort();

        //  ir atvaizduokite rezultatus.
        Console.WriteLine(string.Join(", ", newResultList));
        Console.WriteLine($"min: {statistics[0]}, max: {statistics[1]}, avg: {statistics[2]}");
        Console.WriteLine();


        //2.Sugeneruokite List<int> sąrašą iš n (įvedama vartotojo) elementų su atsitiktiniais skaičiais nuo 1 iki 10.
        Console.WriteLine("2. Užduotis");
        Console.WriteLine("Įveskite elementų skaičių");
        int userInput = UserNumberInput();
        List<int> numbersList = NewNumbersList(userInput);

        //  Grąžinkite naują sąrašą, kuriame būtų tik tie elementai, kurie pasikartoja daugiau nei vieną kartą.
        List<int> doubleValuesList = FilterListDoubles(numbersList);

        //  Išspausdinkite pradinį sąrašą ir rezultatą į ekraną.
        Console.WriteLine("Pradinis sąrašas: ");
        Console.WriteLine(string.Join(", ", numbersList));
        Console.WriteLine("Rezultatas: ");
        Console.WriteLine(string.Join(", ", doubleValuesList));
        Console.WriteLine();


        //3.Raskite ilgiausią didėjančią seką List<int>, išsaugokite ją į naują sąrašą ir išspausdinkite jos elementus.
        Console.WriteLine("3. Užduotis");
        List<int> longestValueRow = FilterListDoubles(numbersList);
        longestValueRow.Sort();
        Console.WriteLine("Ilgiausia didėjanti seka: ");
        Console.WriteLine(string.Join(", ", longestValueRow));
        Console.WriteLine();

        //Taip ir nesugalvojau kur panaudoti LINQ. Gal galit pasiūlyti pavyzdį?
        Console.WriteLine("4. Užduotis");
        //4. Sugeneruokite List<int> sąrašą iš n (įvedama vartotojo) elementų su atsitiktiniais skaičiais nuo 1 iki 100. 
        Console.WriteLine("Įveskite elementų skaičių:");
        int userInput3 = UserNumberInput();
        List<int> numbersList3 = NewNumbersList(userInput3, 100);
        Console.WriteLine("Sugeneruoti skaičiai: ");
        Console.WriteLine(string.Join(", ", numbersList3));

        //Raskite visas unikalias poras skaičių, kurių suma lygi įvestam skaičiui.
        HashSet<string> pairsList = FindPairsEqualToInput(numbersList3, userInput3);
        Console.WriteLine("Unikalių skaičių poros: ");
        Console.WriteLine(string.Join("; \n", pairsList));
        Console.WriteLine();

    }

    private List<int> NewExamResultList()
    {
        List<int> examResults = new List<int>();
        return examResults;
    }

    private void SaveExamResult(List<int> examResults, int result)
    {
        examResults.Add(result);
    }

    private void RemoveExamResult(List<int> examResults, int index)
    {
        examResults.RemoveAt(index);
    }

    private double[] ExamResultStatistics(List<int> examResults)
    {
        double min = 10;
        double max = 0;
        double sum = 0;

        for (int n = 0; n < examResults.Count; n++)
        {
            if (min > examResults[n]) { min = examResults[n]; }
            ;
            if (max < examResults[n]) { max = examResults[n]; }
            ;
            sum += examResults[n];
        }

        double avg = Math.Round(sum / examResults.Count, 1);

        double[] result = { min, max, avg };

        return result;
    }

    private List<int> NewNumbersList(int input, int optionalint = 10)
    {
        List<int> output = new List<int>();
        Random randObj = new(input);

        for (int n = 0; n < input; n++)
        {
            output.Add(randObj.Next(0, optionalint));
        }

        return output;
    }

    private int UserNumberInput()
    {
        string userInput = Console.ReadLine();
        if (Int32.TryParse(userInput, out int input)) { return input; }
        else { Console.WriteLine("Įvedėte ne skaičių."); return 0; }
    }

    private List<int> FilterListDoubles(List<int> inputList)
    {
        List<int> output = new List<int>();
        HashSet<int> filterHash = new HashSet<int>();

        inputList.ForEach(delegate (int num) { filterHash.Add(num); });
        output = filterHash.ToList();

        return output;
    }

    private HashSet<string> FindPairsEqualToInput(List<int> inputList, int userInput)
    {
        HashSet<string> output = new HashSet<string>();


        inputList.ForEach(delegate (int listItem)
        {
            //pirmas variantas

            // int currentListItemIndex = 0;

            // for (int index = 0; index < inputList.Count; index++)
            // {
            //     //bandau išvengt kad tas pats vienas skaičius nesudarytų poros
            //     if (index != currentListItemIndex)
            //     {
            //         if (listItem + inputList[index] == userInput)
            //         {
            //             int a;
            //             int b;
            //             if (listItem < inputList[index])
            //             {
            //                 a = listItem;
            //                 b = inputList[index];
            //             }
            //             else
            //             {
            //                 a = inputList[index];
            //                 b = listItem;
            //             }
            //             string pair = $"{a}, {b}";
            //             output.Add(pair);
            //         }
            //     }
            // }


            if (inputList.Contains(userInput - listItem))
            {
                //bandau išvengt kad tas pats vienas skaičius nesudarytų poros
                if (!(inputList.IndexOf(listItem) == inputList.LastIndexOf(listItem)))
                {
                    int a;
                    int b;
                    if (listItem < userInput - listItem)
                    {
                        a = listItem;
                        b = userInput - listItem;
                    }
                    else
                    {
                        a = userInput - listItem;
                        b = listItem;
                    }
                    string pair = $"{a}, {b}";
                    output.Add(pair);
                }
            }
        });

        return output;
    }

}