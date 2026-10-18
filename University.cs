namespace csharp_homework6;

public class University
{
    public string Name { get; private set; } =  string.Empty;
    public Address UniAddress{get; private set;} = new();
    public List<Teacher> Teachers { get; private set; } = new();

    public University() {}
    public University(string name, string city, string street, string postalCode)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Name cannot be empty", nameof(name));
        Name = name;
        UniAddress = new Address(city, street, postalCode);
        Teachers = new List<Teacher>();
    }
    public void AddTeacher(Teacher teacher)
    {
        if (teacher == null)
            throw new ArgumentNullException(nameof(teacher));

        if (!Teachers.Contains(teacher))
        {
            Teachers.Add(teacher);
            Console.WriteLine($"Teacher {teacher.FullName} has been added");
        }
        else
        {
            Console.WriteLine($"Teacher {teacher.FullName} has already been added");
        }
    }

    public void DisplayTeachers()
    {
        Console.WriteLine($"--- The List Of The Teachers In The University {Name} ---");
        if (Teachers.Count == 0)
        {
            Console.WriteLine($"No Teachers found");
            return;
        }
        foreach (var teacher in Teachers)
            teacher.DisplayInfo();
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"University: {Name}");
        UniAddress.DisplayInfo();
        Console.WriteLine($"Number Of Teachers: {Teachers.Count}");
    }
}