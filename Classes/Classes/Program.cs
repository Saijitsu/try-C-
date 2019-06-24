﻿using System;

namespace Classes
{
    class Program {
    static void Main(string[] args)
        {
        var john = new Person();
        john.FirstName = "John";
        john.LastName = "Smith";
        john.Introduce();

        /*var john = new Person
        {
            FirstName = "John",
            LastName = "Smith"
        };*/

        Calculator calculator = new Calculator();
        var result = calculator.Add(1, 2);
        Console.WriteLine(result);
        }
    }
}
