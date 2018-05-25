using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;

namespace hometask_18_04
{
    /// <summary>
    /// Create deserializer for JSON-files
    /// </summary>
    class JsonDeserializer
    {
        /// <summary>
        /// Deserialize JSON-file
        /// </summary>
        /// <param name="catalogWay">Way to JSON-file</param>
        /// <returns>List of file addresses</returns>
        public List<FileAddress> DeserializeJson(string catalogWay)
        {
            List<FileAddress> addresses = new List<FileAddress>();
            try
            {
                using (FileStream stream = File.OpenRead(catalogWay))
                {
                    List<Type> types = new List<Type>();
                    types.Add(typeof(FileAddress));
                    DataContractJsonSerializer deserializer = new DataContractJsonSerializer(typeof(List<FileAddress>), types);
                    addresses = (List <FileAddress>)deserializer.ReadObject(stream);
                }
            }
            catch (DirectoryNotFoundException ex)
            {
                throw new DirectoryNotFoundException(ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                throw new FileNotFoundException(ex.Message);
            }
            return addresses;
        }
    }
}