using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;

namespace TaskDEV9
{
    /// <summary>
    /// Call all methods for all tested web pages
    /// </summary>
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                ChromeDriver driver = new ChromeDriver();
                LoginPage login = new LoginPage(driver);
                login.GoToPage();
                NewsPage news = login.LoginIntoVk(args[0], args[1]);
                string lastNews = news.GetLastNews();
                Console.WriteLine("Last news: " + lastNews);
                MessagesPage messages = news.GoToMessages();
                messages.OpenLastDialog();
                string lastMessage = messages.GetLastMessage();
                Console.WriteLine("Last message: " + lastMessage);
                news.GoToFriends();
                FriendsPage friends = new FriendsPage(driver);
                IList<IWebElement> friendList = friends.GetListOfFriends();
                Console.WriteLine("Friends:");
                foreach (IWebElement friend in friendList)
                {
                    Console.WriteLine(friend.Text);
                }
                LogoutPage logout = new LogoutPage(driver);
                logout.LogoutFromVk();
                driver.Quit();
            }
            catch(WebDriverTimeoutException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}