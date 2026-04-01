// public class OrderPerson
// {
//     public List<Person> SortAgeDesc(List<Person> personList)
//     {
//         return personList.OrderByDescending(o => o.Age).ToList();
//     }

//     public List<Person> SortPersonsBySelection(List<Person> personList)
//     {
//         var mc = new Tasks();
//         var sortOptions = Person.GetPropertyList();
//         List<int> selectedOptions = new List<int>();
//         var option = mc.UserInputOption("Pasirinkite pagal kokią savybę norit rikiuoti duomenis:", sortOptions);
//         selectedOptions.Add(option);
//         sortOptions.Remove(option);
//         var userOptAsc = mc.UserInputSortOrder();
//         var maxAddOptions = sortOptions.Count;
//         sortOptions.Add(0, "Papildomų savybių užtenka");
//         for (int i = 0; i < maxAddOptions; i++)
//         {
//             var additionalOption = mc.UserInputOption("Pasirinkite papildomą savybę, pagal kurią norit rikiuoti duomenis:", sortOptions);
//             if (additionalOption == 0) break;

//             selectedOptions.Add(additionalOption);
//             sortOptions.Remove(additionalOption);
//         }

//         return SortList(personList, selectedOptions, userOptAsc);
//     }

//     private List<Person> SortList(List<Person> personList, List<int> selectedSortOptions, int ascDesc)
//     {
//         var optionsList = Person.GetPropertyList();
//         var tst1 = selectedSortOptions[0];
//         var tst2 = optionsList[tst1];
//         var tst3 = personList.GetType().GetProperty("City");
//         var test = personList.GetType().GetProperty(tst2).GetType();
//         switch (ascDesc)
//         {
//             case 2:
//                 switch (selectedSortOptions.Count)
//                 {
//                     case 2:
//                         return SortListAscOpt(personList, optionsList, selectedSortOptions[0], selectedSortOptions[1]);
//                     case 3:
//                         return SortListAscOpt(personList, optionsList, selectedSortOptions[0], selectedSortOptions[1], selectedSortOptions[2]);
//                     case 4:
//                         return SortListAscOpt(personList, optionsList, selectedSortOptions[0], selectedSortOptions[1], selectedSortOptions[2], selectedSortOptions[3]);
//                     default:
//                         return personList.OrderByDescending(o => o.GetType().GetProperty(optionsList[selectedSortOptions[0]])).ToList();
//                 }
//             default:
//                 switch (selectedSortOptions.Count)
//                 {
//                     case 2:
//                         return SortListAscOpt(personList, optionsList, selectedSortOptions[0], selectedSortOptions[1]);
//                     case 3:
//                         return SortListAscOpt(personList, optionsList, selectedSortOptions[0], selectedSortOptions[1], selectedSortOptions[2]);
//                     case 4:
//                         return SortListAscOpt(personList, optionsList, selectedSortOptions[0], selectedSortOptions[1], selectedSortOptions[2], selectedSortOptions[3]);
//                     default:
//                         return personList.OrderByDescending(o => o.GetType().GetProperty(optionsList[selectedSortOptions[0]])).ToList();
//                 }
//         }
//     }


//     private List<Person> SortListAscOpt(List<Person> personList, SortedDictionary<int, string> optionsList, int opt0, int opt1, int opt2, int opt3)
//     {
//         List<Person> sortedList = new List<Person>();
//         sortedList = personList.OrderBy(o => o.GetType().GetProperty(optionsList[opt0]))
//             .ThenBy(o => o.GetType().GetProperty(optionsList[opt1]))
//             .ThenBy(o => o.GetType().GetProperty(optionsList[opt2]))
//             .ThenBy(o => o.GetType().GetProperty(optionsList[opt3]))
//             .ToList();
//         return sortedList;
//     }
//     private List<Person> SortListAscOpt(List<Person> personList, SortedDictionary<int, string> optionsList, int opt0, int opt1, int opt2)
//     {
//         List<Person> sortedList = new List<Person>();
//         sortedList = personList.OrderBy(o => o.GetType().GetProperty(optionsList[opt0]))
//             .ThenBy(o => o.GetType().GetProperty(optionsList[opt1]))
//             .ThenBy(o => o.GetType().GetProperty(optionsList[opt2]))
//             .ToList();
//         return sortedList;
//     }
//     private List<Person> SortListAscOpt(List<Person> personList, SortedDictionary<int, string> optionsList, int opt0, int opt1)
//     {
//         return personList.OrderBy(o => o.GetType().GetProperty(optionsList[opt0]))
//             .ThenBy(o => o.GetType().GetProperty(optionsList[opt1]))
//             .ToList();
//     }
//     private List<Person> SortListDescOpt(List<Person> personList, SortedDictionary<int, string> optionsList, int opt0, int opt1, int opt2, int opt3)
//     {
//         return personList.OrderByDescending(o => o.GetType().GetProperty(optionsList[opt0]))
//             .ThenBy(o => o.GetType().GetProperty(optionsList[opt1]))
//             .ThenBy(o => o.GetType().GetProperty(optionsList[opt2]))
//             .ThenBy(o => o.GetType().GetProperty(optionsList[opt3]))
//             .ToList();
//     }
//     private List<Person> SortListDescOpt(List<Person> personList, SortedDictionary<int, string> optionsList, int opt0, int opt1, int opt2)
//     {
//         return personList.OrderByDescending(o => o.GetType().GetProperty(optionsList[opt0]))
//             .ThenBy(o => o.GetType().GetProperty(optionsList[opt1]))
//             .ThenBy(o => o.GetType().GetProperty(optionsList[opt2]))
//             .ToList();
//     }
//     private List<Person> SortListDescOpt(List<Person> personList, SortedDictionary<int, string> optionsList, int opt0, int opt1)
//     {
//         return personList.OrderByDescending(o => o.GetType().GetProperty(optionsList[opt0]))
//             .ThenBy(o => o.GetType().GetProperty(optionsList[opt1]))
//             .ToList();
//     }
// }