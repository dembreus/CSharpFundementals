using CSharpFundementals.Math;
using System;

namespace CSharpFundementals
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine(Calculator.Add(4,5));

            var person = new Person
            {
                FirstName = "Rick",
                LastName = "Grimes"
            };
            person.Introduce();

            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);

            var methodID = 3;
            Console.WriteLine((ShippingMethod)methodID);
        }
    }
}
