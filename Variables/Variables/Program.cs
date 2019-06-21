using System;

namespace Variables
{
    class Variables
    {
        static void Main(string[] args)
        {
            // 0: premier argument, 1: second argument
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

            const float Pi = 3.14f;
            Console.WriteLine(Pi);
        }
    }
}
