﻿using Searching;
using Bases;
using Services;
using Services.Interface;
using System;
using System.Text;

namespace API.Controllers
{
    public class UsersAwardsController
    {
        private readonly IUsersService _usersService;
        private readonly IAwardsService _awardsService;

        public UsersAwardsController()
        {
            _usersService = new UsersService();
            _awardsService = new AwardsService();
        }

        public void AddNewUser(UserBase model)
        {
            _usersService.AddUser(model.BaseToDomain());
        }

        public void AddAwardToUser(AwardBase award, UserBase user)
        {
            _usersService.AddAwardToUser(award.Id, user.Id);
        }

        public void RemoveAwardFromUser(AwardBase award, UserBase user)
        {
            _usersService.RemoveAwardFromUser(award.Id, user.Id);
        }

        public void AddNewAward(AwardBase model)
        {
            _awardsService.AddAward(model.BaseToDomain());
        }

        public void SaveAllChanges()
        {
            _usersService.SaveAllChanges();
            _awardsService.SaveAllChanges();
        }

        public void DisplayUserInfo(UserBase user)
        {
            var userDomain = _usersService.GetUserById(user.Id);
            Console.WriteLine("*** User Info ***");
            Console.WriteLine("Id: {0}", userDomain.Id);
            Console.WriteLine("Name: {0}", userDomain.Name);
            Console.WriteLine("Age: {0}", userDomain.Age);
            Console.WriteLine("Birthday: {0:M}", userDomain.DateOfBirth);
            Console.WriteLine("Awards: {0}", DisplayUserAwards(user));
        }

        public string DisplayUserAwards(UserBase user)
        {
            var userDomain = _usersService.GetUserById(user.Id);
            StringBuilder s = new StringBuilder();

            if (userDomain.Awards == null)
            {
                return "No awards";
            }

            foreach (var awardId in userDomain.Awards)
            {
                var award = _awardsService.GetAwardById(awardId);
                s.Append(award.Title + " ");
            }

            return s.ToString();
        }

        public void DisplayUsersList()
        {
            var list = _usersService.GetUsersList();
            if (list.Count < 1)
            {
                Console.WriteLine("The user list is empty.");
            }
            else
            {
                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine("{0}: {1}, {2} year old", i + 1, list[i].Name, list[i].Age);
                }
            }
        }

        public void DisplayAwardInfo(AwardBase award)
        {
            Console.WriteLine("*** Award Info ***");
            Console.WriteLine("Title: {0}", award.Title);
            Console.WriteLine("Users awarded: {0}", DisplayUsersAwarded(award));
        }

        public string DisplayUsersAwarded(AwardBase award)
        {
            var awardDomain = _awardsService.GetAwardById(award.Id);
            StringBuilder s = new StringBuilder();

            if (awardDomain.UsersAwarded == null)
            {
                return "No user has received this award.";
            }

            foreach (var userId in awardDomain.UsersAwarded)
            {
                var user = _usersService.GetUserById(userId);
                s.Append(user.Name + " ");
            }

            return s.ToString();
        }
    }
}