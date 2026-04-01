public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; }
    public string City { get; set; }
    public DateTime Bitrhtday { get; set; }
    public Person(string firstName, string lastName, DateTime bitrhtday, string city)
    {
        FirstName = firstName;
        LastName = lastName;
        City = city;
        Bitrhtday = bitrhtday;
        Age = DateTime.Now.Year - Bitrhtday.Year;
    }
    public static SortedDictionary<int, string> GetPropertyList()
    {
        return new SortedDictionary<int, string> {
            { 1, "FirstName" },
            { 2, "LastName" },
            { 3, "Age" },
            { 4, "City" }
            };
    }
}
