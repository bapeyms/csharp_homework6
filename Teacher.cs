namespace csharp_homework6;

public class Teacher
{
    public string FullName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    
    public Teacher() {}
    public Teacher(string fullName, string email, string phone)
    {
        if (string.IsNullOrWhiteSpace(fullName))
            throw new ArgumentException("Full Name can't be null or empty");
        if (string.IsNullOrWhiteSpace(email))
            throw new ArgumentException("Email can't be null or empty");
        if (string.IsNullOrWhiteSpace(phone))
            throw new ArgumentException("Phone can't be null or empty");

        FullName = fullName;
        Email = email;
        Phone = phone;
    }
    
    public void DisplayInfo()
    {
        Console.WriteLine($"Full Name: {FullName}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"Phone: {Phone}\n");
    }
}