using API.Controllers;
using Bases;
using System;

namespace Task_7._1._1___Users_and_awards
{
    class Program
    {
        static void Main(string[] args)
        {
            UserBase user1 = new UserBase();
            user1.Name = "Petya";
            user1.DateOfBirth = new DateTime(1991, 01, 1).Date;
            user1.Id = Guid.NewGuid();

            UserBase user2 = new UserBase();
            user2.Name = "Vasya";
            user2.DateOfBirth = new DateTime(1992, 02, 2).Date;
            user2.Id = Guid.NewGuid();

            UserBase user3 = new UserBase();
            user3.Name = "Kolya";
            user3.DateOfBirth = new DateTime(1993, 03, 3).Date;
            user3.Id = Guid.NewGuid();

            AwardBase award1 = new AwardBase();
            award1.Title = "Winner";
            award1.Id = Guid.NewGuid();
            AwardBase award2 = new AwardBase();
            award2.Title = "Medallist";
            award2.Id = Guid.NewGuid();
            AwardBase award3 = new AwardBase();
            award3.Title = "Participant";
            award3.Id = Guid.NewGuid();

            UsersAwardsController controller = new UsersAwardsController();

            controller.AddNewUser(user1);
            controller.AddNewUser(user2);
            controller.AddNewUser(user3);

            controller.AddNewAward(award1);
            controller.AddNewAward(award2);
            controller.AddNewAward(award3);

            controller.AddAwardToUser(award1, user1);
            controller.AddAwardToUser(award2, user2);
            controller.AddAwardToUser(award3, user3);

            controller.SaveAllChanges();

            controller.DisplayUserInfo(user1);
            controller.DisplayUserInfo(user2);
            controller.DisplayUserInfo(user3);
            Console.WriteLine("===\nList of users:\n===");
            controller.DisplayUsersList();
            controller.DisplayAwardInfo(award1);

            Console.ReadLine();
        }
    }
}
