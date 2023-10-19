using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Default;
        double x, z;

        Console.Write("Введіть значення x: ");
        x = double.Parse(Console.ReadLine());

        Console.Write("Введіть значення z: ");
        z = double.Parse(Console.ReadLine());

        double numerator = x;
        double denominator = z * z - Math.Abs(x * x / (z - x * x * x / 3));

        if (denominator != 0)
        {
            double y = z + numerator / denominator;
            Console.WriteLine($"Результат обчислення: y = {y}");
        }
        else
        {
            Console.WriteLine("Ділення на нуль неможливе. Знаменник дорівнює нулю.");
        }
    }
}




/*using System;

public class Human
{
    private string m_name;
    private int m_age;

    public Human(string name, int age)
    {
        m_name = name;
        m_age = age;
    }

    public string GetName()
    {
        return m_name;
    }

    public int GetAge()
    {
        return m_age;
    }
}

public class Employee
{
    private string m_employer;
    private double m_wage;

    public Employee(string employer, double wage)
    {
        m_employer = employer;
        m_wage = wage;
    }

    public string GetEmployer()
    {
        return m_employer;
    }

    public double GetWage()
    {
        return m_wage;
    }
}

// Клас Teacher успадковує властивості класів Human і Employee
public class Teacher : Human
{
    private int m_teachesGrade;

    public Teacher(string name, int age, string employer, double wage, int teachesGrade)
        : base(name, age)
    {
        m_teachesGrade = teachesGrade;
    }

    public int GetTeachesGrade()
    {
        return m_teachesGrade;
    }
}
*/