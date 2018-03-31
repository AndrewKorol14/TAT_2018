using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TaskDEV7.Test
{
    [TestClass]
    public class CarChooserTests
    {
        [TestMethod]
        public void FindPossibleEquipments_ContainSomeCars_ListOfPossibleCars()
        {
            List<Car> testCars = new List<Car>();
            List<Car> expectedCars = new List<Car>();
            testCars.Add(new Honda("Civic", "sedan", "manual", "petrol", "2.0", "200", "air conditioner", "textile"));
            testCars.Add(new VAZ("2101", "sedan", "manual", "petrol", "1.2", "70", "no", "textile"));
            testCars.Add(new Honda("Civic", "sedan", "automatic", "petrol", "2.0", "200", "air conditioner", "leather"));
            List<string> testFeatures = new List<string>() { "Civic", "", "", "", "", "", "", "" };
            expectedCars.Add(new Honda("Civic", "sedan", "manual", "petrol", "2.0", "200", "air conditioner", "textile"));
            expectedCars.Add(new Honda("Civic", "sedan", "automatic", "petrol", "2.0", "200", "air conditioner", "leather"));
            CarChooser testChooser = new CarChooser();
            List<Car> actualCars = testChooser.FindPossibleEquipments(testCars, testFeatures);
            for(int i = 0; i < actualCars.Count; i++)
            {
                Assert.AreEqual(expectedCars[i], actualCars[i]);
            } 
        }

        [TestMethod]
        public void FindPossibleEquipments_ContainAllCars_ListOfPossibleCars()
        {
            List<Car> testCar = new List<Car>();
            List<Car> expectedCar = new List<Car>();
            testCar.Add(new Honda("Civic", "sedan", "manual", "petrol", "2.0", "200", "air conditioner", "textile"));
            testCar.Add(new VAZ("2101", "sedan", "manual", "petrol", "1.2", "70", "no", "textile"));
            testCar.Add(new Honda("Civic", "sedan", "automatic", "petrol", "2.0", "200", "air conditioner", "leather"));
            List<string> testFeatures = new List<string>() { "2101", "sedan", "manual", "petrol", "1.2", "70", "no", "textile" };
            expectedCar.Add(new VAZ("2101", "sedan", "manual", "petrol", "1.2", "70", "no", "textile"));
            CarChooser testChooser = new CarChooser();
            List<Car> actualCars = testChooser.FindPossibleEquipments(testCar, testFeatures);
            for (int i = 0; i < actualCars.Count; i++)
            {
                Assert.AreEqual(expectedCar[i], actualCars[i]);
            }
        }
    }
}
