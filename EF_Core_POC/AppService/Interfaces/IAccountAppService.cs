using System;
using System.Linq;
using EF_Core_POC.Models.Entity;

namespace EF_Core_POC.AppService.Interfaces
{
    public interface IAccountAppService
    {
        public Account Get(Guid id);
        public IQueryable<Account> GetAll(Account entity);
        public Guid Add(Account entity);
        public Account? Update(Account entity);
        public Account? Remove(Account entity);
    }
}