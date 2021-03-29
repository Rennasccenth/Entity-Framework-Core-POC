using System;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplication.Models.Enums;

namespace WebApplication.Models.Entity
{
    [Table("Transactions")]
    public class Transaction : BaseEntity
    {
        public Guid AccountId { get; set; }
        public Account Account { get; set; }
        public long Amount { get; set; }
        public Related Type { get; set; }
        public bool? IsPlanned { get; set; }
    }
}