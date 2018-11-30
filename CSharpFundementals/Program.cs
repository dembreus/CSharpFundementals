using CSharpFundementals.Math;
using System;

namespace CSharpFundementals
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine(Calculator.Add(4,5));

            var person = new Person();
            person.FirstName = "Rick";
            person.LastName = "Grimes";
            person.Introduce();
        }
    }
}
