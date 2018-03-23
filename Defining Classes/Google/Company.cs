using System;
using System.Collections.Generic;
using System.Text;


class Company
{
    private string name;
    private string department;
    private decimal salary;

    public Company(string name, string department, decimal salary)
    {
        Name = name;
        Department = department;
        Salary = salary;
    }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public string Department
    {
        get { return department; }
        set { department = value; }
    }
    public decimal Salary
    {
        get { return salary; }
        set { salary = value; }
    }
    public override string ToString()
    {
        return $"{this.name} {this.department} {this.salary:f2}";
    }
}
