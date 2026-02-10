using Homework5.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5.Infrastructure.Repository
{
    public class SquadRepository
    {
        private AppDbContext context;

        public SquadRepository(AppDbContext context)
        {
            this.context = context;
        }

        public void AddUser(Squad t)
        {
            context.Squads.Add(t);
            context.SaveChanges();
        }

        public void AddUsers(List<Squad> t)
        {
            context.Squads.AddRange(t);
            context.SaveChanges();
        }

        public void UpdateUser(int id, int newplayer)
        {
            var t = context.Squads.FirstOrDefault(u => u.SquadId == id);

        }

        public void UpdateAllUsers(int newplayer)
        {
            var t = context.Squads?.Where(u => true).ToList();

        }

        public void DeleteUser(int id)
        {
            var user = context.Squads?.FirstOrDefault(u => u.SquadId == id);
            if (user != null)
            {
                context.Squads?.Remove(user);
                context.SaveChanges();
            }
        }

        public void DeleteAllUsers()
        {
            var users = context.Squads?.ToList();
            if (users != null && users.Any())
            {
                context.Squads?.RemoveRange(users);
                context.SaveChanges();
            }
        }

        public void ShowUser(int id)
        {
            var user = context.Squads?.FirstOrDefault(u => u.SquadId == id);
            if (user != null)
            {
                Console.WriteLine($"ID: {user.SquadId}, Player: {user.Players}");


            }

        }

        public void ShowUser(Squad t)
        {
            var result = context.Squads?.FirstOrDefault(u => u == t);
            if (result != null)
            {
                Console.WriteLine($"ID: {result.SquadId}, Player: {result.Players}");
            }
        }

        public void ShowAllUsers()
        {
            var users = context.Squads?.ToList();
            if (users != null && users.Any())
            {
                foreach (var user in users)
                {
                    Console.WriteLine($"ID: {user.SquadId}, Player: {user.Players}");
                }

            }
        }
    }
}

