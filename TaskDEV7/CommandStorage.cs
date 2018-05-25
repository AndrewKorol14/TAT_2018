using System.Collections.Generic;

namespace TaskDEV7
{
    /// <summary>
    /// Create concrete realization of determined in 'Storage' commands
    /// </summary>
    class CommandStorage : ICommand
    {
        Storage storage;

        public CommandStorage(Storage storage)
        {
            this.storage = storage;
        }

        /// <summary>
        /// Call command of checking cars with entered features in storage 
        /// </summary>
        /// <param name="inputtedCarsFeatures">Entered car features</param>
        public void CheckCatalogOrStore(List<string> inputtedCarsFeatures)
        {
            storage.OutputCarsInStorage(inputtedCarsFeatures);
        }

        /// <summary>
        /// Call command of adding car to storage 
        /// </summary>
        /// <param name="inputtedCarsFeatures">Entered car features</param>
        public void AddNewCar(List<string> inputtedCarsFeatures)
        {
            storage.AddToStore(inputtedCarsFeatures);
        }
    }
}