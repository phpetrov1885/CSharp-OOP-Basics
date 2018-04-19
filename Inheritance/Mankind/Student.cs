using System;
using System.Collections.Generic;
using System.Text;


public class Student : Human
{
    private string facultyNumber;

    public Student(string firstName,string lastName,string facultyNumber):base(firstName,lastName)
    {
        FacultyNumber = facultyNumber;
    }

    public string FacultyNumber
    {
        get { return facultyNumber; }
        set
        {
            Validators.ValidateFacultyNumber(value);
            facultyNumber = value;
        }
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder(base.ToString());
        sb.AppendLine();
        sb.AppendLine($"Faculty number: {FacultyNumber}");
       // sb.AppendLine();

        string result = sb.ToString().TrimEnd();
        return result;
    }
}

