using System.Collections.Generic;

namespace TaskDEV7
{
    /// <summary>
    /// Determines functions of checking storage and adding car for storage 
    /// </summary>
    interface ICommand
    {
        void CheckCatalogOrStore(List<string> inputtedCarsFeatures);
        void AddNewCar(List<string> inputtedCarsFeatures);
    }
}
