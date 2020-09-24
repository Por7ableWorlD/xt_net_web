using System;

namespace Entities.Interface
{
    public interface IBaseEntity
    {
        Guid Id { get; set; }

        DateTime DateOfCreation { get; set; }
    }
}