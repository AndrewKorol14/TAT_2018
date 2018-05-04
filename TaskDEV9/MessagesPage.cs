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
        
        public MessagesPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        /// <summary>
        /// Opens the last dialog 
        /// </summary>
        public void OpenLastDialog()
        {
            WebDriverWait waiter = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            lastDialog = waiter.Until(driver => driver.FindElement(By.XPath("//*[@id=\"im_dialogs\"]//li[1]")));
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
            lastMessage = waiter.Until(driver => driver.FindElement(By.XPath("//div[@class=\"_im_peer_history im-page-chat-contain\"]/div[last()]//li[last()]")));
            lastMessage = waiter.Until(ExpectedConditions.ElementToBeClickable(lastMessage));
            return lastMessage.Text;
        }
    }
}