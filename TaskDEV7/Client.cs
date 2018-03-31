using System;
using System.Collections.Generic;

namespace TaskDEV7
{
    /// <summary>
    /// Create invoker of commands for storage and catalog
    /// </summary>
    class Client
    {
        ICommand command;
        List<string> inputtedCarsFeatures = new List<string>();

        public List<string> CarsFeatures
        {
            get { return inputtedCarsFeatures; }
        }

        public Client()
        {
            Console.WriteLine("Enter the brand of car: ");
            inputtedCarsFeatures.Add(Console.ReadLine());
            Console.WriteLine("Enter the model of car: ");
            inputtedCarsFeatures.Add(Console.ReadLine());
            Console.WriteLine("Enter the body style of car (sedan, minivan, station wagon, coupe): ");
            inputtedCarsFeatures.Add(Console.ReadLine());
            Console.WriteLine("Enter the type of transmission of car (manual or automatic): ");
            inputtedCarsFeatures.Add(Console.ReadLine());
            Console.WriteLine("Enter the type of engine of car (petrol, diesel, electric): ");
            inputtedCarsFeatures.Add(Console.ReadLine());
            Console.WriteLine("Enter the capacity of engine of car: ");
            inputtedCarsFeatures.Add(Console.ReadLine());
            Console.WriteLine("Enter the power of engine of car: ");
            inputtedCarsFeatures.Add(Console.ReadLine());
            Console.WriteLine("Enter the type of climate management of car (air conditioner, climate control or no): ");
            inputtedCarsFeatures.Add(Console.ReadLine());
            Console.WriteLine("Enter the type of cabin decoration of car (leather, textile, combined): ");
            inputtedCarsFeatures.Add(Console.ReadLine());
        }

        /// <summary>
        /// Set command of certain type
        /// </summary>
        /// <param name="com">Type of command</param>
        public void SetCommand(ICommand com)
        {
            command = com;
        }

        /// <summary>
        /// Call command of checking possible cars 
        /// </summary>
        /// <param name="inputtedCarsFeatures">Entered car features</param>
        public void PossibleCarsInformation(List<string> inputtedCarsFeatures)
        {
            command.CheckCatalogOrStore(inputtedCarsFeatures);
        }

        /// <summary>
        /// Call command for adding car into storage
        /// </summary>
        /// <param name="inputtedCarsFeatures">Entered car features</param>
        public void AddCarForBuying(List<string> inputtedCarsFeatures)
        {
            command.AddNewCar(inputtedCarsFeatures);
        }
    }
}