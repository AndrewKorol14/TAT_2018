using System;
using System.Collections.Generic;
using System.Linq;

namespace TaskDEV8
{
    /// <summary>
    /// Create data inputter
    /// </summary>
    class InputDataCreator
    {
        private List<User> users;

        public InputDataCreator()
        {
            users = new List<User>();
        }

        public List<User> Users
        {
            get { return users; }
        }

        /// <summary>
        /// Add data about users and react on event
        /// </summary>
        public void AddUsers()
        {
            try
            {
                Console.WriteLine("Input first name...");
                String userFirstName = Console.ReadLine();
                Console.WriteLine("Input last name...");
                String userLastName = Console.ReadLine();
                Console.WriteLine("Input gender(woman or man)...");
                String userGender = Console.ReadLine();
                Console.WriteLine("Input age...");
                int userAge = Int32.Parse(Console.ReadLine());
                users.Add(new User(userFirstName, userLastName, userGender, userAge));
                if (FindNamesakes(userLastName).Count > 1)
                {
                    NamesakesEventArgs args = new NamesakesEventArgs();
                    args.Namesakes = FindNamesakes(userLastName);  
                    OnOutputNamesakes(args);
                }
            }
            catch (FormatException)
            {
                throw new FormatException("Wrong number format");
            }
        }

        private List<User> FindNamesakes(String inputtedLastName)
        {
            var namesakeUsers = users.Where(user => user.LastName == inputtedLastName).Select(user => user);
            return namesakeUsers.ToList();
        }        

        protected virtual void OnOutputNamesakes(NamesakesEventArgs ev)
        {
            EventHandler<NamesakesEventArgs> handler = OutputNamesakes;
            if (handler != null)
            {
                handler(this, ev);
            }
        }
        
        public event EventHandler<NamesakesEventArgs> OutputNamesakes;
    }
}