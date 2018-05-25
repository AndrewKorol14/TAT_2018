using System;
using System.Collections.Generic;
using System.Linq;

namespace TaskDEV8
{
    /// <summary>
    /// Create information about user data
    /// </summary>
    public class DataInformationCreator
    {
        /// <summary>
        /// Calculate average age of users
        /// </summary>
        /// <param name="users">List of users</param>
        /// <returns>Average age</returns>
        public double CountAverageAge(List<User> users)
        {
            double averageAge = users.Average(user => user.Age);
            return averageAge;
        }

        /// <summary>
        /// Find the oldest user or some such users from all users
        /// </summary>
        /// <param name="users">List of users</param>
        /// <returns>List of the oldest users</returns>
        public List<User> FindOldestUsers(List<User> users)
        {
            int oldestAge = users.Max(user => user.Age);
            var oldestUsers = users.Where(user => user.Age == oldestAge);
            return oldestUsers.ToList();        
        }

        /// <summary>
        /// Find the most popular woman name or some such names from all woman names
        /// </summary>
        /// <param name="users">List of users</param>
        /// <returns>List of popular woman names</returns>
        public List<String> FindPopularWomanNames(List<User> users)
        {
            var women = users.Where(user => user.Gender == "woman");
            if (women.ToList().Count != 0)
            {
                var womanNamesGroup = women.GroupBy(woman => woman.FirstName).
                    Select(woman => new { Name = woman.Key, Count = woman.Count() });
                var maxWomanNamesNumber = womanNamesGroup.Max(womanName => womanName.Count);
                var popularWomanName = womanNamesGroup.Where(womanName => womanName.Count == maxWomanNamesNumber)
                                                      .Select(womanName => womanName.Name);
                return popularWomanName.ToList();
            }
            else
            {            
                return new List<String>();
            }
        }
    }
}