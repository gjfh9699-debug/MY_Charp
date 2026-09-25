using System;

class CourseResult
{
    public string StudentName { get; set; }

    private double mark;

    public double Mark
    {
        get
        {
            return mark;
        }
        set
        {
            if (value >= 0 && value <= 100)
            {
                mark = value;
            }
            else
            {
                Console.WriteLine("Invalid mark. Mark must be between 0 and 100.");
            }
        }
    }

    public string Grade
    {
        get
        {
            if (Mark >= 90)
                return "A";
            else if (Mark >= 80)
                return "B";
            else if (Mark >= 70)
                return "C";
            else if (Mark >= 60)
                return "D";
            else
                return "F";
        }
    }

    public bool Passed
    {
        get
        {
            return Mark >= 50;
        }
    }

    public void PrintResult()
    {
        Console.WriteLine($"Student Name: {StudentName}");
            Console.WriteLine($"Mark: {Mark}");
        Console.WriteLine($"Grade: {Grade}");
        Console.WriteLine($"Passed: {Passed}");
    }
}

    class Program
    {
        static void Main()
        {
            CourseResult result = new CourseResult();

            Console.Write("Enter student name: ");
            result.StudentName = Console.ReadLine();

            Console.Write("Enter mark: ");
            result.Mark = double.Parse(Console.ReadLine());

            Console.WriteLine();

            result.PrintResult();

            Console.WriteLine();

            Console.WriteLine("Testing invalid mark:");
            result.Mark = 120;
        }
    }