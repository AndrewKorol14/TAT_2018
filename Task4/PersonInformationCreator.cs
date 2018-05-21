using System;
using System.Collections.Generic;
using System.Linq;

namespace Task4
{
    class PersonInformationCreator
    {
        /// <summary>
        /// Calculate average age of persons
        /// </summary>
        /// <param name="users">List of persons</param>
        /// <returns>Average age</returns>
        public double CountAverageAge(List<Person> persons)
        {
            double averageAge = persons.Average(person => person.Age);
            return Math.Round(averageAge, 2);
        }

        /// <summary>
        /// Finds the oldest age
        /// </summary>
        /// <param name="persons">List of persons</param>
        /// <returns>Oldest age</returns>
        public int FindOldestAge(List<Person> persons)
        {
            int oldestAge = persons.Max(person => person.Age);
            return oldestAge;
        }

        /// <summary>
        /// Finds the youngest age
        /// </summary>
        /// <param name="persons">List of persons</param>
        /// <returns>Youngest age</returns>
        public int FindYoungestAge(List<Person> persons)
        {
            int youngestAge = persons.Min(person => person.Age);
            return youngestAge;
        }
    }
}