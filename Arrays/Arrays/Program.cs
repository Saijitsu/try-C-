using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array test
            var numbers = new int[3];
            numbers[0] = 1;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            var flags = new bool[3];
            flags[0] = true;
            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);

            var names = new string[3] {"Jack", "John", "Julio"};
            Console.WriteLine(names[1]);

            // String test
            string firstName = "John";
            string lastName = "Snow";

            string name = string.Format("{0} {1}", firstName, lastName); // format + place order <args>
           // string name = $"{firstName} {lastName}"; => string interpolation
           Console.WriteLine(name);
        }
    }
}
