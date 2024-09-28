﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Program
    {
        public interface IPerson
        {

            //Interface members are by default abstract and public

            //An interface cannot contain a constructor (as it cannot be used to create objects)

            // Interfaces can contain properties and methods, but not fields/variables

            //string A ="ABC";
            string FirstName { get; set; }
            string LastName { get; set; }
            void Introduce();
            void Print();
            string To_String();
        }

        public interface ICominuction
        {
            void SendEmail(string Title,string Body);
            void CallPhone();
            void SendSMS(string Title, string Body);
            void SendFax(string Title, string Body);

        }
        public abstract class Person : IPerson,ICominuction
        {
            public string A = "ABC";
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public abstract void Introduce();
            public void Print()
            {
                Console.WriteLine("Hi I am print method");
            }

            public string To_String()
            {
                return "Hi I am To_String Method";
            }
            public void SendEmail(string Title, string Body)
            {
                Console.WriteLine("Email Sent :-)");
            }

            public void SendSMS(string Title, string Body)
            {
                Console.WriteLine("SMS Sent :-)");
            }
            public void SendFax(string Title, string Body)
            {
                Console.WriteLine("FAX Sent :-)");
            }
            public void CallPhone()
            {
                Console.WriteLine("Call Phone :-)");
            }


            public void SayGoodbye()
            {
                Console.WriteLine("Goodbye!");
            }
        }

        public class Employee : Person
        {
            public int EmployeeId { get; set; }
            public override void Introduce()
            {
                Console.WriteLine($"Hi, my name is {FirstName} {LastName}, and my employee ID is {EmployeeId}.");
            }
        }

            static void Main(string[] args)
        {
            // You cannot create an object of an Interface, you can only Implement it.
            // IPerson Person1 = new IPerson();

            Employee employee = new Employee();
            employee.FirstName = "Mohammed";
            employee.LastName = "Abu-Hadhoud";
            employee.EmployeeId = 123;
            employee.Introduce(); // Output: "Hi, my name is John Doe, and my employee ID is 123."
            employee.SayGoodbye(); // Output: "Goodbye!"
            employee.Print();
            employee.CallPhone();
            employee.SendEmail("hi", "Body");
            employee.SendSMS("hi", "Body");
            employee.SendFax("hi", "Body");
            Console.ReadKey();
        }
    }
}
