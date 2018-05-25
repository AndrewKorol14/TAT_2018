using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using TaskDEV9;

namespace VkPagesTest
{
    [TestClass]
    public class ListOfFriendsGetterTest
    {
        private IWebDriver driver;
        [TestInitialize]

        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [TestMethod]
        public void GetListOfFriendsTests()
        {
            LoginPage login = new LoginPage(driver);
            login.GoToPage();
            NewsPage news = login.LoginIntoVk("375291377614", "ivanov14");
            FriendsPage friends = news.GoToFriends();               
            IList<IWebElement> listOfFriends = friends.GetListOfFriends();
            LogoutPage logout = new LogoutPage(driver);
            logout.LogoutFromVk();
        }

        [TestCleanup]
        public void TearDown()
        {
            driver.Close();
        }        
    }
}