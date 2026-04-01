public class OrderPerson
{
    public List<Person> SortAgeDesc(List<Person> personList)
    {
        return personList.OrderByDescending(o => o.Age).ToList();
    }

    public List<Person> SortPersonsBySelection(List<Person> personList)
    {
        var mc = new Tasks();
        var option = mc.UserInputOption("Pasirinkite pagal kokią savybę norit rikiuoti duomenis:");
        var userOptAsc = mc.UserInputSortOrder();

        return SortList(personList, option, userOptAsc);
    }

    private List<Person> SortList(List<Person> personList, int searchOption, int ascDesc)
    {
        List<Person> sortedList = new List<Person>();
        switch (searchOption)
        {
            case 1:
                if (ascDesc == 2) sortedList = personList.OrderByDescending(o => o.FirstName).ToList();
                else sortedList = personList.OrderBy(o => o.FirstName).ToList();
                break;
            case 2:
                if (ascDesc == 2) sortedList = personList.OrderByDescending(o => o.LastName).ToList();
                else sortedList = personList.OrderBy(o => o.LastName).ToList();
                break;
            case 3:
                if (ascDesc == 2) sortedList = personList.OrderByDescending(o => o.Age).ToList();
                else sortedList = personList.OrderBy(o => o.Age).ToList();
                break;
            case 4:
                if (ascDesc == 2) sortedList = personList.OrderByDescending(o => o.City).ToList();
                else sortedList = personList.OrderBy(o => o.City).ToList();
                break;
        }
        return sortedList;
    }
}