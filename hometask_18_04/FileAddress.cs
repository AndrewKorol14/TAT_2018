using System.Runtime.Serialization;

namespace hometask_18_04
{
    /// <summary>
    /// Create address of file in internet
    /// </summary>
    [DataContract]
    class FileAddress
    {
        [DataMember]
        string address;
        [DataMember]
        string fileName;

        public FileAddress(string address, string fileName)
        {
            this.address = address;
            this.fileName = fileName;
        }

        [DataMember]
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        [DataMember]
        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }
    }
}