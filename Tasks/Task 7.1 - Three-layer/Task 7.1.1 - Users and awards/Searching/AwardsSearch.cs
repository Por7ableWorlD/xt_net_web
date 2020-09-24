using Domain;
using Entities;
using Bases;
using System;
using System.Collections.Generic;

namespace Searching
{
    public static class AwardsSearch
    {
        public static AwardEntity DomainToEntity(this Award award)
        {
            if (award == null)
            {
                return null;
            }

            DateTime created = DateTime.Now;

            return new AwardEntity
            {
                Id = award.Id,
                Title = award.Title,
                UsersAwarded = award.UsersAwarded,
                DateOfCreation = created
            };
        }

        public static Award EntityToDomain(this AwardEntity award)
        {
            if (award == null)
            {
                return null;
            }

            return new Award
            {
                Id = award.Id,
                Title = award.Title,
                UsersAwarded = award.UsersAwarded
            };
        }

        public static Award BaseToDomain(this AwardBase award)
        {
            if (award == null)
            {
                return null;
            }

            return new Award
            {
                Id = award.Id,
                Title = award.Title,
                UsersAwarded = new List<Guid>()
            };
        }

        public static AwardBase DomainToBase(this Award award)
        {
            if (award == null)
            {
                return null;
            }

            return new AwardBase
            {
                Id = award.Id,
                Title = award.Title
            };
        }
    }
}