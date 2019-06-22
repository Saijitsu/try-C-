using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 12345;
            // byte b = i; can't compile (only cast option)
            byte b = (byte) i;
            Console.WriteLine(b);
        }
    }
}
