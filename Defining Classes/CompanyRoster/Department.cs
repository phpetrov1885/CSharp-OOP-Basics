using System.Collections.Generic;
using System.Linq;

public class Department
{
    private List<Employee> employees;
    private string name;

    public Department(string name)
    {
        Employees=new List<Employee>();
        this.Name = name;
    }
    public List<Employee> Employees
    {
        get { return employees; }
        private set { this.employees = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public decimal AverageSalary
    {
        get
        {
            return this.employees.Select(e => e.Salary).Average();
        }
    }

    public void addEmployee(Employee employee)
    {
        this.Employees.Add(employee);
    }
}