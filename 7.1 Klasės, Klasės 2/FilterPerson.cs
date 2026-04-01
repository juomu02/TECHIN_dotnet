public class FilterPerson
{
    public List<Person> FilterPersonListByCity(List<Person> personList)
    {
        var mc = new Tasks();
        string searchCity = mc.UserInputCity();
        return personList.Where(o => o.City == searchCity).ToList();
    }

    public List<Person> FilterPersonsBySelection(List<Person> personList)
    {

        var searchOptions = Person.GetPropertyList();
        var mc = new Tasks();
        var searchOption = mc.UserInputOption("Pasirinkite pagal kokią savybę norit filtruoti duomenis:", searchOptions);
        var userSearchphrase = mc.UserInputSearchWord();
        return SearchList(personList, searchOption, userSearchphrase);

    }

    private List<Person> SearchList(List<Person> personList, int searchOption, string searchPhrase)
    {
        var filteredList = new List<Person>();

        Console.WriteLine("Rasti įrašai:");

        switch (searchOption)
        {
            case 1:
                filteredList = personList.Where(o => o.FirstName == searchPhrase).ToList();
                break;
            case 2:
                filteredList = personList.Where(o => o.LastName == searchPhrase).ToList();
                break;
            case 3:
                if (int.TryParse(searchPhrase, out int searchAge))
                {
                    filteredList = personList.Where(o => o.Age == searchAge).ToList();
                }
                else { Console.WriteLine("Pasirinkus Age, paieškai turite naudoti skaičių."); }
                ;
                break;
            case 4:
                filteredList = personList.Where(o => o.City == searchPhrase).ToList();
                break;
        }
        return filteredList;
    }

}