using System;

class Student
{
    public string Name;
    public double Grade1;
    public double Grade2;
    public double Grade3;

    public double Average()
    {
        return (Grade1 + Grade2 + Grade3) / 3;
    }
}

class Program
{
    static Student[] students = new Student[100];
    static int studentCount = 0;

    static void Main()
    {
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("===== STUDENT SYSTEM =====");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. View All Students");
            Console.WriteLine("3. Compute Average Grade");
            Console.WriteLine("4. Find Highest Grade");
            Console.WriteLine("5. Exit");
            Console.WriteLine("==========================");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddStudent();
                    break;

                case "2":
                    ViewStudents();
                    break;

                case "3":
                    ComputeClassAverage();
                    break;

                case "4":
                    FindHighestGrade();
                    break;

                case "5":
                    Console.WriteLine("Exiting program...");
                    Console.WriteLine("Goodbye!");
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

            if (running)
            {
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }
        }
    }

    static void AddStudent()
    {
        if (studentCount >= students.Length)
        {
            Console.WriteLine("Student list is full.");
            return;
        }

        Student student = new Student();

        Console.Write("Enter student name: ");
        student.Name = Console.ReadLine();

        // Safe input for Grade 1
        Console.Write("Enter grade 1: ");
        while (!double.TryParse(Console.ReadLine(), out student.Grade1))
        {
            Console.Write("Invalid input! Enter grade 1 again: ");
        }

        // Safe input for Grade 2
        Console.Write("Enter grade 2: ");
        while (!double.TryParse(Console.ReadLine(), out student.Grade2))
        {
            Console.Write("Invalid input! Enter grade 2 again: ");
        }

        // Safe input for Grade 3
        Console.Write("Enter grade 3: ");
        while (!double.TryParse(Console.ReadLine(), out student.Grade3))
        {
            Console.Write("Invalid input! Enter grade 3 again: ");
        }

        students[studentCount] = student;
        studentCount++;

        Console.WriteLine("Student added successfully!");
    }

    static void ViewStudents()
    {
        if (studentCount == 0)
        {
            Console.WriteLine("No students found.");
            return;
        }

        for (int i = 0; i < studentCount; i++)
        {
            Console.WriteLine("\nName: " + students[i].Name);
            Console.WriteLine("Grades: " +
                              students[i].Grade1 + ", " +
                              students[i].Grade2 + ", " +
                              students[i].Grade3);
            Console.WriteLine("Average: " +
                              students[i].Average().ToString("F2"));
        }
    }

    static void ComputeClassAverage()
    {
        if (studentCount == 0)
        {
            Console.WriteLine("No students found.");
            return;
        }

        double total = 0;

        for (int i = 0; i < studentCount; i++)
        {
            total += students[i].Average();
        }

        double classAverage = total / studentCount;

        Console.WriteLine("===== CLASS AVERAGE =====");
        Console.WriteLine("Overall Average Grade: " +
                          classAverage.ToString("F2"));
    }

    static void FindHighestGrade()
    {
        if (studentCount == 0)
        {
            Console.WriteLine("No students found.");
            return;
        }

        Student topStudent = students[0];

        for (int i = 1; i < studentCount; i++)
        {
            if (students[i].Average() > topStudent.Average())
            {
                topStudent = students[i];
            }
        }

        Console.WriteLine("===== HIGHEST GRADE =====");
        Console.WriteLine("Top Student: " + topStudent.Name);
        Console.WriteLine("Highest Grade: " +
                          topStudent.Average().ToString("F2"));
    }
}