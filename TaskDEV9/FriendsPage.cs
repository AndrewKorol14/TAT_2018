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

        public FriendsPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        /// <summary>
        /// Gets list of all friends
        /// </summary>
        /// <returns></returns>
        public IList<IWebElement> GetListOfFriends()
        {
            WebDriverWait waiter = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            friendContainer = waiter.Until(driver => driver.FindElement(By.ClassName("friends_list_bl")));
            IWebElement friendCount = waiter.Until(driver => driver.FindElement(By.XPath("//*[@id=\"friends_tab_all\"]//*[@class=\"ui_tab_count\"]")));
            friendList = friendContainer.FindElements(By.XPath("//*[@class=\"friends_field friends_field_title\"]"));
            while (friendCount.Text!=friendList.Count.ToString())
            {
                js.ExecuteScript("window.scrollBy(0, document.body.scrollHeight)");
                friendList = friendContainer.FindElements(By.XPath("//*[@class=\"friends_field friends_field_title\"]"));
            }
            return friendList;
        }
    }
}