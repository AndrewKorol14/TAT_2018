using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;

namespace TaskDEV7.Test
{
    [TestClass]
    public class JsonEditorTests
    {
        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException))]
        public void DeserializeJson_CheckFile_ListCar()
        {
            JsonEditor testEditor = new JsonEditor();
            List<Car> testCars = new List<Car>();
            testCars = testEditor.DeserializeJson("C:\\Users\\Король Андрей\\Documents\\GitHub\\TAT_2018\\TaskDEV7\\Store.json");
        }

        [TestMethod]
        [ExpectedException(typeof(DirectoryNotFoundException))]
        public void DeserializeJson_CheckWay_ListCar()
        {
            JsonEditor testEditor = new JsonEditor();
            List<Car> testCars = new List<Car>();
            testCars = testEditor.DeserializeJson("F:\\Users\\Король Андрей\\Documents\\GitHub\\TAT_2018\\TaskDEV7\\CarStore.json");
        }
    }
}