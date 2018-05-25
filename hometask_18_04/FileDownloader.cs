using System;
using System.Net;
using System.Threading.Tasks;

namespace hometask_18_04
{
    /// <summary>
    /// Download file from internet
    /// </summary>
    class FileDownloader
    {
        /// <summary>
        /// Initiate downloading of file 
        /// </summary>
        public void InitiateDownloader()
        {
            UrlСontainer adresses = new UrlСontainer();
            foreach(FileAddress adress in adresses.Urls)
            {
                StartDownload(adress.Address, adress.FileName).GetAwaiter().GetResult();
                DateTime finishTime = new DateTime();
                finishTime = DateTime.Now;
                Console.WriteLine("Finish time: " + finishTime);                
            }
        }

        static async Task StartDownload(string adress, string fileName)
        {
            DateTime time = await Task.Run(() => DownloadFile(adress, fileName));
            Console.WriteLine("File " + fileName + " from " + adress + " was downoloaded");
            Console.WriteLine("Start time: " + time);
        }

        static DateTime DownloadFile(string adress, string fileName)
        {
            WebClient webClient = new WebClient();
            DateTime startTime = new DateTime();
            startTime = DateTime.Now;
            webClient.DownloadFile(adress, fileName);
            return startTime;
        }
    }
}