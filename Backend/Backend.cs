using System.Net;
using Interfaces;
using Models;

namespace Services
{
    public class Backend : WebClient
    {
        public Backend(string address = "192.168.56.101:3000")
        {
            BaseAddress = "http://" + address;
        }

        public ITransactionSession StartSession()
        {
            string trans = DownloadString(BaseAddress + "/register_sessions");
            IJObject jobject = new JObjectAddapter(trans);
            return new TransactionSession(jobject);
        }
    }
}