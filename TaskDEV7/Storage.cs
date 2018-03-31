using System;
using System.Collections.Generic;

namespace TaskDEV7
{
    /// <summary>
    /// Create receiver of commands for storage
    /// </summary>
    class Storage
    {
        CarChooser chooser = new CarChooser("C:\\Users\\Король Андрей\\Documents\\GitHub\\TAT_2018\\TaskDEV7\\CarStore.json");
        JsonEditor storeReader = new JsonEditor();
        List<Car> storagePossibleCars = new List<Car>();

        /// <summary>
        /// Output possible equipments of cars from catalog
        /// </summary>
        /// <param name="inputtedCarsFeatures">Entered car features</param>
        /// <returns>List of possible cars from storage</returns>
        public List<Car> OutputCarsInStorage(List<string> inputtedCarsFeatures)
        {
            storagePossibleCars = chooser.FindPossibleEquipments(chooser.CarCatalog, inputtedCarsFeatures);
            Console.WriteLine("Cars with inputted features in the storage:");
            chooser.OutputPossibleEquipments(storagePossibleCars);
            if(storagePossibleCars.Count == 0)
            {
                Console.WriteLine("No such car in the storage.");
            }
            return storagePossibleCars;
        }

        /// <summary>
        /// Add to storage chosen car by client
        /// </summary>
        /// <param name="inputtedCarsFeatures">Entered car features</param>
        public void AddToStore(List<string> inputtedCarsFeatures)
        {
            List<Car> possibleCars = OutputCarsInStorage(inputtedCarsFeatures);
            Console.WriteLine("Cars with inputted features in the catalog:");
            if(storagePossibleCars.Count == 0)
            {
                Catalog tempCatalog = new Catalog();
                possibleCars = tempCatalog.OutputCarsInCatalog(inputtedCarsFeatures);
                if(possibleCars.Count == 0)
                {
                    Console.WriteLine("No such car in the catalog");
                }
                else
                {
                    int numberCar = chooser.ChooseCarFromVersions(possibleCars);
                    chooser.IdentifyBrandOfChosenCar(possibleCars[numberCar - 1], chooser.CarCatalog);
                }
            }
            else
            {
                Console.WriteLine("Cars with such features is in the storage");
            }
        }
    }
}