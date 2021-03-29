using System;
using Nullnes.EF_Core_POC.Application.Service.Interfaces;
using Nullnes.EF_Core_POC.Domain.Entities;

namespace Nullnes.EF_Core_POC.Application.Service
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

        public Transaction Update(Transaction entity)
        {
            throw new NotImplementedException();
        }

        public Transaction Remove(Transaction entity)
        {
            throw new NotImplementedException();
        }
    }
}