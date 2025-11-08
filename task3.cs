using System;
interface IWorkable
{
    void Work();
}
abstract class Employee : IWorkable
{
    public string Name { get; set; }
    public double Salary { get; set; }
    public Employee(string _name, float _salary)
    {
        Name = _name;
        Salary = _salary;
    }
    public abstract double CalculateBonus();
    public abstract void Work();
}
class FullTimeEmployee : Employee
{
    public FullTimeEmployee(string _name, float _salary) : base(_name, _salary) { }

    public override double CalculateBonus()
    {
        float bonus_Percentage = 20;
        return Salary * bonus_Percentage / 100;
    }

    public override void Work()
    {
        Console.WriteLine(Name + " is working full time ^_^ ");
    }
}

class PartTimeEmployee : Employee
{
    public PartTimeEmployee(string name, float salary) : base(name, salary) { }

    public override double CalculateBonus()
    {
        float bonus = 10;
        return Salary * bonus / 100;

    }

    public override void Work()
    {
        Console.WriteLine(Name + " is working part time. ");
    }
}
class Program
{
    static void Main()
    {
        Employee emp1 = new FullTimeEmployee("Ahmed", 10000);
        Employee emp2 = new PartTimeEmployee("Sara", 5000);

        emp1.Work();
        Console.WriteLine(emp1.Name + " Bonus: " + emp1.CalculateBonus());

        emp2.Work();
        Console.WriteLine(emp2.Name + " Bonus: " + emp2.CalculateBonus());

    }
}
