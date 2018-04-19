using System;
using System.Collections.Generic;
using System.Text;

public class Worker : Human
{
    private decimal weekSalary;
    private decimal workHoursPerDay;

    public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay)
        : base(firstName, lastName)
    {
        WeekSalary = weekSalary;
        WorkHoursPerDay = workHoursPerDay;
    }

    public decimal WeekSalary
    {
        get { return weekSalary; }
        set
        {
            Validators.ValidateWeekSalary(value, nameof(weekSalary));
            weekSalary = value;
        }
    }
    public decimal SalaryPerDay
    {
        get { return weekSalary / workHoursPerDay / 5; }
    }
    public decimal WorkHoursPerDay
    {
        get { return workHoursPerDay; }
        set
        {
            Validators.ValidateWorkingHours(value, nameof(workHoursPerDay));
            workHoursPerDay = value;
        }
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder(base.ToString());
        sb.AppendLine()
            .AppendLine($"Week Salary: {WeekSalary:f2}")
            .AppendLine($"Hours per day: {workHoursPerDay:f2}")
            .AppendLine($"Salary per hour: {SalaryPerDay:f2}");

        string result = sb.ToString().TrimEnd();
        return result;
    }
}

