using System;
using System.Collections.Generic;
using System.Text;

namespace DairyManagement.Domain.Interfaces
{
    public interface IEntity
    {
        Guid Id { get; }
    }
}
