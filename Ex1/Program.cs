using System;

namespace Application_Programming
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var person = new Person("Amar",40);
            Console.WriteLine(person.ToString());
        }
    }
}