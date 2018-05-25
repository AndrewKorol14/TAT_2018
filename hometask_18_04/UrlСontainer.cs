using System.Collections.Generic;

namespace hometask_18_04
{
    /// <summary>
    /// Create container of URL addresses and names of files
    /// </summary>
    class UrlСontainer
    {
        List<FileAddress> urls;
        
        /// <summary>
        /// Create container for addresses of files, which read from JSON-file
        /// </summary>
        public UrlСontainer()
        {
            urls = new List<FileAddress>();
            JsonDeserializer editor = new JsonDeserializer();
            urls = editor.DeserializeJson("C:\\Users\\Король Андрей\\Documents\\GitHub\\TAT_2018\\hometask_18_04\\addresses.json");            
        }

        public List<FileAddress> Urls
        {
            get { return urls; }
        } 
    }
}