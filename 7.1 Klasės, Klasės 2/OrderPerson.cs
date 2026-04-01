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

    private List<Person> SortList(List<Person> personList, List<int> selectedSortOptions, int ascDesc)
    {
        var optionsList = Person.GetPropertyList();
        switch (ascDesc)
        {
            case 2:
                switch (selectedSortOptions.Count)
                {
                    case 2:
                        return SortListDescOpt(personList, optionsList, selectedSortOptions[0], selectedSortOptions[1]);
                    case 3:
                        return SortListDescOpt(personList, optionsList, selectedSortOptions[0], selectedSortOptions[1], selectedSortOptions[2]);
                    case 4:
                        return SortListDescOpt(personList, optionsList, selectedSortOptions[0], selectedSortOptions[1], selectedSortOptions[2], selectedSortOptions[3]);
                    default:
                        return personList.OrderByDescending(o => o.GetType().GetProperty(optionsList[selectedSortOptions[0]]).GetValue(o)).ToList();
                }
            default:
                switch (selectedSortOptions.Count)
                {
                    case 2:
                        return SortListAscOpt(personList, optionsList, selectedSortOptions[0], selectedSortOptions[1]);
                    case 3:
                        return SortListAscOpt(personList, optionsList, selectedSortOptions[0], selectedSortOptions[1], selectedSortOptions[2]);
                    case 4:
                        return SortListAscOpt(personList, optionsList, selectedSortOptions[0], selectedSortOptions[1], selectedSortOptions[2], selectedSortOptions[3]);
                    default:
                        return personList.OrderByDescending(o => o.GetType().GetProperty(optionsList[selectedSortOptions[0]]).GetValue(o)).ToList();
                }
        }
    }


    private List<Person> SortListAscOpt(List<Person> personList, SortedDictionary<int, string> optionsList, int opt0, int opt1, int opt2, int opt3)
    {
        return personList.OrderBy(o => o.GetType().GetProperty(optionsList[opt0]))
            .ThenBy(o => o.GetType().GetProperty(optionsList[opt1]).GetValue(o))
            .ThenBy(o => o.GetType().GetProperty(optionsList[opt2]).GetValue(o))
            .ThenBy(o => o.GetType().GetProperty(optionsList[opt3]).GetValue(o))
            .ToList();
    }
    private List<Person> SortListAscOpt(List<Person> personList, SortedDictionary<int, string> optionsList, int opt0, int opt1, int opt2)
    {
        return personList.OrderBy(o => o.GetType().GetProperty(optionsList[opt0]).GetValue(o))
            .ThenBy(o => o.GetType().GetProperty(optionsList[opt1]).GetValue(o))
            .ThenBy(o => o.GetType().GetProperty(optionsList[opt2]).GetValue(o))
            .ToList();
    }
    private List<Person> SortListAscOpt(List<Person> personList, SortedDictionary<int, string> optionsList, int opt0, int opt1)
    {
        return personList.OrderBy(o => o.GetType().GetProperty(optionsList[opt0]).GetValue(o))
            .ThenBy(o => o.GetType().GetProperty(optionsList[opt1]).GetValue(o))
            .ToList();
    }
    private List<Person> SortListDescOpt(List<Person> personList, SortedDictionary<int, string> optionsList, int opt0, int opt1, int opt2, int opt3)
    {
        return personList.OrderByDescending(o => o.GetType().GetProperty(optionsList[opt0]))
            .ThenBy(o => o.GetType().GetProperty(optionsList[opt1]).GetValue(o))
            .ThenBy(o => o.GetType().GetProperty(optionsList[opt2]).GetValue(o))
            .ThenBy(o => o.GetType().GetProperty(optionsList[opt3]).GetValue(o))
            .ToList();
    }
    private List<Person> SortListDescOpt(List<Person> personList, SortedDictionary<int, string> optionsList, int opt0, int opt1, int opt2)
    {
        return personList.OrderByDescending(o => o.GetType().GetProperty(optionsList[opt0]))
            .ThenBy(o => o.GetType().GetProperty(optionsList[opt1]).GetValue(o))
            .ThenBy(o => o.GetType().GetProperty(optionsList[opt2]).GetValue(o))
            .ToList();
    }
    private List<Person> SortListDescOpt(List<Person> personList, SortedDictionary<int, string> optionsList, int opt0, int opt1)
    {
        return personList.OrderByDescending(o => o.GetType().GetProperty(optionsList[opt0]).GetValue(o))
            .ThenBy(o => o.GetType().GetProperty(optionsList[opt1]).GetValue(o))
            .ToList();
    }
}