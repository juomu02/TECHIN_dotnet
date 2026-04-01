public class Person
{
    public string FirstName;
    public string LastName;
    public int Age;
    public string City;
    public DateTime Bitrhtday;
    public Person(string firstName, string lastName, DateTime bitrhtday, string city)
    {
        FirstName = firstName;
        LastName = lastName;
        City = city;
        Bitrhtday = bitrhtday;
        Age = DateTime.Now.Year - Bitrhtday.Year;
    }    
}
