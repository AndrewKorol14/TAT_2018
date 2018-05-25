namespace TaskDEV9
{
    /// <summary>
    /// Container for all locators
    /// </summary>
    public class Locators
    {
        /// <summary>
        /// Container for friends page locators
        /// </summary>
        public class FriendsPageLocators
        {
            public string FriendsListLocator
            {
                get { return "friends_list_bl"; }
            }

            public string FriendsCountLocator
            {
                get { return "//*[@id=\"friends_tab_all\"]//*[@class=\"ui_tab_count\"]"; }
            }

            public string FriendTitleLocator
            {
                get { return "//*[@class=\"friends_field friends_field_title\"]"; }
            }

            public string FriendsListScrollerLocator
            {
                get { return "window.scrollBy(0, document.body.scrollHeight)"; }
            }
        }

        /// <summary>
        /// Container for login page locators
        /// </summary>
        public class LoginPageLocators
        {
            public string VkPageLocator
            {
                get { return "https://vk.com"; }
            }

            public string EmailFieldLocator
            {
                get { return "index_email"; }
            }

            public string PasswordFieldLocator
            {
                get { return "index_pass"; }
            }

            public string LoginButtonLocator
            {
                get { return "index_login_button"; }
            }
        }

        /// <summary>
        /// Container for news page locators
        /// </summary>
        public class NewsPageLocators
        {
            public string FriendsLabelLocator
            {
                get { return "l_fr"; }
            }

            public string MessagesLabelLocator
            {
                get { return "l_msg"; }
            }

            public string LastNewsLocator
            {
                get { return "//div[@id=\"feed_rows\"]/div[1]"; }
            }
        }

        /// <summary>
        /// Container for messages page locators
        /// </summary>
        public class MessagesPageLocators
        {
            public string LastDialogLocator
            {
                get { return "//*[@id=\"im_dialogs\"]//li[1]"; }
            }

            public string LastMessageLocator
            {
                get { return "//div[@class=\"_im_peer_history im-page-chat-contain\"]/div[last()]//li[last()]"; }
            }
        }

        /// <summary>
        /// Container for logout page locators
        /// </summary>
        public class LogoutPageLocators
        {
            public string LogoutMenuLocator
            {
                get { return "top_profile_name"; }
            }

            public string LogoutLabelLocator
            {
                get { return "top_logout_link"; }
            }
        }
    }
}