using System;
using System.Linq;
using EF_Core_POC.Models.Entity;

namespace EF_Core_POC.AppService.Interfaces
{
    public interface ITransactionAppService
    {
        public Transaction Get(Guid id);
        public Guid Add(Transaction entity);
        public Transaction? Update(Transaction entity);
        public Transaction? Remove(Transaction entity);
    }
}