using System;

public class Student
{
    private string name;
    private double grade1;
    private double grade2;
    private double grade3;

    private Student[] students = new Student[100];
    private int studentCount = 0;

    public Student(string studentName, double g1, double g2, double g3)
    {
        name = studentName;
        grade1 = g1;
        grade2 = g2;
        grade3 = g3;
    }

    public Student()
    {
    }

    public double CalculateAverage()
    {
        return (grade1 + grade2 + grade3) / 3.0;
    }

    public void AddStudent()
    {
        if (studentCount >= 100)
        {
            Console.WriteLine("Student list is full.");
            return;
        }

        Console.Write("Enter student name: ");
        string inputName = Console.ReadLine();

        Console.Write("Enter grade 1: ");
        double g1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter grade 2: ");
        double g2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter grade 3: ");
        double g3 = Convert.ToDouble(Console.ReadLine());

        Student newStudent = new Student(inputName, g1, g2, g3);
        students[studentCount] = newStudent;
        studentCount = studentCount + 1;

        Console.WriteLine("Student added successfully!");
    }

    public void ViewStudents()
    {
        if (studentCount == 0)
        {
            Console.WriteLine("No students found.");
            return;
        }

        for (int i = 0; i < studentCount; i++)
        {
            Student current = students[i];
            Console.WriteLine();
            Console.WriteLine("Name: " + current.name);
            Console.WriteLine("Grades: " + current.grade1 + ", " + current.grade2 + ", " + current.grade3);
            Console.WriteLine("Average: " + current.CalculateAverage());
        }
    }

    public void ComputeClassAverage()
    {
        if (studentCount == 0)
        {
            Console.WriteLine("No students found.");
            return;
        }

        double totalSum = 0;
        for (int i = 0; i < studentCount; i++)
        {
            totalSum = totalSum + students[i].CalculateAverage();
        }

        double classAverage = totalSum / studentCount;
        Console.WriteLine();
        Console.WriteLine("Overall Class Average Grade: " + classAverage);
    }

    public void FindHighestGrade()
    {
        if (studentCount == 0)
        {
            Console.WriteLine("No students found.");
            return;
        }

        Student topStudent = students[0];
        for (int i = 1; i < studentCount; i++)
        {
            if (students[i].CalculateAverage() > topStudent.CalculateAverage())
            {
                topStudent = students[i];
            }
        }

        Console.WriteLine();
        Console.WriteLine("Top Student: " + topStudent.name);
        Console.WriteLine("Highest Average Grade: " + topStudent.CalculateAverage());
    }
}