using System.Collections.Generic;

namespace EF_Core_POC.Models.Entity
{
    public class Account : BaseEntity
    {
        public string Owner { get; set; }
        public IList<Transaction> Transactions { get; set; }
        public long Balance { get; set; }
    }
}