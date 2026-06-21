using System;

class Program
{
    static void Main()
    {
        Student manager = new Student();
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

            if (choice == "1")
            {
                manager.AddStudent();
            }
            else if (choice == "2")
            {
                manager.ViewStudents();
            }
            else if (choice == "3")
            {
                manager.ComputeClassAverage();
            }
            else if (choice == "4")
            {
                manager.FindHighestGrade();
            }
            else if (choice == "5")
            {
                Console.WriteLine("Exiting program...");
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid choice!");
            }

            if (running)
            {
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }
        }
    }
}