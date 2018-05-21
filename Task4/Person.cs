using System;

namespace Task4
{
    /// <summary>
    /// Create person
    /// </summary>   
    class Person
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public int Age { get; set; }

        public Person(String FirstName, String LastName, int Age)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
        }

        public override string ToString()
        {
            return FirstName + "   " + LastName + "   " + Age;
        }
    }
}