using System;
using EF_Core_POC.Models.Entity;

namespace EF_Core_POC.AppService.Interfaces
{
    public interface ITransactionAppService : IBaseAppService<Transaction>
    {
    }
}