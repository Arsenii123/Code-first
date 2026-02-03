
using Homework5.Infrastructure;
using Homework5.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5.Infrastructure.Repositories
{
    public class SportRepository
    {
        private AppDbContext context;

        public SportRepository(AppDbContext context)
        {
            this.context = context;
        }

        public void AddUser(Sport sport)
        {
            context.Sport.Add(sport);
            context.SaveChanges();
        }

        public void AddUsers(List<Sport> sports)
        {
            context.Sport.AddRange(sports);
            context.SaveChanges();
        }

        public void UpdateUser(int id, int newplayer)
        {
            var user = context.Sport.FirstOrDefault(u => u.SportId == id);
            if (user != null)
            {
                user.Player = newplayer;
                context.SaveChanges();
            }
        }

        public void UpdateAllUsers(int newplayer)
        {
            var users = context.Sport?.Where(u => true).ToList();
            if (users != null)
            {
                foreach (var user in users)
                {
                    user.Player = newplayer;
                }
                context.SaveChanges();
            }
        }

        public void DeleteUser(int id)
        {
            var user = context.Sport?.FirstOrDefault(u => u.SportId == id);
            if (user != null)
            {
                context.Sport?.Remove(user);
                context.SaveChanges();
            }
        }

        public void DeleteAllUsers()
        {
            var users = context.Sport?.ToList();
            if (users != null && users.Any())
            {
                context.Sport?.RemoveRange(users);
                context.SaveChanges();
            }
        }

        public void ShowUser(int id)
        {
            var user = context.Sport?.FirstOrDefault(u => u.SportId == id);
            if (user != null)
            {
                Console.WriteLine($"ID: {user.SportId}, Name: {user.Name}, Max playing: {user.Player}");
            }
        }

        public void ShowUser(Sport sport)
        {
            var result = context.Sport?.FirstOrDefault(u => u == sport);
            if (result != null)
            {
                Console.WriteLine($"ID: {sport.SportId}, Name: {sport.Name}, Max playing: {sport.Player}");
            }
        }

        public void ShowAllUsers()
        {
            var users = context.Sport.ToList();
            if (users != null && users.Any())
            {
                foreach (var user in users)
                {
                    Console.WriteLine($"ID: {user.SportId}, Name: {user.Name}, Max playing: {user.Player}");
                }
            }
        }
    }
}
