using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;

namespace TaskDEV7
{
    /// <summary>
    /// Create deserializer and serializer for JSON-file
    /// </summary>
    public class JsonEditor
    {
        /// <summary>
        /// Deserialize JSON-file
        /// </summary>
        /// <param name="catalogWay">Way to JSON-file</param>
        /// <returns>List of cars</returns>
        public List<Car> DeserializeJson(string catalogWay)
        {
            List<Car> cars = new List<Car>();
            try
            {
                using (FileStream stream = File.OpenRead(catalogWay))
                {
                    List<Type> types = new List<Type>();
                    types.Add(typeof(Ford));
                    types.Add(typeof(BMW));
                    types.Add(typeof(Honda));
                    types.Add(typeof(VAZ));
                    types.Add(typeof(Tesla));
                    DataContractJsonSerializer deserializer = new DataContractJsonSerializer(typeof(List<Car>), types);
                    cars = (List<Car>)deserializer.ReadObject(stream);
                }
            }
            catch(DirectoryNotFoundException ex)
            {
                throw new DirectoryNotFoundException(ex.Message);
            }
            catch(FileNotFoundException ex)
            {
                throw new FileNotFoundException(ex.Message);
            }
            return cars;
        }

        /// <summary>
        /// Serialize JSON-file
        /// </summary>
        /// <param name="carToStorage">List of car, which enter into JSON-file</param>
        public void SerializeJson(List<Car> carToStorage)
        {
            try
            {
                using (FileStream stream = new FileStream("C:\\Users\\Король Андрей\\Documents\\GitHub\\TAT_2018\\TaskDEV7\\CarStore.json",
                FileMode.Open))
                {
                    DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Car>));
                    jsonFormatter.WriteObject(stream, carToStorage);
                }
            }
            catch(DirectoryNotFoundException ex)
            {
                throw new DirectoryNotFoundException(ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                throw new FileNotFoundException(ex.Message);
            }
        }
    }
}