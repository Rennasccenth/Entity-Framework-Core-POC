using System;
using EF_Core_POC.Models.Entity;

namespace EF_Core_POC.AppService.Interfaces
{
    public class TransactionAppService : ITransactionAppService
    {
        public Transaction Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public Guid Add(Transaction entity)
        {
            throw new NotImplementedException();
        }

        public Transaction? Update(Transaction entity)
        {
            throw new NotImplementedException();
        }

        public Transaction? Remove(Transaction entity)
        {
            throw new NotImplementedException();
        }
    }
}