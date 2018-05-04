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

        public NewsPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        /// <summary>
        /// Gets the last news from list of news
        /// </summary>
        /// <returns>Last news</returns>
        public string GetLastNews()
        {
            WebDriverWait waiter = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            lastNews = waiter.Until(driver => driver.FindElement(By.XPath("//div[@id=\"feed_rows\"]/div[1]")));
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
            messagesLabel = waiter.Until(driver => driver.FindElement(By.Id("l_msg")));
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
            friendsLabel = waiter.Until(driver => driver.FindElement(By.Id("l_fr")));
            friendsLabel = waiter.Until(ExpectedConditions.ElementToBeClickable(friendsLabel));
            friendsLabel.Click();
            return new FriendsPage(driver);
        }
    }
}
