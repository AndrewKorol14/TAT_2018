namespace hometask_18_04
{
    /// <summary>
    /// Create address of file in internet
    /// </summary>
    class FileAddress
    {
        string address;
        string fileName;

        public FileAddress(string address, string fileName)
        {
            this.address = address;
            this.fileName = fileName;
        }

        public string Address
        {
            get { return address; }
        }

        public string FileName
        {
            get { return fileName; }
        }
    }
}