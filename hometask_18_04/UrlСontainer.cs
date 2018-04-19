using System.Collections.Generic;

namespace hometask_18_04
{
    /// <summary>
    /// Create container of URL addresses and names of files
    /// </summary>
    class UrlСontainer
    {
        List<FileAddress> urls;
        
        public UrlСontainer()
        {
            urls = new List<FileAddress>();
            urls.Add(new FileAddress("https://raw.githubusercontent.com/AndrewKorol14/TAT_2018/temp_for_hometask/files_for_downloading/dogAndWolf.jpg", "file1.jpg"));
            urls.Add(new FileAddress("https://raw.githubusercontent.com/AndrewKorol14/TAT_2018/temp_for_hometask/files_for_downloading/dogAndWolf.jpg", "file2.jpg"));
            urls.Add(new FileAddress("https://raw.githubusercontent.com/AndrewKorol14/TAT_2018/temp_for_hometask/files_for_downloading/C_6_0_Spravochnik_Polnoe_opisanie_yazyka_-_2016.pdf", "file3.pdf"));
        }

        public List<FileAddress> Urls
        {
            get { return urls; }
        } 
    }
}