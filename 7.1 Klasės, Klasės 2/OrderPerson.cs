
public class OrderPerson
{
    public List<Person> SortAgeDesc(List<Person> personList)
    {
        return personList.OrderByDescending(o => o.Age).ToList();
    }

    public List<Person> SortPersonsBySelection(List<Person> personList)
    {
        var mc = new Tasks();
        var sortOptions = Person.GetPropertyList();
        List<int> selectedOptions = new List<int>();
        var option = mc.UserInputOption("Pasirinkite pagal kokią savybę norit rikiuoti duomenis:", sortOptions);
        selectedOptions.Add(option);
        sortOptions.Remove(option);
        var userOptAsc = mc.UserInputSortOrder();
        var maxAddOptions = sortOptions.Count;
        sortOptions.Add(0, "Papildomų savybių užtenka");
        for (int i = 0; i < maxAddOptions; i++)
        {
            var additionalOption = mc.UserInputOption("Pasirinkite papildomą savybę, pagal kurią norit rikiuoti duomenis:", sortOptions);
            if (additionalOption == 0) break;

            selectedOptions.Add(additionalOption);
            sortOptions.Remove(additionalOption);
        }
        return SortList(personList, selectedOptions, userOptAsc);
    }
    public void PrintSortMessage(SortedDictionary<int, string> optionsList, List<int> selectedSortOptions, int ascDesc)
    {
        var sortOrder = ascDesc == 2 ? "Deschending" : "Aschending";
        Console.Write($"Pasirinkti rikiavimo parametrai: {optionsList[selectedSortOptions[0]]}({sortOrder}); ");
        for (int index = 1; index < selectedSortOptions.Count; index++)
        {
            Console.Write($"{optionsList[selectedSortOptions[index]]}; ");
        }
        Console.WriteLine();
    }
    private List<Person> SortList(List<Person> personList, List<int> selectedSortOptions, int ascDesc)
    {
        var optionsList = Person.GetPropertyList();
        PrintSortMessage(optionsList, selectedSortOptions, ascDesc);

        switch (ascDesc)
        {
            case 2:
                return personList.OrderByDescending(o => o.GetType()
                    .GetProperty(optionsList[selectedSortOptions[0]])
                    .GetValue(o))
                        .ThenBy(o =>
                        {
                            if (selectedSortOptions.Count > 1)
                            {
                                return o.GetType().GetProperty(optionsList[selectedSortOptions[1]])
                                .GetValue(o);
                            }
                            else return o;
                        }
                                )
                        .ThenBy(o =>
                        {
                            if (selectedSortOptions.Count > 2)
                            {
                                return o.GetType().GetProperty(optionsList[selectedSortOptions[2]])
                                .GetValue(o);
                            }
                            else return o;
                        }
                                )
                        .ThenBy(o =>
                        {
                            if (selectedSortOptions.Count > 3)
                            {
                                return o.GetType().GetProperty(optionsList[selectedSortOptions[3]])
                                .GetValue(o);
                            }
                            else return o;
                        }
                                )
                        .ToList();
            default:
                return personList.OrderBy(o => o.GetType()
                    .GetProperty(optionsList[selectedSortOptions[0]])
                    .GetValue(o))
                        .ThenBy(o =>
                        {
                            if (selectedSortOptions.Count > 1)
                            {
                                return o.GetType().GetProperty(optionsList[selectedSortOptions[1]])
                                .GetValue(o);
                            }
                            else return o;
                        }
                                )
                        .ThenBy(o =>
                        {
                            if (selectedSortOptions.Count > 2)
                            {
                                return o.GetType().GetProperty(optionsList[selectedSortOptions[2]])
                                .GetValue(o);
                            }
                            else return o;
                        }
                                )
                        .ThenBy(o =>
                        {
                            if (selectedSortOptions.Count > 3)
                            {
                                return o.GetType().GetProperty(optionsList[selectedSortOptions[3]])
                                .GetValue(o);
                            }
                            else return o;
                        }
                                )
                        .ToList();
        }
    }
}