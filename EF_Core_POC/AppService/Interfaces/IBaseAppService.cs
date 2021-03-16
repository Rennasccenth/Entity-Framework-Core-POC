using System;
using EF_Core_POC.Models;

namespace EF_Core_POC.AppService.Interfaces
{
    public interface IBaseAppService<T> where T : BaseEntity
    {
        public T Get(Guid id);

        public Guid Add(T entity);

        public T? Update(T entity);

        public T? Remove(T entity);
    }
}