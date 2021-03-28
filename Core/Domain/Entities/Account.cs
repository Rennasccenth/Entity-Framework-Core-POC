using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    [Table("Accounts")]
    public class Account : IBaseEntity
    {
        public Guid Guid { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool Deleted { get; set; }
        
        public string Owner { get; set; }
        public long Balance { get; set; }
        
        // Relationships
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}