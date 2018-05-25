using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

namespace TaskDEV9
{
    /// <summary>
    /// Create object of friends page
    /// </summary>
    public class FriendsPage
    {
        private IWebDriver driver;
        private IList<IWebElement> friendList;
        private IWebElement friendContainer;
        private Locators.FriendsPageLocators locator;

        public FriendsPage(IWebDriver driver)
        {
            this.driver = driver;
            locator = new Locators.FriendsPageLocators();
        }

        /// <summary>
        /// Gets list of all friends
        /// </summary>
        /// <returns></returns>
        public IList<IWebElement> GetListOfFriends()
        {
            WebDriverWait waiter = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            friendContainer = waiter.Until(driver => driver.FindElement(By.ClassName(locator.FriendsListLocator)));
            IWebElement friendCount = waiter.Until(driver => driver.FindElement(By.XPath(locator.FriendsCountLocator)));
            friendList = friendContainer.FindElements(By.XPath(locator.FriendTitleLocator));
            while (friendCount.Text!=friendList.Count.ToString())
            {
                js.ExecuteScript(locator.FriendsListScrollerLocator);
                friendList = friendContainer.FindElements(By.XPath(locator.FriendTitleLocator));
            }
            return friendList;
        }
    }
}