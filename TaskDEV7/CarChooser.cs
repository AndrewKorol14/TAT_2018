using System;
using System.Collections.Generic;
using System.Linq;

namespace TaskDEV7
{
    /// <summary>
    /// Chooses the car that the client wants to buy
    /// </summary>
    public class CarChooser
    {
        List<Car> carCatalog;
        JsonEditor catalog;

        /// <summary>
        /// Create chooser and call function for deserialization of JSON-file
        /// </summary>
        /// <param name="catalogWay">Way to JSON-file</param>
        public CarChooser(string catalogWay)
        {
            catalog = new JsonEditor();
            carCatalog = catalog.DeserializeJson(catalogWay);
        }

        public CarChooser() { }

        public List<Car> CarCatalog
        {
            get { return carCatalog; }
        }

        /// <summary>
        /// Finds possible equipments of cars with entered features
        /// </summary>
        /// <param name="carToStorage">List of all cars in JSON-file</param>
        /// <param name="carFeatures">List of entered features</param>
        /// <returns>List of possible equipments of cars</returns>                        
        public List<Car> FindPossibleEquipments(List<Car> carToStorage, List<string> carFeatures)
        {
            var carVersion = carToStorage.Where(car => (carFeatures[0] == car.GetType().Name || carFeatures[0] == String.Empty) &&
                                   (carFeatures[1] == car.Model || carFeatures[1] == String.Empty) &&
                                   (carFeatures[2] == car.BodyStyle || carFeatures[2] == String.Empty) &&
                                   (carFeatures[3] == car.Transmission || carFeatures[3] == String.Empty) &&
                                   (carFeatures[4] == car.Engine || carFeatures[4] == String.Empty) &&
                                   (carFeatures[5] == car.Capacity || carFeatures[5] == String.Empty) &&
                                   (carFeatures[6] == car.Power || carFeatures[6] == String.Empty) &&
                                   (carFeatures[7] == car.Climate || carFeatures[7] == String.Empty) &&
                                   (carFeatures[8] == car.Cabin || carFeatures[8] == String.Empty)).Select(car => car);             
            return carVersion.ToList();
        }

        /// <summary>
        /// Output cars with features
        /// </summary>
        /// <param name="possibleCars">List of cars</param>
        public void OutputPossibleEquipments(List<Car> possibleCars)
        {
            for (int i = 0; i < possibleCars.Count; i++)
            {
                Console.WriteLine((i + 1) + ". Brand: " + possibleCars[i].GetType().Name);
                Console.WriteLine("Model: " + possibleCars[i].Model + "; Body style: " + possibleCars[i].BodyStyle +
                    "; Transmission: " + possibleCars[i].Transmission + "; Engine: " + possibleCars[i].Engine +
                    "; Engine capacity: " + possibleCars[i].Capacity + "; Engine power: " + possibleCars[i].Power +
                    "; Climate managment: " + possibleCars[i].Climate + "; Decoration: " + possibleCars[i].Cabin);
            }
        }

        /// <summary>
        /// Choose conctrete car from list of possible cars
        /// </summary>
        /// <param name="possibleCars">List of possible cars</param>
        /// <returns>Number of chosen car</returns>
        public int ChooseCarFromVersions(List<Car> possibleCars)
        {
            int numberCar = 0;
            do
            {
                Console.WriteLine("Enter the number of car you want...");
                numberCar = Int32.Parse(Console.ReadLine());
            }
            while (numberCar <= 0 || numberCar > possibleCars.Count);
            return numberCar;
        }

        private void AddCarToStorage(Creator carCreator, Car chosenCar, List<Car> carToStorage)
        {
            Car automobile = carCreator.CreateCar(chosenCar.Model, chosenCar.BodyStyle, chosenCar.Transmission,chosenCar.Engine, 
                chosenCar.Capacity, chosenCar.Power, chosenCar.Climate, chosenCar.Cabin);
            carToStorage.Add(automobile);
            catalog.SerializeJson(carToStorage);
        }

        /// <summary>
        /// Identify brand of chosen car and create object of such type, which added into storage
        /// </summary>
        /// <param name="chosenCar">Chosen car by client</param>
        /// <param name="carToStorage">Added into storage list of cars</param>
        public void IdentifyBrandOfChosenCar(Car chosenCar, List<Car> carToStorage)
        {
            Creator carCreator;
            switch (chosenCar.GetType().Name)
            {
                case "Honda":
                    carCreator = new HondaCreator();
                    AddCarToStorage(carCreator, chosenCar, carToStorage);
                    break;
                case "BMW":
                    carCreator = new BMWCreator();
                    AddCarToStorage(carCreator, chosenCar, carToStorage);
                    break;
                case "Ford":
                    carCreator = new FordCreator();
                    AddCarToStorage(carCreator, chosenCar, carToStorage);
                    break;
                case "Tesla":
                    carCreator = new TeslaCreator();
                    AddCarToStorage(carCreator, chosenCar, carToStorage);
                    break;
                case "VAZ":
                    carCreator = new VAZCreator();
                    AddCarToStorage(carCreator, chosenCar, carToStorage);
                    break;
            }
        }
    }
}