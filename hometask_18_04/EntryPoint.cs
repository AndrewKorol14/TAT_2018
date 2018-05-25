namespace hometask_18_04
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            FileDownloader downloader = new FileDownloader();
            downloader.InitiateDownloader();
        }
    }
}
