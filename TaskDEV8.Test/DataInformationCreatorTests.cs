using System;
using NUnit.Framework;
using System.Collections.Generic;

namespace TaskDEV8.Test
{
    [TestFixture]
    public class DataInformationCreatorTests
    {
        [TestCase(20.0)]
        public void CountAverageAge_CalculateAverageAge_AverageAge(double expectedValue)
        {
            DataInformationCreator dataInfo = new DataInformationCreator();
            List<User> users = new List<User>();
            users.Add(new User("aaa", "AAA", "man", 20));
            users.Add(new User("bbb", "BBB", "woman", 10));
            users.Add(new User("ccc", "AAA", "man", 30));
            double actualValue = dataInfo.CountAverageAge(users);
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void FindOldestUsers_OldestUser_OldestUser()
        {
            DataInformationCreator dataInfo = new DataInformationCreator();
            List<User> users = new List<User>();
            users.Add(new User("aaa", "AAA", "man", 20));
            users.Add(new User("bbb", "BBB", "woman", 10));
            users.Add(new User("ccc", "AAA", "man", 30));
            List<User> actualUsers = dataInfo.FindOldestUsers(users);
            List<User> expectedUsers = new List<User>();
            expectedUsers.Add(new User("ccc", "AAA", "man", 30));
            for(int i = 0; i < expectedUsers.Count; i++)
            {
                Assert.AreEqual(expectedUsers[i].FirstName, actualUsers[i].FirstName);
                Assert.AreEqual(expectedUsers[i].LastName, actualUsers[i].LastName);
                Assert.AreEqual(expectedUsers[i].Gender, actualUsers[i].Gender);
                Assert.AreEqual(expectedUsers[i].Age, actualUsers[i].Age);
            }
        }

        [Test]
        public void FindOldestUsers_SomeOldestUser_OldestUser()
        {
            DataInformationCreator dataInfo = new DataInformationCreator();
            List<User> users = new List<User>();
            users.Add(new User("aaa", "AAA", "man", 30));
            users.Add(new User("bbb", "BBB", "woman", 30));
            users.Add(new User("ccc", "AAA", "man", 30));
            List<User> actualUsers = dataInfo.FindOldestUsers(users);
            List<User> expectedUsers = new List<User>();
            expectedUsers.Add(new User("aaa", "AAA", "man", 30));
            expectedUsers.Add(new User("bbb", "BBB", "woman", 30));
            expectedUsers.Add(new User("ccc", "AAA", "man", 30));
            for (int i = 0; i < expectedUsers.Count; i++)
            {
                Assert.AreEqual(expectedUsers[i].FirstName, actualUsers[i].FirstName);
                Assert.AreEqual(expectedUsers[i].LastName, actualUsers[i].LastName);
                Assert.AreEqual(expectedUsers[i].Gender, actualUsers[i].Gender);
                Assert.AreEqual(expectedUsers[i].Age, actualUsers[i].Age);
            }
        }

        [Test]
        public void FindPopularWomanNames_OneName_MostPopularWomanName()
        {
            DataInformationCreator dataInfo = new DataInformationCreator();
            List<User> users = new List<User>();
            users.Add(new User("aaa", "AAA", "man", 20));
            users.Add(new User("bbb", "BBB", "woman", 10));
            users.Add(new User("ccc", "AAA", "man", 30));
            List<String> actualNames = dataInfo.FindPopularWomanNames(users);
            List<String> expectedNames = new List<String>() { "bbb" };
            for (int i = 0; i < expectedNames.Count; i++)
            {
                Assert.AreEqual(expectedNames[i], actualNames[i]);
            }
        }

        [Test]
        public void FindPopularWomanNames_TwoNames_MostPopularWomanName()
        {
            DataInformationCreator dataInfo = new DataInformationCreator();
            List<User> users = new List<User>();
            users.Add(new User("aaa", "AAA", "man", 20));
            users.Add(new User("bbb", "BBB", "woman", 10));
            users.Add(new User("ccc", "AAA", "woman", 30));
            List<String> actualNames = dataInfo.FindPopularWomanNames(users);
            List<String> expectedNames = new List<String>() { "bbb" , "ccc"};
            for (int i = 0; i < expectedNames.Count; i++)
            {
                Assert.AreEqual(expectedNames[i], actualNames[i]);
            }
        }

        [Test]
        public void FindPopularWomanNames_TwoBetweenThreeNames_MostPopularWomanName()
        {
            DataInformationCreator dataInfo = new DataInformationCreator();
            List<User> users = new List<User>();
            users.Add(new User("ccc", "AAA", "woman", 20));
            users.Add(new User("bbb", "BBB", "woman", 10));
            users.Add(new User("ccc", "AAA", "woman", 30));
            List<String> actualNames = dataInfo.FindPopularWomanNames(users);
            List<String> expectedNames = new List<String>() { "ccc" };
            for (int i = 0; i < expectedNames.Count; i++)
            {
                Assert.AreEqual(expectedNames[i], actualNames[i]);
            }
        }
    }
}