using Interfaces;

namespace Models
{
    public class TransactionSession : ITransactionSession
    {
        public TransactionSession(IJObject parameters)
        {
            Id = parameters.GetValue<int>("id");
            CustormeId = parameters.GetValue<int>("CustomerId");
        }

        public int CustormeId { get; set; }
        public int Id { get; set; }
    }
}