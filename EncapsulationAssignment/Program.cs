using EncapsulationAssignment;

Console.WriteLine("Student Grade Management System");
Console.WriteLine("Press Any Key To Begin...");

Console.ReadLine();
bool running = true;
List<Student> students = new List<Student>();

while (running)
{
    Console.WriteLine("\tEnter a command... (or type 'help')");
    string? command = Console.ReadLine();
    if (command != null)
    {
        switch (command)
        {
            case "AddStudent":
                Console.WriteLine("\tEnter Student's Name:");
                string? studentName = Console.ReadLine();
                Console.WriteLine("\tEnter Student's Program:");
                string? studentProgram = Console.ReadLine();
                Console.WriteLine("\tEnter a Student ID number:");
                string? studentID = Console.ReadLine();
                if(studentName != null && studentProgram != null)
                {
                    students.Add(new Student(studentName, studentProgram, studentID));
                }
                else
                {
                    Console.WriteLine("\tBoth Student Name and Student Program must be entered.");
                }
                    break;
            case "AddAssignment":
                Console.WriteLine("\tEnter Student's Name:");
                string? student = Console.ReadLine();
                if(student != null)
                {
                    foreach (Student s in students)
                    {
                        if(s.name == student)
                        {
                            Console.WriteLine("\tEnter Assignment's Name:");
                            string? aname = Console.ReadLine();
                            if (aname != null) {
                                Console.WriteLine("\tEnter Assignment's Grade (number only, 1-100):");
                                string? agrade = Console.ReadLine();
                                if(agrade != null)
                                {
                                    int grade = Int32.Parse(agrade);
                                    s.GradeAssignment(aname, grade);
                                    break;
                                }
                            }

                        }
                    }

                }
                break;
            case "GetStudentGrade":
                Console.WriteLine("\tEnter Student's Name:");
                string? stdnt = Console.ReadLine();
                if(stdnt != null)
                {
                    foreach (Student s in students)
                    {
                        if(s.name == stdnt)
                        {
                            Console.WriteLine("\t"+s.name + " Current Grade: " + s.GetGrade());
                            break;
                        }
                    }
                }
                break;
            case "help":
                Console.WriteLine("\tCommands List:");
                Console.WriteLine("\tAddStudent (add a new student)");
                Console.WriteLine("\tAddAssignment (add a graded assignment for a student)");
                Console.WriteLine("\tGetStudentGrade (get the overall grade- averaged from graded assignments)");
                Console.WriteLine("\tExit (exit the program)");
                Console.ReadLine();
                break;
            case "Exit":
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("\tYou must enter a vald input.");
                break;
        }
    }
    else
    {
        continue;
    }
}