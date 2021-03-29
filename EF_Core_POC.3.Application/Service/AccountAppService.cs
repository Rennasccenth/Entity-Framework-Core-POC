using System;
using Nullnes.EF_Core_POC.Application.Service.Interfaces;
using Nullnes.EF_Core_POC.Domain.Entities;

namespace Nullnes.EF_Core_POC.Application.Service
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

        public Account Update(Account entity)
        {
            throw new NotImplementedException();
        }

        public Account Remove(Account entity)
        {
            throw new NotImplementedException();
        }
    }
}