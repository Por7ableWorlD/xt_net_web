using System;
using System.Collections.Generic;
using Entities;

namespace Data.Storages.Interface
{
    public interface IAwardsStorage
    {
        void CreateNewAward(AwardEntity award);

        void UpdateAward(AwardEntity award);

        AwardEntity GetAwardById(Guid id);

        void DeleteAwardById(Guid id);

        IEnumerable<AwardEntity> GetAllAwards();
    }
}