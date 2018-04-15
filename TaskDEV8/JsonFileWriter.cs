using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;

namespace TaskDEV8
{
    /// <summary>
    /// Create file writer
    /// </summary>
    public class JsonFileWriter
    {
        /// <summary>
        /// Serialize list of users into JSON-file
        /// </summary>
        /// <param name="users">List of users</param>
        public void SerializeJson(List<User> users, string fileWay)
        {
            try
            {
                using (FileStream stream = new FileStream(fileWay,FileMode.OpenOrCreate))
                {
                    DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<User>));
                    jsonFormatter.WriteObject(stream, users);
                }
            }
            catch (DirectoryNotFoundException ex)
            {
                throw new DirectoryNotFoundException(ex.Message);
            }
        }
    }
}