using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public partial class Person
{
    partial void PrintAge()
    {
        Console.WriteLine("Current age: {0}", Age);
    }
}