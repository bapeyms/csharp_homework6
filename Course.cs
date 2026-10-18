namespace csharp_homework6;

public class Course
{
    private static int _courseCounter = 0;
    public static int TotalCoursesCreated => _courseCounter;
    public string CourseName { get; set; } =  string.Empty;
    public List<string> Modules { get; private set; } = new();
    public List<Student> Students { get; private set; } = new();

    public Course()
    {
        _courseCounter++;
    }
    public Course(string courseName, List<string> modules)
    {
        if (string.IsNullOrWhiteSpace(courseName))
            throw new ArgumentException("Course name can't be null or empty");
        if (modules == null || modules.Count == 0)
            throw new ArgumentException("Modules can't be null or empty");
        
        CourseName = courseName;
        Modules = new List<string>(modules);
        Students = new List<Student>();
        
        _courseCounter++;
    }

    public void AddStudent(Student student)
    {
        if (student == null)
            throw new ArgumentNullException(nameof(student));
        if (Students.Any(s => s.StudentCardNumber == student.StudentCardNumber))
        {
            Console.WriteLine($"Student {student} has already been added");
            return;
        }
        Students.Add(student);
        Console.WriteLine($"Student {student} has been added");
    }

    public Student FindStudent(string studentCardNumber)
    {
        if (string.IsNullOrWhiteSpace(studentCardNumber))
            return null;

        if (int.TryParse(studentCardNumber, out int studentCardNumberInt))
        {
            return Students.FirstOrDefault(s => s.StudentCardNumber == studentCardNumberInt);
        }
        else
        {
            return Students.FirstOrDefault(s => s.FullName.Contains(studentCardNumber, StringComparison.OrdinalIgnoreCase));
        }
    }

    public void RemoveStudent(Student student)
    {
        if (student != null && Students.Contains(student))
        {
            Students.Remove(student);
            Console.WriteLine($"Student {student} has been removed");
        }
        else
        {
            Console.WriteLine($"Student {student} not found or has already been removed");
        }
    }

    public void DisplayStudents()
    {
        Console.WriteLine($"\n--- The List Of The Students On The Course {CourseName} ---");
        if (Students.Count == 0)
        {
            Console.WriteLine($"No Students found");
            return;
        }
        foreach (var student in Students)
            student.DisplayInfo();
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Course: {CourseName}");
        Console.WriteLine($"Modules: {Modules.Count}");
        Console.WriteLine($"Students: {Students.Count}");
    }
}