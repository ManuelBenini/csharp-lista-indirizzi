StreamReader addressFile = File.OpenText("addresses.csv");
List<Address> addressesList = new List<Address>();

addressFile.ReadLine();

while (!addressFile.EndOfStream)
{
    string row = addressFile.ReadLine();

    string[] split = row.Split(',');

    try
    {
        string name = split[0];
        string surname = split[1];

        string street;
        string city = split[3];
        string province = split[4];
        string zip = split[5];
        bool containsInt = split[2].Any(char.IsDigit);
        if (!containsInt)
        {
            street = split[3];
            city = split[4];
            province = split[5];
            zip = split[6];
        }
        else
        {
            street = split[2];
        }
        
        
        Address address = new Address(street,city,province,zip, new User(name, surname) );
        addressesList.Add(address);
        Console.WriteLine($"Indirizzo {street} importato correttamente");

    }
    catch (Exception e)
    {
        Console.WriteLine("Indirizzo non valido, mancano dei parametri necessari -->" + row);
        //Console.WriteLine(e.Message);
    }


}

addressFile.Close();

foreach (Address address in addressesList)
{
    address.PrintAddress();
}