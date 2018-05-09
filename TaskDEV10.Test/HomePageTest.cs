using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TaskDEV10.Test
{
    [TestClass]
    public class HomePageTest
    {
        private IWebDriver driver;

        [TestInitialize]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://av.by");
            driver.Manage().Window.Maximize();
        }

        [TestMethod]
        [ExpectedException(typeof(NoSuchElementException))]
        public void ChooseBrandTests()
        {
            HomePage homePage = new HomePage(driver);
            homePage.ChooseBrand("Машинка");            
        }

        [TestCleanup]
        public void TearDown()
        {
            driver.Close();
        }
    }
}