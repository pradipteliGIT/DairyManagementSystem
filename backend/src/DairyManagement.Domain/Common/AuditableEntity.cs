using System;
using System.Collections.Generic;
using System.Text;

namespace DairyManagement.Domain.Common
{
    public abstract class AuditableEntity : BaseEntity, IAuditableEntity
    {
        public DateTime CreatedAtUtc { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? UpdatedAtUtc { get; set; }

        public Guid? UpdatedBy { get; set; }
    }
}
