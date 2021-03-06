﻿using System;
using System.Collections.Generic;

namespace Entities
{
    public class UserEntity : AbstractBaseEntity
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public DateTime DateOfBirth { get; set; }

        public List<Guid> Awards { get; set; }
    }
}