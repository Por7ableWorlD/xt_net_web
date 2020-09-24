using System;
using Entities.Interface;

namespace Entities
{
    public abstract class AbstractBaseEntity : IBaseEntity
    {
        public Guid Id { get; set; }

        public DateTime DateOfCreation { get; set; }
    }
}