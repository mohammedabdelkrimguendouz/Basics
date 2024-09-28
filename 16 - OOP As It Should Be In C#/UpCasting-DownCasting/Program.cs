﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpCasting_DownCasting
{
    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public void Greet()
        {
            Console.WriteLine($"Hi my name is {Name} and I am {Age} Years old");
        }
    }

    public class Employee : Person
    {
        public string Company { get; set; }
        public decimal Salary {  get; set; }    

        public void Work()
        {
            Console.WriteLine($"I am Work in {Company} and earn {Salary:C} per Year");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Upcasting
            Employee employee = new Employee { Name = "John", Age = 30, Company = "Acme Inc.", Salary = 50000 };
            Person person = employee;
            person.Greet(); // Output: "Hi, my name is John and I am 30 years old."

            // Downcasting
            Person person2 = new Employee { Name = "Jane", Age = 25, Company = "XYZ Corp.", Salary = 60000 };
            Employee employee2 = (Employee)person2;
            employee2.Work(); // Output: "I work at XYZ Corp. and earn $60,000.00 per year."

            // Invalid downcasting - throws InvalidCastException at runtime
            //  Person person3 = new Person { Name = "Bob", Age = 40 };
            // Employee employee3 = (Employee)person3; // Runtime exception: InvalidCastException

            Console.ReadKey();
        }
    }
}

