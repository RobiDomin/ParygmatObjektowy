using System;
using System.Collections.Generic;

namespace Parygmatobj3
{
    class Program
    {
        static void Main()
        {
            List<Employee> employees = new List<Employee>() {
            new Manager("Jan Kowalski", 45, 15000, "IT-departament"),
            new Developer("Marcin Straszny", 28, 6000, "C#"),
            new Developer("Beata Nowakowska", 32, 10000, "Java"),
            new Developer("Jerzy Smieszek", 40, 10000, "Python"),
            new Intern("Piotr Placzek", 22, 2000, 6),
            new Intern("Anna Nowak", 18, 100, 2)
        };

            Console.WriteLine("Lista pracowników:");
            foreach (var employee in employees)
            {
                employee.ShowDetails();
            }
        }
    }
}