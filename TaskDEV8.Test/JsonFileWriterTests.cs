using NUnit.Framework;
using System.Collections.Generic;
using System.IO;

namespace TaskDEV8.Test
{
    [TestFixture]
    class JsonFileWriterTests
    {
        private List<User> users;

        [SetUp]
        public void SetUp()
        {
            users = new List<User>();
            users.Add(new User("aaa", "AAA", "man", 20));
            users.Add(new User("bbb", "BBB", "woman", 10));
            users.Add(new User("ccc", "AAA", "man", 30));
        }
        
        [Test]
        public void SerializeJsonWayException_SerializeObjectsIntoJsonFile()
        {
            JsonFileWriter writer = new JsonFileWriter();
            Assert.Throws<DirectoryNotFoundException>(() => writer.SerializeJson(users, "F:\\Users\\Король Андрей\\Documents\\GitHub\\TAT_2018\\TaskDEV8\\namesakes.json"));        
        }        
    }
}