using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace TaskDEV9
{
    /// <summary>
    /// Create object of messages page
    /// </summary>
    public class MessagesPage
    {
        private IWebDriver driver;
        private IWebElement lastDialog;
        private IWebElement lastMessage;
        private Locators.MessagesPageLocators locator;
        
        public MessagesPage(IWebDriver driver)
        {
            this.driver = driver;
            locator = new Locators.MessagesPageLocators();
        }

        /// <summary>
        /// Opens the last dialog 
        /// </summary>
        public void OpenLastDialog()
        {
            WebDriverWait waiter = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            lastDialog = waiter.Until(driver => driver.FindElement(By.XPath(locator.LastDialogLocator)));
            lastDialog = waiter.Until(ExpectedConditions.ElementToBeClickable(lastDialog));
            lastDialog.Click();
        }

        /// <summary>
        /// Gets the last message from last dialog
        /// </summary>
        /// <returns>Last message</returns>
        public string GetLastMessage()
        {
            WebDriverWait waiter = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            lastMessage = waiter.Until(driver => driver.FindElement(By.XPath(locator.LastMessageLocator)));
            lastMessage = waiter.Until(ExpectedConditions.ElementToBeClickable(lastMessage));
            return lastMessage.Text;
        }
    }
}