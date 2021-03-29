using System;
using System.Linq;
using WebApplication.AppService.Interfaces;
using WebApplication.Models.Entity;

namespace WebApplication.AppService
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