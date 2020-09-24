using Data.Storages.Interface;
using Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Data.Storages
{
    public class UsersStorage : IUsersStorage
    {
        public static string DataPath => "C:\\Users\\Александр\\Desktop\\xt_net_web\\Tasks\\Task 7.1 - Three-layer\\Task 7.1.1 - Users and awards\\Storage\\";

        public void CreateNewUser(UserEntity user)
        {
            var fileName = "User_" + user.Id + ".json";
            var userData = JsonConvert.SerializeObject(user);

            using (var writer = new StreamWriter(DataPath + fileName))
                writer.Write(userData);
        }

        public void DeleteUserById(Guid id)
        {
            var fileName = "User_" + id + ".json";
            var pathToFile = DataPath + fileName;
            File.Delete(pathToFile);
        }

        public UserEntity GetUserById(Guid id)
        {
            return GetAllUsers().FirstOrDefault(x => x.Id == id);
        }

        public void UpdateUser(UserEntity user)
        {
            var oldUser = GetUserById(user.Id);

            if (oldUser == null)
            {
                CreateNewUser(user);
            }
            else
            {
                DeleteUserById(oldUser.Id);
                CreateNewUser(user);
            }
        }

        public IEnumerable<UserEntity> GetAllUsers()
        {
            var directory = new DirectoryInfo(DataPath);

            foreach (var file in directory.GetFiles())
                using (var reader = new StreamReader(file.FullName))
                    yield return JsonConvert.DeserializeObject<UserEntity>(reader.ReadToEnd());
        }
    }
}