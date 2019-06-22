using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test one
            int i = 12345;
            // byte b = i; can't compile (only cast option)
            byte b = (byte) i;
            Console.WriteLine(b); // Lost some byte

            // Test two
            try
            {
                var number = "1234";
                // int iNumber = Convert.ToInt32(number); Okay
                int iNumber = Convert.ToByte(number);
                Console.WriteLine(iNumber);
            }
            catch (Exception)
            {
                Console.WriteLine("Error: The number could not be convert to a byte");
            }

            // Test three
            try
            {
                string str = "true";
                bool strBool = Convert.ToBoolean(str);
                Console.WriteLine(strBool);
            }
            catch (Exception)
            {
                Console.WriteLine("This will be work: no message");
            }
            
        }
    }
}
