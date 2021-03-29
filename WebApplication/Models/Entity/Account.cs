using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication.Models.Entity
{
    [Table("Accounts")]
    public class Account : BaseEntity
    {
        public string Owner { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
        public long Balance { get; set; }
    }
}