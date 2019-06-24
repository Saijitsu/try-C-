using System;

namespace LogicalOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 1;
            var b = 2;
            // Console.WriteLine((float)a / (float)b); => if not float = 3
           // Console.WriteLine(a != b);
            Console.WriteLine(!(a != b)); // 2 negative, positive, not easy to read
            var c = 3;
            Console.WriteLine(c> b && c == a); // True & False => False
            Console.WriteLine(c > b || c == a); // if One is True => True
        }
    }
}
