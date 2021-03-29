using System;
using WebApplication.Models;

namespace WebApplication.AppService.Interfaces
{
    public interface IBaseAppService<T> where T : BaseEntity
    {
        public T Get(Guid id);

        public Guid Add(T entity);

        public T? Update(T entity);

        public T? Remove(T entity);
    }
}