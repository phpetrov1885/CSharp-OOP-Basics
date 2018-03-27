using System;


class Program
{
    static void Main(string[] args)
    {
        var studentSystem = new StudentSystem();
        string command = Console.ReadLine();

        while (command != "End")
        {
            studentSystem.ParseCommand(command, Console.WriteLine);

            command = Console.ReadLine();
        }
    }
}

