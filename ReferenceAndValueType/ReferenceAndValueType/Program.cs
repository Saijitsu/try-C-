using System;

namespace ReferenceAndValueType
{
    public class Person
    {
        public int Age;
    }
    class Program
    {
        static void Main(string[] args)
        {
           /* var a = 10;
            var b = a;
            b++;
            Console.WriteLine(string.Format(" a: {0}, b: {1}", a, b));

            var array1 = new int[3] {1, 2, 3};
            var array2 = array1;
            array2[0] = 0;
            Console.WriteLine(string.Format(" array1[0]: {0}, array2[0]: {1}", array1[0], array2[0]));
            // array2 has the same adress reference*/

           var number = 1;
           Increment(number);
           Console.WriteLine(number); // value 1, not affected by Increment because of value Type

           var person = new Person() { Age = 20 };
           MakeOld(person);
           Console.WriteLine(person.Age); // affected by Increment because of reference Type 
           // copy of reference of the object, not the value!
        }

        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
}
