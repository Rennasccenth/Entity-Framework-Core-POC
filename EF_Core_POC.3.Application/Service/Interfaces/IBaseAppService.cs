using System;
using Nullnes.EF_Core_POC.Domain.Entities;

namespace Nullnes.EF_Core_POC.Application.Service.Interfaces
{
    public interface IBaseAppService<T> where T : IBaseEntity
    {
        public T Get(Guid id);

        public Guid Add(T entity);

        public T Update(T entity);

        public T Remove(T entity);
    }
}