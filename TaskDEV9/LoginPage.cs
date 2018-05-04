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

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        } 

        /// <summary>
        /// Goes to login page
        /// </summary>
        public void GoToPage()
        {
            driver.Navigate().GoToUrl("https://vk.com");            
        }     
        
        /// <summary>
        /// Login into VK system
        /// </summary>
        /// <param name="login">Login of account</param>
        /// <param name="password">Password of account</param>
        /// <returns>News page, or home page for VK</returns>
        public NewsPage LoginIntoVk(string login, string password)
        {
            loginField = driver.FindElement(By.Id("index_email"));
            loginField.SendKeys(login);
            passwordField = driver.FindElement(By.Id("index_pass"));
            passwordField.SendKeys(password);
            loginButton = driver.FindElement(By.Id("index_login_button"));
            loginButton.Click();
            return new NewsPage(driver);
        }        
    }
}