using System;

namespace Enums
{
    public enum ShippingMethod
    {
        RegularAirMail = 1, 
        RegisteredAirMail= 2,
        Express = 3

    }
    class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethod.Express;
            Console.WriteLine("Value of (int)method: " + (int)method);

            var methodId = 3;
            Console.WriteLine("Value of (ShippingMethod)methodId: " + (ShippingMethod)methodId); // Casting, nb 3 represent Express Method

            Console.WriteLine("Value of method.ToString(): " + method.ToString());

            var methodName = "Express"; // Parse this string
            // next one will convert or parse a tring to an enum or enumeration
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
            Console.WriteLine("this is shippingMethod result: " + shippingMethod);
        }
    }
}
