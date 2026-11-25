using DairyManagement.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DairyManagement.Domain.Common
{
    public class BaseEntity:IEntity
    {
        public Guid Id { get; protected set; } = Guid.NewGuid();
    }
}
