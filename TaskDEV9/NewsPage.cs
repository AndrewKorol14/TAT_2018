using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace TaskDEV9
{
    /// <summary>
    /// Create object of news page
    /// </summary>
    public class NewsPage
    {
        private IWebDriver driver;
        private IWebElement messagesLabel;
        private IWebElement friendsLabel;
        private IWebElement lastNews;
        private Locators.NewsPageLocators locator;

        public NewsPage(IWebDriver driver)
        {
            this.driver = driver;
            locator = new Locators.NewsPageLocators();
        }

        /// <summary>
        /// Gets the last news from list of news
        /// </summary>
        /// <returns>Last news</returns>
        public string GetLastNews()
        {
            WebDriverWait waiter = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            lastNews = waiter.Until(driver => driver.FindElement(By.XPath(locator.LastNewsLocator)));
            lastNews = waiter.Until(ExpectedConditions.ElementToBeClickable(lastNews));
            return lastNews.Text;
        }

        /// <summary>
        /// Goes to list of dialogs in message section 
        /// </summary>
        /// <returns></returns>
        public MessagesPage GoToMessages()
        {
            WebDriverWait waiter = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            messagesLabel = waiter.Until(driver => driver.FindElement(By.Id(locator.MessagesLabelLocator)));
            messagesLabel = waiter.Until(ExpectedConditions.ElementToBeClickable(messagesLabel));
            messagesLabel.Click();
            return new MessagesPage(driver);
        }

        /// <summary>
        /// Goes to list of friends in friend section
        /// </summary>
        /// <returns></returns>
        public FriendsPage GoToFriends()
        {
            WebDriverWait waiter = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            friendsLabel = waiter.Until(driver => driver.FindElement(By.Id(locator.FriendsLabelLocator)));
            friendsLabel = waiter.Until(ExpectedConditions.ElementToBeClickable(friendsLabel));
            friendsLabel.Click();
            return new FriendsPage(driver);
        }
    }
}
