namespace csharp_homework6;

public class Student
{
    public string FullName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public int StudentCardNumber { get; private set; } = 0;
    
    public Student() {}
    public Student(string fullName, string email, string phone, int studentCardNumber)
    {
        if (string.IsNullOrWhiteSpace(fullName))
            throw new ArgumentException("Full Name can't be null or empty");
        if (string.IsNullOrWhiteSpace(email))
            throw new ArgumentException("Email can't be null or empty");
        if (string.IsNullOrWhiteSpace(phone))
            throw new ArgumentException("Phone can't be null or empty");
        if (studentCardNumber <= 0)
            throw new ArgumentException("Student Card Number can't be 0");
        
        FullName = fullName;
        Email = email;
        Phone = phone;
        StudentCardNumber = studentCardNumber;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Full Name: {FullName}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"Phone: {Phone}");
        Console.WriteLine($"Student Card Number: {StudentCardNumber}\n");
    }
}