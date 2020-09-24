using System;
using System.Collections.Generic;

namespace Entities
{
    public class AwardEntity : AbstractBaseEntity
    {
        public string Title { get; set; }

        public List<Guid> UsersAwarded { get; set; }

    }
}