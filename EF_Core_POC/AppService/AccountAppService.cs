using System;
using System.Linq;
using EF_Core_POC.AppService.Interfaces;
using EF_Core_POC.Models.Entity;

namespace EF_Core_POC.AppService
{
    public class AccountAppService : IAccountAppService
    {
        public Account Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public Guid Add(Account entity)
        {
            throw new NotImplementedException();
        }

        public Account? Update(Account entity)
        {
            throw new NotImplementedException();
        }

        public Account? Remove(Account entity)
        {
            throw new NotImplementedException();
        }
    }
}