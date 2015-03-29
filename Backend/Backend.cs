using System;
using System.ComponentModel;
using System.Net;
using Interfaces;
using Interfaces.Identifiable;

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

        public IJObject Request(string url)
        {
            throw new NotImplementedException();
        }
    }

    public class TransactionSession : ITransactionSession
    {
        public TransactionSession(IJObject jobject)
        {
            throw new NotImplementedException();
        }

        public long Id { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName = null)
        {
            throw new NotImplementedException();
        }
    }
}