using System;
using System.Collections.Generic;
using System.Text;


public class Validators
{
    private const int FIRST_NAME_MIN_LENGTH = 4;
    private const int LAST_NAME_MIN_LENGTH = 3;

    private const int FACULTY_NUMBER_MIN_LENGTH = 5;
    private const int FACULTY_NUMBER_MAX_LENGTH = 10;

    private const int MIN_WEEK_SALARY = 10;

    private const int MIN_WORKING_HOURS = 1;
    private const int MAX_WORKING_HOURS = 12;

    public static void ValidateFirstName(string firstName, string type)
    {
        if (char.IsLower(firstName[0]))
        {
            throw new ArgumentException($"Expected upper case letter! Argument: {type}");
        }
        if (firstName.Length < FIRST_NAME_MIN_LENGTH)
        {
            throw new ArgumentException($"Expected length at least 4 symbols! Argument: {type}");
        }
    }
    public static void ValidateLastName(string lastName, string type)
    {
        if (char.IsLower(lastName[0]))
        {
            throw new ArgumentException($"Expected upper case letter! Argument: {type}");
        }
        if (lastName.Length < LAST_NAME_MIN_LENGTH)
        {
            throw new ArgumentException($"Expected length at least 3 symbols! Argument: {type}");
        }
    }
    public static void ValidateFacultyNumber(string facultyNumber)
    {
        if (facultyNumber.Length < FACULTY_NUMBER_MIN_LENGTH ||
            facultyNumber.Length > FACULTY_NUMBER_MAX_LENGTH)
        {
            throw new ArgumentException("Invalid faculty number!");
        }
    }
    public static void ValidateWeekSalary(decimal weekSalary, string type)
    {
        if (weekSalary <= MIN_WEEK_SALARY)
        {
            throw new ArgumentException($"Expected value mismatch! Argument: {type}");
        }
    }
    public static void ValidateWorkingHours(decimal workingHoursPerDay,string type)
    {
        if (workingHoursPerDay < MIN_WORKING_HOURS ||
            workingHoursPerDay > MAX_WORKING_HOURS)
        {
            throw new ArgumentException($"Expected value mismatch! Argument: {type}");
        }
    }
}

