using System;
using System.ComponentModel.DataAnnotations.Schema;
using Nullnes.EF_Core_POC.Domain.Enums;

namespace Nullnes.EF_Core_POC.Domain.Entities
{
    [Table("Transactions")]
    public class Transaction : IBaseEntity
    {
        public Guid Guid { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool Deleted { get; set; }

        public long Amount { get; set; }
        public Related Type { get; set; }
        public bool? IsPlanned { get; set; }

        // Relationships
        public Guid AccountId { get; set; }
        public Account Account { get; set; }
    }
}