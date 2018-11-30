using System;

namespace CSharpFundementals
{
    public class Person
    {
        public string FirstName;
        public string LastName;

        public void Introduce()
        {
            var introduction = string.Format("Hello, my name is {0} {1}", FirstName, LastName);
            Console.WriteLine(introduction);
        }
    }
}
