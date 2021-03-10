using System.Collections.Generic;

namespace EF_Core_POC.Models.Entity
{
    public class Account : BaseEntity
    {
        public string Owner { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
        public long Balance { get; set; }
    }
}