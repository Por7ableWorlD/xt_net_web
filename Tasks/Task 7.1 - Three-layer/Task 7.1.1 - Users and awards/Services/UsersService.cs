using Data.Storages.Interface;
using Data.Storages;
using Domain;
using Services.Interface;
using System;
using Searching;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    public class UsersService : IUsersService
    {
        private readonly IUsersStorage _usersStorage;

        private static List<User> _listOfUsers = new List<User>();

        public UsersService()
        {
            _usersStorage = new UsersStorage();

            foreach (var user in _usersStorage.GetAllUsers())
            {
                _listOfUsers.Add(user.EntityToDomain());
            }
        }

        public void SaveUserToStorage(User user)
        {
            _usersStorage.CreateNewUser(user.DomainToEntity());
        }

        public void SaveAllChanges()
        {
            foreach (var user in _listOfUsers)
            {
                SaveUserToStorage(user);
            }
        }

        public void AddUser(User user)
        {
            if (_listOfUsers.Contains(user))
            {
                UpdateUser(user);
            }
            else
            {
                _listOfUsers.Add(user);
            }
        }


        public void DeleteUserById(Guid id)
        {
            var user = GetUserById(id);
            _listOfUsers.Remove(user);
            _usersStorage.DeleteUserById(id);
        }

        public User GetUserById(Guid id)
        {
            return _listOfUsers.FirstOrDefault(n => n.Id == id);
        }

        public void UpdateUser(User user)
        {
            DeleteUserById(user.Id);
            _listOfUsers.Add(user);
        }

        public List<User> GetUsersList() => _listOfUsers;

        public void AddAwardToUser(Guid awardId, Guid userId)
        {
            var user = GetUserById(userId);
            var _newAwardsService = new AwardsService();
            var award = _newAwardsService.GetAwardById(awardId);
            user.Awards.Add(award.Id);
            award.UsersAwarded.Add(user.Id);
            UpdateUser(user);
            _newAwardsService.UpdateAward(award);
        }

        public void RemoveAwardFromUser(Guid awardId, Guid userId)
        {
            var user = GetUserById(userId);
            var _newAwardsService = new AwardsService();
            var award = _newAwardsService.GetAwardById(awardId);
            user.Awards.Add(award.Id);
            award.UsersAwarded.Remove(user.Id);
            UpdateUser(user);
            _newAwardsService.UpdateAward(award);
        }
    }
}