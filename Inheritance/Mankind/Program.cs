using System;


class Program
{
    static void Main()
    {
        try
        {
            string[] studentInput = Console.ReadLine().Split();
            Student student = CreateStudent(studentInput);

            string[] workerInput = Console.ReadLine().Split();
            Worker worker = CreateWorker(workerInput);

            Console.WriteLine(student);
            Console.WriteLine(worker);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    private static Worker CreateWorker(string[] workerInput)
    {
        string workerFirstName = workerInput[0];
        string workerLastName = workerInput[1];
        decimal salary = decimal.Parse(workerInput[2]);
        decimal workingHours = decimal.Parse(workerInput[3]);
        Worker worker = new Worker(workerFirstName, workerLastName, salary, workingHours);

        return worker;
    }

    private static Student CreateStudent(string[] studentInput)
    {
        string studentFirstName = studentInput[0];
        string studentLastName = studentInput[1];
        string facultyNumber = studentInput[2];
        Student student = new Student(studentFirstName, studentLastName, facultyNumber);

        return student;
    }
}

