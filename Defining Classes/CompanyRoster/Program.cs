using System;
using System.Collections.Generic;
using System.Linq;


    class Program
    {
        static void Main(string[] args)
        {
            List<Department> departments=new List<Department>();
            int peopleCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < peopleCount; i++)
            {
                string[] inputTokens = Console.ReadLine().Split();

                string name = inputTokens[0];
                decimal salary = decimal.Parse(inputTokens[1]);
                string position = inputTokens[2];
                string departmentName = inputTokens[3];
                string email = "n/a";
                int age = -1;

                if (inputTokens.Length==6)
                {
                    email = inputTokens[4];
                    age = int.Parse(inputTokens[5]);
                }
                else if (inputTokens.Length==5)
                {
                    bool isDigit = int.TryParse(inputTokens[4], out age);
                    
                    if (!isDigit)
                    {
                        email = inputTokens[4];
                        age = -1;
                    }
                }

                if (!departments.Any(d=>d.Name==departmentName))
                {
                    var dep=new Department(departmentName);
                    departments.Add(dep);
                }

                var department = departments.FirstOrDefault(d => d.Name == departmentName);
                Employee employee=new Employee(name,position,departmentName,salary,age,email);
                department.addEmployee(employee);
            }

            var highestAvgSalary = departments.OrderByDescending(e => e.AverageSalary).First();

            Console.WriteLine($"Highest Average Salary: {highestAvgSalary.Name}");

            foreach (var employ in highestAvgSalary.Employees.OrderByDescending(e=>e.Salary))
            {
                Console.WriteLine($"{employ.Name} {employ.Salary:f2} {employ.Email} {employ.Age}");
            }
        }
    }

