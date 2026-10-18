namespace csharp_homework6;

public class Address
{
    public string City { get; private set; } = string.Empty;
    public string Street { get; private set; } = string.Empty;
    public string PostalCode { get; private set; } = string.Empty;

    public Address() {}
    public Address(string city, string street, string postalCode)
    {
        if (string.IsNullOrWhiteSpace(city))
            throw new ArgumentException("City cannot be null or empty", nameof(city));
        if (string.IsNullOrWhiteSpace(street))
            throw new ArgumentException("Street cannot be null or empty", nameof(street));
        if (string.IsNullOrWhiteSpace(postalCode))
            throw new ArgumentException("Postal code cannot be null or empty", nameof(postalCode));
        
        City = city;
        Street = street;
        PostalCode = postalCode;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"City: {City}");
        Console.WriteLine($"Street: {Street}");
        Console.WriteLine($"Postal Code: {PostalCode}");
    }
}