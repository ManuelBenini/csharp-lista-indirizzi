// See https://aka.ms/new-console-template for more information
public class Address
{
    public string Street { get; set; }
    public string City { get; set; }
    public string Province { get; set; }
    public string Zip { get; set; }
    public User User { get; set; }

    public Address(string street, string city, string province, string zip, User user)
    {
        Street = street;
        City = city;
        Province = province;
        Zip = zip;
        User = user;
    }

    public void PrintAddress()
    {
        Console.WriteLine("--------------------------");
        Console.WriteLine($"Name: {User.Name}");
        Console.WriteLine($"Surname: {User.Surname}");
        Console.WriteLine($"Street: {Street}");
        Console.WriteLine($"City: {City}");
        Console.WriteLine($"Province: {Province}");
        Console.WriteLine($"ZIP: {Zip}");
    }
}
