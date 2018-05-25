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
        private Locators.LogoutPageLocators locator;

        public LogoutPage(IWebDriver driver)
        {
            this.driver = driver;
            locator = new Locators.LogoutPageLocators();
        }

        public void LogoutFromVk()
        {
            WebDriverWait waiter = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            logoutLabel = waiter.Until(driver => driver.FindElement(By.ClassName(locator.LogoutMenuLocator)));
            logoutLabel = waiter.Until(ExpectedConditions.ElementToBeClickable(logoutLabel));
            logoutLabel.Click();
            logoutLabel = waiter.Until(driver => driver.FindElement(By.Id(locator.LogoutLabelLocator)));
            logoutLabel = waiter.Until(ExpectedConditions.ElementToBeClickable(logoutLabel));
            logoutLabel.Click();
        }
    }
}