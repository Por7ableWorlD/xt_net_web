using Data.Storages.Interface;
using Data.Storages;
using Domain;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using Searching;

namespace Services
{
    public class AwardsService : IAwardsService
    {
        private readonly IAwardsStorage _awardsStorage;

        private static List<Award> _listOfAwards = new List<Award>();

        public AwardsService()
        {
            _awardsStorage = new AwardsStorage();

            foreach (var award in _awardsStorage.GetAllAwards())
            {
                _listOfAwards.Add(award.EntityToDomain());
            }
        }
        public void SaveAwardToStorage(Award award)
        {
            _awardsStorage.CreateNewAward(award.DomainToEntity());
        }

        public void SaveAllChanges()
        {
            foreach (var award in _listOfAwards)
            {
                SaveAwardToStorage(award);
            }
        }

        public void AddAward(Award award)
        {
            if (_listOfAwards.Contains(award))
            {
                UpdateAward(award);
            }
            else
            {
                _listOfAwards.Add(award);
            }
        }

        public void DeleteAwardById(Guid id)
        {
            var award = GetAwardById(id);
            _listOfAwards.Remove(award);
            _awardsStorage.DeleteAwardById(id);
        }

        public Award GetAwardById(Guid id)
        {
            return _listOfAwards.FirstOrDefault(n => n.Id == id);
        }

        public void UpdateAward(Award award)
        {
            DeleteAwardById(award.Id);
            _listOfAwards.Add(award);
        }

        public List<Award> GetAwardsList()
        {
            return _listOfAwards;
        }
    }
}