using System;
using System.Collections.Generic;
using System.Text;

namespace DairyManagement.Domain.Common
{
    public interface ISoftDeletable
    {
        bool IsDeleted { get; set; }

        DateTime? DeletedAtUtc { get; set; }

        Guid? DeletedBy { get; set; }
    }
}
