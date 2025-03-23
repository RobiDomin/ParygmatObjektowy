using System;
using System.Collections.Generic;


namespace Parygmatobj3
{
    class Manager : Employee
    {
        public string Department { get; set; }

        public Manager(string name, int age, double salary, string department)
            : base(name, age, salary)
        {
            Department = department;
        }

        public override void ShowDetails()
        {
            Console.WriteLine($"Manager: {Name}, Wiek: {Age}, Pensja: {Salary:C}, Dział: {Department}");
        }
    }

    class Developer : Employee
    {
        public string ProgrammingLanguage { get; set; }

        public Developer(string name, int age, double salary, string language)
            : base(name, age, salary)
        {
            ProgrammingLanguage = language;
        }

        public override void ShowDetails()
        {
            Console.WriteLine($"Developer: {Name}, Wiek: {Age}, Pensja: {Salary:C}, Język: {ProgrammingLanguage}");
        }
    }

    class Intern : Employee
    {
        public int InternshipDuration { get; set; }

        public Intern(string name, int age, double salary, int duration)
            : base(name, age, salary)
        {
            InternshipDuration = duration;
        }

        public override void ShowDetails()
        {
            Console.WriteLine($"Intern: {Name}, Wiek: {Age}, Pensja: {Salary:C}, Staż: {InternshipDuration} miesięcy");
        }
    }
}
