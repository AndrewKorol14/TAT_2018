using System;
using System.Collections.Generic;

namespace TaskDEV7
{
    /// <summary>
    /// Create concrete realization of determined in 'Catalog' commands
    /// </summary>
    class CommandCatalog : ICommand
    {
        Catalog catalog;

        public CommandCatalog(Catalog catalog)
        {
            this.catalog = catalog;
        }

        /// <summary>
        /// Call command of checking cars with entered features in catalog
        /// </summary>
        /// <param name="inputtedCarsFeatures">Entered car features</param>
        public void CheckCatalogOrStore(List<string> inputtedCarsFeatures)
        {
            catalog.OutputCarsInCatalog(inputtedCarsFeatures);
        }

        /// <summary>
        /// Output message
        /// </summary>
        /// <param name="inputtedCarsFeatures">Entered car features</param>
        public void AddNewCar(List<string> inputtedCarsFeatures)
        {
            Console.WriteLine("You can't add cars in catalog");
        }
    }
}