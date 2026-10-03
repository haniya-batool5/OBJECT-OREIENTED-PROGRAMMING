using System;

namespace week2
{
    public class Student
    {
        public string name;
        public double matricMarks;
        public double fscMarks;
        public double ecatMarks;
        public double aggregate;

        // Constructor
        public Student(string name, double matricMarks,
                       double fscMarks, double ecatMarks)
        {
            this.name = name;
            this.matricMarks = matricMarks;
            this.fscMarks = fscMarks;
            this.ecatMarks = ecatMarks;
        }
        public void ShowStudent()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Matric Marks: " + matricMarks);
            Console.WriteLine("FSc Marks: " + fscMarks);
            Console.WriteLine("ECAT Marks: " + ecatMarks);
            Console.WriteLine("Aggregate: " + aggregate);
            Console.WriteLine("----------------------");
        }

        // Calculate Aggregate
        public void CalculateAggregate()
        {
            aggregate =
                (matricMarks / 1100 * 17)
                + (fscMarks / 1100 * 50)
                + (ecatMarks / 400 * 33);
        }

        static void Main(string[] args)
        {
            Student[] students = new Student[100];

            int studentCount = 0;

            while (true)
            {
                Console.Clear();

                Console.WriteLine("-----------------------------");
                Console.WriteLine("  STUDENT MANAGEMENT SYSTEM");
                Console.WriteLine("-----------------------------");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Show Students");
                Console.WriteLine("3. Calculate Aggregate");
                Console.WriteLine("4. Top Students");
                Console.WriteLine("5. Exit");

                Console.Write("Enter choice: ");
                int choice = int.Parse(Console.ReadLine());

                // Add Student
                if (choice == 1)
                {
                    string name;
                    double matric;
                    double fsc;
                    double ecat;

                    Console.Write("Enter student name: ");
                    name = Console.ReadLine();

                    Console.Write("Enter matric marks: ");
                    matric = double.Parse(Console.ReadLine());

                    Console.Write("Enter FSc marks: ");
                    fsc = double.Parse(Console.ReadLine());

                    Console.Write("Enter ECAT marks: ");
                    ecat = double.Parse(Console.ReadLine());

                    // Reference variable in Main
                    Student s1 = new Student(name, matric, fsc, ecat);

                    // Store reference in array
                    students[studentCount] = s1;

                    studentCount++;

                    Console.WriteLine("Student added successfully.");
                }

                // Show Students
                else if (choice == 2)
                {
                    for (int i = 0; i < studentCount; i++)
                    {
                        students[i].ShowStudent();
                    }
                }

                // Calculate Aggregate
                else if (choice == 3)
                {
                    for (int i = 0; i < studentCount; i++)
                    {
                        students[i].CalculateAggregate();
                    }

                    Console.WriteLine("Aggregate calculated.");
                }
                else if (choice == 4)
                {
                    for (int i = 0; i < studentCount; i++)
                    {
                        students[i].CalculateAggregate();
                    }

                    // Sort according to aggregate
                    for (int i = 0; i < studentCount - 1; i++)
                    {
                        for (int j = i + 1; j < studentCount; j++)
                        {
                            if (students[j].aggregate > students[i].aggregate)
                            {
                                Student temp = students[i];

                                students[i] = students[j];

                                students[j] = temp;
                            }
                        }
                    }

                    int top = studentCount;

                    if (top > 3)
                    {
                        top = 3;
                    }

                    Console.WriteLine("--------- TOP STUDENTS ---------");

                    for (int i = 0; i < top; i++)
                    {
                        students[i].ShowStudent();
                    }
                }
                else if (choice == 5)
                {
                    Console.WriteLine("Program ended.");
                    break;
                }

                else
                {
                    Console.WriteLine("Invalid choice.");
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
