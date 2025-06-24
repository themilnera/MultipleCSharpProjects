List<Employee> employees = new List<Employee>();
employees.Add(new FullTimeEmployee("Some One", 24000));
employees.Add(new HourlyEmployee("Some Other", 18, 160));
foreach (Employee employee in employees)
{
    employee.DisplayEmployeeInfo();
}
abstract class Employee
{
    public string Name { get; set; }
    
    public Employee(string name)
    {
        Name = name;
    }

    public abstract int CalculateMonthlySalary();
    public void DisplayEmployeeInfo()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Monthly Salary: "+ CalculateMonthlySalary());
    }
}

class FullTimeEmployee : Employee
{
    private int annualSalary;
    public FullTimeEmployee(string name, int annualSalary) : base(name)
    {
        this.annualSalary = annualSalary;
    }
    public override int CalculateMonthlySalary()
    {
        return annualSalary / 12;
    }
}

class HourlyEmployee : Employee
{
    private int hourlyRate, hoursWorkedPerMonth;
    public HourlyEmployee(string name, int hourlyRate, int hoursWorkedPerMonth) : base(name)
    {
        this.hourlyRate = hourlyRate; 
        this.hoursWorkedPerMonth = hoursWorkedPerMonth;
    }

    public override int CalculateMonthlySalary()
    {
        return hourlyRate * hoursWorkedPerMonth;
    }
}