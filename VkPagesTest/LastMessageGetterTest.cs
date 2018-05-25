using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using TaskDEV9;

namespace VkPagesTest
{
    [TestClass]
    public class LastMessageGetterTest
    {
        private IWebDriver driver;

        [TestInitialize]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [TestMethod]
        public void GetLastMessageTests()
        {
            LoginPage login = new LoginPage(driver);
            login.GoToPage();
            NewsPage news = login.LoginIntoVk("375291377614", "ivanov14");
            MessagesPage messages = news.GoToMessages();
            messages.OpenLastDialog();
            string lastMessage = messages.GetLastMessage();
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