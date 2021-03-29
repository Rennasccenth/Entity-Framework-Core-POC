using System;
using WebApplication.AppService.Interfaces;
using WebApplication.Models.Entity;

namespace WebApplication.AppService
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