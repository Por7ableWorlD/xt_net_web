using System;
using System.Collections.Generic;
using Entities;

namespace Data.Storages.Interface
{
    public interface IUsersStorage
    {
        void CreateNewUser(UserEntity user);

        void UpdateUser(UserEntity user);

        UserEntity GetUserById(Guid id);

        void DeleteUserById(Guid id);

        IEnumerable<UserEntity> GetAllUsers();

    }
}