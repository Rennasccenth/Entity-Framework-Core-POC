using System;

namespace Nullnes.EF_Core_POC.Domain.Entities
{
    public interface IBaseEntity
    {
        public Guid Guid { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool Deleted { get; set; }
    }
}