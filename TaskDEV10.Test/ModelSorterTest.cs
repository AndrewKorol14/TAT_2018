using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TaskDEV10.Test
{
    [TestClass]
    public class ModelSorterTest
    {
        private List<Car> inputList;
        private List<Car> expectedList;

        [TestInitialize]
        public void SetUp()
        {
            inputList = new List<Car>()
            {
                new Car("X6", 5),
                new Car("X5", 10),
                new Car("M5", 3)
            };
            expectedList = new List<Car>()
            {
                new Car("X5", 10),
                new Car("X6", 5),
                new Car("M5", 3)
            };
        }

        [TestMethod]
        public void SortByDescendingModelsTests()
        {
            ModelSorter sorter = new ModelSorter();
            List<Car> actualList = sorter.SortByDescendingModels(inputList);
            for (int i = 0; i < expectedList.Count; i++)
            {
                Assert.AreEqual(expectedList[i].Model, actualList[i].Model);
            }
        }
    }
}