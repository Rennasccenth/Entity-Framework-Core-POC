using System;

namespace EF_Core_POC.Models
{
    public class BaseEntity : IBaseEntity
    {
        public Guid Guid { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool Deleted { get; set; }
    }
}