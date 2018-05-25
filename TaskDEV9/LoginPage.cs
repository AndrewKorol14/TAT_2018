using OpenQA.Selenium;

namespace TaskDEV9
{
    /// <summary>
    /// Create object of login page
    /// </summary>
    public class LoginPage
    {
        private IWebDriver driver;
        private IWebElement loginField;
        private IWebElement passwordField;
        private IWebElement loginButton;
        private Locators.LoginPageLocators locator;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            locator = new Locators.LoginPageLocators();
        } 

        /// <summary>
        /// Goes to login page
        /// </summary>
        public void GoToPage()
        {
            driver.Navigate().GoToUrl(locator.VkPageLocator);            
        }     
        
        /// <summary>
        /// Login into VK system
        /// </summary>
        /// <param name="login">Login of account</param>
        /// <param name="password">Password of account</param>
        /// <returns>News page, or home page for VK</returns>
        public NewsPage LoginIntoVk(string login, string password)
        {
            loginField = driver.FindElement(By.Id(locator.EmailFieldLocator));
            loginField.SendKeys(login);
            passwordField = driver.FindElement(By.Id(locator.PasswordFieldLocator));
            passwordField.SendKeys(password);
            loginButton = driver.FindElement(By.Id(locator.LoginButtonLocator));
            loginButton.Click();
            return new NewsPage(driver);
        }        
    }
}