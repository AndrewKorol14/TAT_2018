using System;

namespace TaskDEV8
{
    /// <summary>
    /// Redefine methods of commands
    /// </summary>
    class InformationOnCommand: ICommand
    {
        DataInformationCreator dataInfo;
        InputDataCreator dataCreator;
        
        public InformationOnCommand(DataInformationCreator dataInfo, InputDataCreator dataCreator)
        {
            this.dataInfo = dataInfo;
            this.dataCreator = dataCreator;
        }

        /// <summary>
        /// Redefine method of command of finding average age of users
        /// </summary>
        public void ExecuteAverageAge()
        {
            Console.WriteLine("Average age: " + dataInfo.CountAverageAge(dataCreator.Users));
        }

        /// <summary>
        /// Redefine method of command of finding the oldest user
        /// </summary>
        public void ExecuteOldestUser()
        {
            Console.WriteLine("Oldest users: ");
            foreach (User user in dataInfo.FindOldestUsers(dataCreator.Users))
            {
                Console.WriteLine(user);
            }
        }

        /// <summary>
        /// Redefine method of command of finding the most popular woman name
        /// </summary>
        public void ExecutePopularWomanName()
        {
            if (dataInfo.FindPopularWomanNames(dataCreator.Users) != null)
            {
                Console.WriteLine("Popular woman name: ");
                foreach (string name in dataInfo.FindPopularWomanNames(dataCreator.Users))
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}