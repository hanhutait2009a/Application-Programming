namespace Application_Programming
{
    public class Person
    {
        private string Name { get; set; }
        private static int Age { get; set; }

        public Person()
        {
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = ++age;
        }

        public override string ToString()
        {
            return $"Name :{Name}, Age :{Age}";
        }
    }
}