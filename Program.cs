namespace csharp_homework6;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Student student1 = new Student("Test One", "email1@gmail.com", "+38 011 223 33 44", 1011);
            Student student2 = new Student("Test Two", "email2@gmail.com", "+38 011 223 33 44", 1012);
            Student student3 = new Student("Test Three", "email3@gmail.com", "+38 011 223 33 44", 1013);
            
            student1.DisplayInfo();
            student2.DisplayInfo();

            Teacher teacher1 = new Teacher("Teacher One", "email1@gmail.com", "+38 011 223 33 44");
            Teacher teacher2 = new Teacher("Teacher Two", "email2@gmail.com", "+38 011 223 33 44");
            
            teacher1.DisplayInfo();
            
            University university = new University("IT STEP", "Odesa", "Sadova 3", "6767");
            university.DisplayInfo();
            university.AddTeacher(teacher1);
            university.AddTeacher(teacher2);
            university.DisplayInfo();
            university.DisplayTeachers();
            
            Course csharpCourse = new Course("C#", new List<string>{"OOP", "Exceptions"});
            Course mathCourse = new Course("High Math", new List<string>{"Algebra", "Geometry"});
            Console.WriteLine($"[AMOUNT OF COURSES]: {Course.TotalCoursesCreated}\n");
            
            csharpCourse.AddStudent(student1);
            csharpCourse.AddStudent(student2);
            mathCourse.AddStudent(student1);
            csharpCourse.DisplayStudents();
            mathCourse.DisplayStudents();

            csharpCourse.RemoveStudent(student1);
            csharpCourse.DisplayStudents();
        }
        catch (Exception e)
        {
            Console.WriteLine($"ERROR: [{e.Message}]");
        }
    }
}