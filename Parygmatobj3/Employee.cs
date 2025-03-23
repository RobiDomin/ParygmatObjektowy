using System;
using System.Collections.Generic;

namespace Parygmatobj3
{
    abstract class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        public Employee(string name, int age, double salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }
        public abstract void ShowDetails();
    }
}