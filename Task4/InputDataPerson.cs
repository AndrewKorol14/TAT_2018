using System;
using System.Collections.Generic;

namespace Task4
{
    /// <summary>
    /// Create inputter for person data
    /// </summary>
    class InputDataPerson
    {
        private List<Person> persons;

        public InputDataPerson()
        {
            persons = new List<Person>();
        }

        public List<Person> Persons
        {
            get { return persons; }
        }

        /// <summary>
        /// Add data about persons and react on event
        /// </summary>
        public void AddPersons()
        {
            try
            {
                Console.WriteLine("Input first name...");
                String userFirstName = Console.ReadLine();
                Console.WriteLine("Input last name...");
                String userLastName = Console.ReadLine();
                Console.WriteLine("Input age...");
                int userAge = Int32.Parse(Console.ReadLine());
                persons.Add(new Person(userFirstName, userLastName, userAge));
                
            }
            catch (FormatException)
            {
                throw new FormatException("Wrong number format");
            }
        }
    }
}