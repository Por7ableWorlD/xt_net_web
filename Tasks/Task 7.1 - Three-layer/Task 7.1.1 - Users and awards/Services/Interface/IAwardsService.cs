using Domain;
using System;
using System.Collections.Generic;

namespace Services.Interface
{
    public interface IAwardsService
    {
        void SaveAllChanges();

        void SaveAwardToStorage(Award award);

        void AddAward(Award award);

        void UpdateAward(Award award);

        Award GetAwardById(Guid id);

        void DeleteAwardById(Guid id);

        List<Award> GetAwardsList();
    }
}