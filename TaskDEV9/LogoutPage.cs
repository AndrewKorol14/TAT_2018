using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace TaskDEV9
{
    /// <summary>
    /// Create object of logout page
    /// </summary>
    public class LogoutPage
    {
        private IWebDriver driver;
        private IWebElement logoutLabel;

        public LogoutPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void LogoutFromVk()
        {
            WebDriverWait waiter = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            logoutLabel = waiter.Until(driver => driver.FindElement(By.ClassName("top_profile_name")));
            logoutLabel = waiter.Until(ExpectedConditions.ElementToBeClickable(logoutLabel));
            logoutLabel.Click();
            logoutLabel = waiter.Until(driver => driver.FindElement(By.Id("top_logout_link")));
            logoutLabel = waiter.Until(ExpectedConditions.ElementToBeClickable(logoutLabel));
            logoutLabel.Click();
        }
    }
}